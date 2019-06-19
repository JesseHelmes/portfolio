<?php
/**
 * Created by PhpStorm.
 * User: jesse
 * Date: 24-9-2018
 * Time: 13:47
 */

function welkomMsg()
{
    echo "Hello World!";
}
welkomMsg();

echo"<br><br><br>";

function familyName($fname)
{
    echo "$fname Helmes.<br>";
}

familyName("Jesse");
familyName("Bennie");
familyName("Wesley");

echo"<br><br><br>";

function optellen($x, $z)//begreep ik niet helemaal
{
    $i = $x + $z;
    echo $i;
}

optellen(3, 5);

echo "<br>";

$x = 4;
$z = 7;
function optellen2($x, $z)//begreep ik niet helemaal
{
    $i = $x + $z;
    return $i;
}

echo optellen2($x, $z);

echo "<br><br><br>";

//je kunt blijkbaar de eerste letter gebruiken van een variable
$lengt = 10;
$breedte = 4;
$hoogte = 3;
function inhoud($l, $b, $h)
{
    $i = $l * $b * $h;
    return $i;
    //echo $i;
}

echo inhoud($lengt, $breedte, $hoogte);


echo "<br><br><br>";

//je had de achtergrond lengte en hoogte of breedte

function balk($hoogte, $breedte, $kleur)
{
    //<div id="black"></div>
    //<div id="yellow"></div>
   echo "<div style='height: $hoogte; width: $breedte; background-color: $kleur;'></div>";

}

balk(150, 200, "black");
balk(50, 400, "yellow");
balk(350, 50, "red");
echo"<br><br><br>";


function rolDice()
{
    //rand(1, 6);
    return rand(1, 6);
}
function rolDices($i)
{
    for ($x = 1; $x <= $i; $x++)
    {
        //rolDice();
        echo rolDice() . "<br>";
        //return rolDice() . "<br";
    }
}
rolDices(5);//laat tot nu toe maar 1 getaal zien

echo"<br><br><br>";


function printArray()
{
    $number = array (6, 4, 3, 1, 4, 4, 4, 6, 1, 2);
    foreach ($number as $key => $value)
    {
        echo "[{$key}] => {$value}<br>";
    }
}
printArray();
?>