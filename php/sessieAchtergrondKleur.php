<?php
/**
 * Created by PhpStorm.
 * User: jesse
 * Date: 28-11-2018
 * Time: 11:19
 */

session_start();


?>

<html>
<body>
<form action="" method="get">
    <p>kies achtergrond kleur:</p>
    <input type="color" name="color" value=$_SESSION['color']>
    <input type="submit" value="Verzenden">
</form>


</body>
</html>

<?php
if (!empty($_GET["color"]))
{
    $_SESSION['color'] = $_GET["color"];

}
if (!isset($_SESSION["color"]))
{
    $_SESSION['color'] = "white";
}
$color_session = $_SESSION['color'];
//echo "bgcolor=$color_session";
echo "<style> body{ background-color:$color_session;} </style>";

//eigen extra probeer text lichter te krijgen als background donkere word

?>