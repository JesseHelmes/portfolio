<?php
include('Film.php');
include('../07/JWT.php');

$films = array();
$getJson = file_get_contents('php://input');

//Bearer eyJ0eXAiOiJKV1QiLCAiYWxnIjoiSFMyNTYifQ.eyJpZCI6MSwgInVzZXJuYW1lIjoiYWRtaW4iLCAiYXV0aGx2bCI6NH0.MDM4ZTlhZjgwZGI2YWJmMjYzOGNjM2EyNzE0OWNhNzZhNGRjNGM5NGRlZjNmNDI1MTAyZDdhZjA3NzhjZmRiZQ

//htaccess turn .php into api

function connect(){
	//Maak verbinding met database
	$host = 'localhost';
	$dbuser = 'jhelmes_security_user';
	$dbpass = 'iy4KfR8rSanZrn6';
	$dbname = 'jhelmes_security';
	$conn = new mysqli($host, $dbuser, $dbpass, $dbname);
	if ($conn->connect_error) {die("Connection failed: " . $conn->connect_error);}

	return $conn;
}

function laadFilms(){

	$conn = connect();

	//Vraag resultaat
	$sql = $conn->prepare("SELECT * FROM films");

	//voert uit
	$sql->execute();

	//krijg resultaat
	$result = $sql->get_result();

	//Sluit verbinding met database
	$sql->close();
	$conn->close();

	//maakt variable globaal zodat je die kunt aanpassen
	global $films;

	while($row = $result->fetch_assoc()){
		$film = new Film;
		$film->setId($row['id']);
		$film->setTitel($row['titel']);
		$film->setSpeelduur($row['speelduur']);
		$film->setKijkwijzer($row['kijkwijzer']);
		$film->setGenre($row['genre']);

		$films[] = $film;
	}

	echo json_encode($films, true);
}

function laadFilm($id){

	$conn = connect();

	//Vraag resultaat
	$sql = $conn->prepare("SELECT * FROM films WHERE id = ?");

	$sql->bind_param("i", $id);

	//voert uit
	$sql->execute();

	//krijg resultaat
	$result = $sql->get_result();

	//Sluit verbinding met database
	$sql->close();
	$conn->close();

	//maakt variable globaal zodat je die kunt aanpassen
	global $films;

	while($row = $result->fetch_assoc()){
		$film = new Film;
		$film->setId($row['id']);
		$film->setTitel($row['titel']);
		$film->setSpeelduur($row['speelduur']);
		$film->setKijkwijzer($row['kijkwijzer']);
		$film->setGenre($row['genre']);

		$films[] = $film;
	}

	echo json_encode($films, true);
}

function voegtoeFilm($json){
	/*
{
	"titel": "sponegebob",
	"speelduur": "01:22:22",
	"kijkwijzer": "12",
	"genre": "animatie"
}
	*/
	$data = json_decode($json);

	$conn = connect();

	//Insert resultaat
	$sql = $conn->prepare("INSERT INTO films (titel, speelduur, kijkwijzer, genre) VALUES (?, ?, ?, ?)");

	$sql->bind_param("ssis", $data->titel, $data->speelduur, $data->kijkwijzer, $data->genre);

	//voert uit
	$sql->execute();

	//Sluit verbinding met database
	$sql->close();
	$conn->close();
}

function verwijderFilm($json){
/*
{
	"id": "4"
}
	*/
	$data = json_decode($json);

	$conn = connect();

	//Delete resultaat
	$sql = $conn->prepare("DELETE FROM films WHERE id = ?");

	$sql->bind_param("i", $data->id);

	//voert uit
	$sql->execute();

	//Sluit verbinding met database
	$sql->close();
	$conn->close();
}

//laadFilms();

//JWT stuff
$jwt = new JWT;

$auth = $_SERVER['HTTP_AUTH'];
$token = $jwt->decodeToken($auth);
$lvl = $token['authlvl'];

$request = $_SERVER['REQUEST_METHOD'];
$response;

if($lvl >= 1 && $request == "GET"){
	$response = "U mag gegevens ophalen.";
	if(isset($_GET['id'])){
		laadFilm($_GET['id']);
	}else{
		laadFilms();
	}
}
else if($lvl >= 2 && $request == "POST"){
	$response = "U mag gegevens toevoegen.";
	voegtoeFilm($getJson);
}
else if($lvl >= 3 && $request == "PUT"){
	$response = "U mag gegevens bijwerken.";
}
else if($lvl >= 4 && $request == "DELETE"){
	$response = "U mag gegevens verwijderen.";
	verwijderFilm($getJson);
}
else{
	$response = "U heeft niet de juiste rechten voor deze handeling.";
}

echo "\n" . $response;
?>