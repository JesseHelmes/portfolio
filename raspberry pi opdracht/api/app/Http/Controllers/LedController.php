<?php

namespace App\Http\Controllers;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;

use PhpGpio\Gpio;

class LedController extends Controller
{
	////Module 5 - Solderen Prototype board - KBE2020.pdf
	public $leds = array(
		17, 18
	);

	public function leds()
	{
		exec('modprobe w1-gpio');

		$gpio = new GPIO();

		$json = array();

		for ($i = 0; $i < count($this->leds); $i++) {
			$pin = $this->leds[$i];

			$gpio->setup($pin, "out");
			$gpio->output($pin, 1);

			//ik gebruik $i nummer wegens de nummers op de pi
			$json[] = ["id" => $i, "pin" => $pin, "status" => 1];
		}

		return response()->json($json);
	}

	public function led(Request $request)
	{
		exec('modprobe w1-gpio');

		//zet inkomende json om naar parameters
		$id = $request->input('id');
		$status = $request->input('status');

		$gpio = new GPIO();
		$pin = $this->leds[$id];

		$gpio->setup($pin, "out");
		$gpio->output($pin, $status);

	}

	public function morse(Request $request)
	{
		exec('modprobe w1-gpio');
		$gpio = new GPIO();

		$message = strtolower($request->input('message'));
		$message = str_split($message);
		$ledCount = count($this->leds);

		//zet eerst alles uit
		for ($i = 0; $i < $ledCount; $i++) {
			$pin = $this->leds[$i];

			$gpio->setup($pin, "out");
			$gpio->output($pin, 1);
		}

		//https://morsecode.world/international/translator.html
		//morse code tabel
		$morseTable = ["a" => ".-", "b" => "-...", "c" => "-.-.", "d" => "-..",
			"e" => ".", "f" => "..-.", "g" => "--.", "h" => "....",
			"i" => "..", "j" => ".---", "k" => "-.-", "l" => ".-..",
			"m" => "--", "n" => "-.", "o" => "---", "p" => ".--.",
			"q" => "--.-", "r" => ".-.", "s" => "...", "t" => "-",
			"u" => "..-", "v" => "...-", "w" => ".--", "x" => "-..-",
			"y" => "-.--", "z" => "--..", "0" => "-----", "1" => ".----",
			"2" => "..---", "3" => "...--", "4" => "....-", "5" => ".....",
			"6" => "-....", "7" => "--...", "8" => "---..", "9" => "----.",
			" " => " ", "-" => "-", "." => ".", "?" => "..--..",
			"!" => "-.-.--", "," => "--..--"
		];

		////convert text naar morse want dat is minder internet verkeer
		$morse = "";
		for ($i = 0; $i < count($message); $i++) {
			//if(in_array($message[$i], $morseTable)){
			$morse .= $morseTable[$message[$i]];
			//echo $message[$i];
			//}
		}
		$morse = str_split($morse);

		//voert code uit
		$unit = 1024;

		for ($x = 0; $x < count($morse); $x++) {
			$dot = $morse[$x];
			if ($dot == "-") {
				for ($i = 0; $i < $ledCount; $i++) {
					$gpio->output($this->leds[$i], 0);
				}
				usleep($unit * 300);//$unit * 300
			} else if ($dot == ".") {
				for ($i = 0; $i < $ledCount; $i++) {
					$gpio->output($this->leds[$i], 0);
				}
				usleep($unit * 20);//$unit * 10
			} else {
				for ($i = 0; $i < $ledCount; $i++) {
					$gpio->output($this->leds[$i], 1);
				}
				usleep($unit * 200);
			}
			for ($i = 0; $i < $ledCount; $i++) {
				$gpio->output($this->leds[$i], 1);
			}
			usleep(1500000);
		}

	}

}

?>
