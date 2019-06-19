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


if (!empty($_POST["name"]) and !empty($_POST["geboortejaar"]) and !empty($_POST["game"]) and !empty($_POST["aantal"]) and !empty($_POST["prijs"]) and !empty($_POST["leeftijd"]))
{
    //altijd komt de els
    $naam = $_POST["name"];

    $geboortejaar = new DateTime($_POST["geboortejaar"]);
    //$geboortejaar2 = $geboortejaar ->format('Y');
    $today = new DateTime(date("Y"));
    //date_create()
    //new DateTime()
    // diff doet het nu denk ik maar kan niet worden omgezet naar int
    $diff = date_diff($geboortejaar, $today);
    $year = $diff->format('%y');

    $leeftijd = $_POST["leeftijd"];

    $aantal = $_POST["aantal"];
    $game = $_POST["game"];
    $prijs = $_POST["prijs"];
    $totaalPrijs = $prijs * $aantal;

    $sqlInsert = "INSERT INTO shop (Naam, Geboortejaar, Spelnaam, Aantal, Prijs, Totaalprijs) VALUES ('".$_POST["name"]."','".$_POST["geboortejaar"]."','".$_POST["game"]."' ,'".$_POST["aantal"]."','".$_POST["prijs"]."', '".$totaalPrijs."')";


    $bestellling = "<h1>Besteling van $naam</h1>
            <p>Spel: $game</p>
            <p>Aantal: $aantal</p>
            <p>Prijs per stuk: $prijs</p>
            <p><strong>Totaalprijs: $totaalPrijs</strong></p>";


    //echo $totaalPrijs;

    //if ($connection ->query($sqlInsert) == TRUE)
    //{
        //echo "INSERTED";
        //echo "<style> form{ display: none;} </style>";

        // probleem zit in de $leeftijd nee de probleem zit in dat het niet kan rekenen met date
        if ($leeftijd = "AlleLeeftijden" && $year <=0)
        {
            echo $bestellling;
            $connection ->query($sqlInsert) == TRUE;
        }

        else if ($leeftijd = "+12" && $year >=12)
        {
            echo $bestellling;
            $connection ->query($sqlInsert) == TRUE;
        }

        else if ($leeftijd = "+14" && $year >=14)
        {
            echo $bestellling;
            $connection ->query($sqlInsert) == TRUE;
        }

        else if ($leeftijd = "+18" && $year >=18)
        {
            echo $bestellling;
            $connection ->query($sqlInsert) == TRUE;
        }
        else{
            echo "<h1>Besteling van $naam</h1>
            <p>Sorry, je bent te jong om dit spel aan te schaffen.</p>";
        }
    /*}
    else{
        echo "Error: " . $sqlInsert . "<br>" . $connection->error;
    }*/
}

// laat datebase inhoud zien

$sql = "SELECT * FROM shop";
//$result = mysqli_query($connection, $sql);
$result = $connection->query($sql); //dit kan ook

echo "
<h1>Lijst met gebruikers</h1>
<table border='1'>
<tr>
<th>Naam</th>
<th>Geboortejaar</th>
<th>Spelnaam</th>
<th>Aantal</th>
<th>Prijs</th>
<th>Totaalprijs</th>
</tr>";


//while($row = mysqli_fetch_array($result)) kan ook
while($row = $result->fetch_assoc())
{
    echo "<tr>";
    echo "<td>" . $row['Naam'] . "</td>";
    echo "<td>" . $row['Geboortejaar'] . "</td>";
    echo "<td>" . $row['Spelnaam'] . "</td>";
    echo "<td>" . $row['Aantal'] . "</td>";
    echo "<td>" . $row['Prijs'] . "</td>";
    echo "<td>" . $row['Totaalprijs'] . "</td>";
    echo "</tr>";
}
echo "</table>";

mysqli_close($connection);
?>