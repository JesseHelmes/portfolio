<?php

class Bicycle{

    public $brand;
    public $model;
    public $year;
    public $description = 'Used bicycle';
    // bug in $weight_kg vind het en fix het
    private $weight_kg = 0.0;
    protected $wheels = 2;

    public function name() {
        return $this->brand . " " . $this->model . " (" . $this->year . ")";
    }

    public function weight_lbs() {
        return floatval($this->weight_kg) * 2.2046226218 . " lbs";
    }

    public function set_weight_lbs($value) {
        $this->weight_kg = floatval($value) / 2.2046226218;
    }

    public function wheel_details(){
        //zat in solution
        $wheel_string = $this->wheels == 1 ? "1 wheel" : "{$this->wheels} wheels";
        return "it has " . $wheel_string . ".";
        //return "it has " . $this->wheels . " wheels";
    }

    public function set_weight_kg($kg){
        $this->weight_kg = floatval($kg);
    }

    public function get_weight_kg(){
        return $this->weight_kg . " kg";
    }
}

class Unicycle extends Bicycle{
    protected $wheels = 1;

    // zat in sollution
    public function bug_test(){
        //return $this->weight_kg;
    }
}

$trek = new Bicycle;
$trek->brand = 'Trek';
$trek->model = 'Emonda';
$trek->year = '2017';
$trek->set_weight_kg(1.0);
//$trek->weight_kg = 1.0;

$cd = new Unicycle();
$cd->brand = 'Cannondale';
$cd->model = 'Synapse';
$cd->year = '2016';
$cd->set_weight_kg(8.0);
//$cd->weight_kg = 8.0;

echo $trek->name() . "<br />";


echo $trek->get_weight_kg() . "<br />";
echo $trek->weight_lbs() . "<br />";
// notice that one is property, one is a method

$trek->set_weight_lbs(2);
echo $trek->get_weight_kg() . "<br />";
echo $trek->weight_lbs() . "<br />";

echo $trek->wheel_details() . "<br>";
echo "<br>";
echo $cd->name() . "<br />";
echo $cd->wheel_details() . "<br>";
echo $cd->get_weight_kg(). "<br />";;
echo $cd->weight_lbs() . "<br />";
?>
