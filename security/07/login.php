<?php
include('JWT.php');

//redirct naar https
if(!$_SERVER["HTTPS"]){
	$redirect_url = "https://" . $_SERVER['HTTP_HOST'] . $_SERVER['REQUEST_URI'];
	header("Location: $redirect_url");
	exit();
}


//Als loginformulier reeds werd verzonden
if($_SERVER["REQUEST_METHOD"] == "POST"){
	login($_POST["username"], $_POST["password"]);
}


function login($username, $password){
	//hash password
	$hash = password_hash($password, PASSWORD_DEFAULT);

	//Maak verbinding met database
	$host = 'localhost';
	$dbuser = 'jhelmes_security_user';
	$dbpass = 'iy4KfR8rSanZrn6';
	$dbname = 'jhelmes_security';
	$conn = new mysqli($host, $dbuser, $dbpass, $dbname);
	if ($conn->connect_error) {die("Connection failed: " . $conn->connect_error);}


	//Vraag resultaat
	$sql = $conn->prepare("SELECT * FROM users WHERE username = ?");

	$sql->bind_param("s", $username);

	//voert uit
	$sql->execute();

	//krijg resultaat
	$result = $sql->get_result();

	//Sluit verbinding met database
	$sql->close();
	$conn->close();

	//Onderneem actie op basis van resultaat
	$results = $result->fetch_assoc();
	if ($result->num_rows == 0 && !password_verify($password, $results['password'])) {
		echo "<script>alert('Incorrecte gegevens!');</script>";
	} else {
		echo "<script>alert('Succes!');</script>";

		$results = $result->fetch_assoc();
		echo '<img src="'.$results['profielfoto'].'">';
		$jwt = new JWT;
		echo $jwt->getNewToken($results['id'], $results['username'], $results['authlvl']);
	}
}
?>


<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<title>Login</title>
	<!--Externe stylesheets-->
	<link href="https://getbootstrap.com/docs/4.1/dist/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://getbootstrap.com/docs/4.1/examples/sign-in/signin.css" rel="stylesheet">
</head>

<body class="text-center">
<form action="login.php" method="post" class="form-signin">
	<input type="text" id="inputUsername" name="username" class="form-control" placeholder="Username" required autofocus>
	<input type="password" id="inputPassword" name="password" class="form-control" placeholder="Password" required>
	<a href="resetPassword.php">forgot password</a>
	<input  type="submit" class="btn btn-lg btn-primary btn-block" value="Login">
</form>
</body>
<script>
	var path = window.location.protocol;
	if(path !== 'https:'){
		location.replace(`https:${location.href.substring(location.protocol.length)}`);
	}
</script>
</html>