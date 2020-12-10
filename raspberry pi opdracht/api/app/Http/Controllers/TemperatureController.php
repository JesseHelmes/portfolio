<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

use App\Models\Temperature;

class TemperatureController extends Controller
{

	public function temperature()
	{

		//activeerd gpio and therm
		exec('modprobe w1-gpio');
		exec('modprobe w1-therm');

		//leest de gegevens van de sensor die aangesloten is
		$base_dir = '/sys/bus/w1/devices/';
		$device_folder = glob($base_dir . '28*')[0];
		$device_file = $device_folder . '/w1_slave';
		$data = file($device_file, FILE_IGNORE_NEW_LINES);

		$temp = null;
		$zin;
		if (preg_match('/YES$/', $data[0])) {

			if (preg_match('/t=(\d+)$/', $data[1], $matches, PREG_OFFSET_CAPTURE)) {
				$temp = round($matches[1][0] / 1000, 1);
			}

		}

		if ($temp) {
			$zin = "Temperature is " . $temp . "C\n";
		} else {
			$zin = "Unable to get temperature\n";
		}

		$json = '{"celsius":' . $temp . '}';
		//echo $zin;
		return json_decode($json, true);
	}

	public function cpu()
	{
		//leest de intern tempratuur van de cpu bestand
		$f = fopen("/sys/class/thermal/thermal_zone0/temp", "r");
		$temp = (float)fgets($f);
		$temp = round($temp / 1000, 1);
		//echo 'CPU temperature is ' . $temp . "°C";
		fclose($f);

		$json = '{"celsius":' . $temp . '}';

		//hier voeg ik de gegevens toe aan de database
		$arr = array('temperature' => $temp, 'date' => date("Y-m-d"));
		$this->store($arr);

		return json_decode($json, true);
	}

	public function temperatures()
	{
		//pakt de laaste temperatuur die opgeslagen is als eerst op
		$temps = Temperature::latest()->get();
		return response()->json($temps);
	}

	//persist the new resource
	public function store($temp)
	{
		$temperature = Temperature::create($temp);
	}

	//validation
	protected function validateTemperature()
	{
		return request()->validate([
			'temperature' => 'required'
		]);
	}
}
