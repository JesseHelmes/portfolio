<?php

//Als loginformulier reeds werd verzonden
//if($_SERVER["REQUEST_METHOD"] == "POST"){

	$json = file_get_contents("php://input");

	$obj = json_decode($json);

	echo $obj->username . "\n";
	echo $obj->password . "\n";

	echo "Nu ik deze gegevens heb an ik ook weer inloggen (user object aanmaken met gegevens)\n";

	login($obj);
//}


function login($obj){
	//hash password
	$hash = password_hash($obj->password, PASSWORD_DEFAULT);

	//Maak verbinding met database
	$host = 'localhost';
	$dbuser = 'jhelmes_security_user';
	$dbpass = 'iy4KfR8rSanZrn6';
	$dbname = 'jhelmes_security';
	$conn = new mysqli($host, $dbuser, $dbpass, $dbname);
	if ($conn->connect_error) {die("Connection failed: " . $conn->connect_error);}


	//Vraag resultaat
	$sql = $conn->prepare("SELECT * FROM users WHERE username = ? AND password = ?");

	$sql->bind_param("ss", $obj->username, $hash);

	//voert uit
	$sql->execute();

	//krijg resultaat
	$result = $sql->get_result();

	//Sluit verbinding met database
	$sql->close();
	$conn->close();

	//Onderneem actie op basis van resultaat
	$results = $result->fetch_assoc();
	if ($result->num_rows == 0 && password_verify($obj->password, $results['password'])) {
		//echo "<script>alert('Incorrecte gegevens!');</script>";
	} else {
		//echo "<script>alert('Succes!');</script>";

		//$results = $result->fetch_assoc();


		//toegang
		//var_dump($_SERVER);
		$lvl = $results['authlvl'];
		$request = $_SERVER['REQUEST_METHOD'];
		$response;

		if($lvl >= 1 && $request == "GET"){
			$response = "U mag gegevens ophalen.";
		}
		else if($lvl >= 2 && $request == "POST"){
			$response = "U mag gegevens toevoegen.";
		}
		else if($lvl >= 3 && $request == "PUT"){
			$response = "U mag gegevens bijwerken.";
		}
		else if($lvl >= 4 && $request == "DELETE"){
			$response = "U mag gegevens verwijderen.";
		}
		else{
			$response = "U heeft niet de juiste rechten voor deze handeling.";
		}

		echo $response;


	}
}
?>