<?php
//var_dump($_SERVER);

$lvl = $_SERVER['HTTP_AUTHLVL'];
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
?>