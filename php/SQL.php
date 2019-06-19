<?php
/**
 * Created by PhpStorm.
 * User: jesse
 * Date: 11-12-2018
 * Time: 11:08
 */

$host    = "localhost";
$user    = "root";
$pass    = "";
$db_name = "phpperiode02";

//create connection
$connection = new mysqli($host, $user, $pass, $db_name);

//test if connection failed
if(mysqli_connect_errno()){
    die("connection failed: " . $connection->connect_error);
}
else{
    //echo "connected";

}
?>
<html>
<body>


<form action="" method="get">
    <p>Gewicht:
        <input type="number" name="gewicht">
    </p>

    <p>
        Legte:
        <input type="number" name="lengte">
    </p>

    <p>Leeftijd
        <input type="number" name="leeftijd">
    </p>

    <p>Geslacht:
        <input type="radio" name="geslacht" value="M">M
        <input type="radio" name="geslacht" value="V">V<br>
    </p>

    <input type="submit" value="BMI berekenen">
</form>


</body>
</html>

<?php
/**
 * Created by PhpStorm.
 * User: jesse
 * Date: 1-2-2019
 * Time: 08:59
 */


if (!empty($_GET["gewicht"]) and !empty($_GET["lengte"]) and !empty($_GET["leeftijd"]) and !empty($_GET["geslacht"]))
{

    Function berekenBMI($kg, $cm, $geslacht, $leeftijd){

        $bmi = $kg / (($cm/100) *  ($cm /100));
        return round($bmi, 2);
    }
    $sqlInsert = "INSERT INTO bmi (gewicht, lengte, leeftijd, geslacht) VALUES ('".$_GET["gewicht"]."','".$_GET["lengte"]."','".$_GET["leeftijd"]."' ,'".$_GET["geslacht"]."')";

    if ($_GET["leeftijd"] >= 18)
    {
        $connection ->query($sqlInsert) == TRUE;
        echo "Nieuwe regel toegevoegt!";
    }

    else
    {

    }

}

$sqlSelect = "SELECT * FROM bmi";

$result = $connection->query($sqlSelect);

$sqlBerekenBmi = "SELECT ('gewicht'/(('lengte'/100)*('lengte' /100))) FROM bmi";
$resultBmi = $connection->query($sqlBerekenBmi);

echo "
<h1>LEDEN lijst</h1>
<table border='1'>
<tr>
<th>lidnr</th>
<th>gewicht</th>
<th>lengte</th>
<th>leeftijd</th>
<th>geslacht</th>
<th>bmi</th>
</tr>";

while($row = $result->fetch_assoc())
{
    echo "<tr>";
    echo "<td>" . $row['lidnr'] . "</td>";
    echo "<td>" . $row['gewicht'] . "</td>";
    echo "<td>" . $row['lengte'] . "</td>";
    echo "<td>" . $row['leeftijd'] . "</td>";
    echo "<td>" . $row['geslacht'] . "</td>";

}
while ($resultBmi->fetch_assoc())
{
    echo "<td>" . $resultBmi . "</td>";
    echo "</tr>";
}
echo "</table>";

mysqli_close($connection);
?>