<?php
//redirct naar https
if(!$_SERVER["HTTPS"]){
	$redirect_url = "https://" . $_SERVER['HTTP_HOST'] . $_SERVER['REQUEST_URI'];
	header("Location: $redirect_url");
	exit();
}


//Als loginformulier reeds werd verzonden
if($_SERVER["REQUEST_METHOD"] == "POST"){
	checkUser($_POST["username"], $_POST["email"]);
}


function checkUser($username, $email){
	//Maak verbinding met database
	$host = 'localhost';
	$dbuser = 'jhelmes_security_user';
	$dbpass = 'iy4KfR8rSanZrn6';
	$dbname = 'jhelmes_security';
	$conn = new mysqli($host, $dbuser, $dbpass, $dbname);
	if ($conn->connect_error) {die("Connection failed: " . $conn->connect_error);}


	//Vraag resultaat
	$sql = $conn->prepare("SELECT * FROM users WHERE username = ? AND email = ?");

	$sql->bind_param("ss", $username, $email);

	//voert uit
	$sql->execute();

	//krijg resultaat
	$result = $sql->get_result();

	//Sluit verbinding met database
	$sql->close();

	if($result->num_rows == 0){
		echo "<script>alert('geen gebruiker met die email en username!');</script>";
	}else{
		//uniek code
		$code= rand(100,999);

		//Onderneem actie op basis van resultaat
		$results = $result->fetch_assoc();


		//set code in database
		$sql = $conn->prepare("UPDATE users SET code = ? WHERE id = ?");

		$sql->bind_param("si", $code, $results["id"]);

		//voert uit
		$sql->execute();

		//Sluit verbinding met database
		$sql->close();

		sendMail($code, $email);

	}
	$conn->close();
}

function sendMail($code, $email){
	$sender = "info@jhelmes.gc-webhosting.nl";
	$subject = "php mail reset password";
	$message="You activation link is:https://jhelmes.gc-webhosting.nl/security/05/newPassword.php?code=" . $code;
	//$header = "From: " . $sender;
	mail($email, $subject, $message, $sender);
	echo "<script>alert('email send!');</script>";
}

?>


<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<title>Reset passsword</title>
	<!--Externe stylesheets-->
	<link href="https://getbootstrap.com/docs/4.1/dist/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://getbootstrap.com/docs/4.1/examples/sign-in/signin.css" rel="stylesheet">
</head>

<body class="text-center">
<form action="resetPassword.php" method="post" class="form-signin">
	<input type="text" id="inputUsername" name="username" class="form-control" placeholder="Username" required autofocus>
	<input type="email" id="inputEmail" name="email" class="form-control" placeholder="Email" required autofocus>
	<input  type="submit" class="btn btn-lg btn-primary btn-block" value="reset password">
</form>
</body>
<script>
	var path = window.location.protocol;
	if(path !== 'https:'){
		location.replace(`https:${location.href.substring(location.protocol.length)}`);
	}
</script>
</html>