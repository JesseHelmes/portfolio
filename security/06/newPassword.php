<?php
//redirct naar https
if(!$_SERVER["HTTPS"]){
	$redirect_url = "https://" . $_SERVER['HTTP_HOST'] . $_SERVER['REQUEST_URI'];
	header("Location: $redirect_url");
	exit();
}


//Als loginformulier reeds werd verzonden
if($_SERVER["REQUEST_METHOD"] == "POST"){
	updatePassword($_POST["username"], $_POST["email"], $_POST["password"], $_POST["code"]);
}
//https://www.youtube.com/watch?v=GiHaXbBTsL4&ab_channel=SoengSouyWebdesign
//https://www.soengsouy.com/2019/10/forgot-password-using-php.html

function updatePassword($username, $email, $password, $code){
	//Maak verbinding met database
	$host = 'localhost';
	$dbuser = 'jhelmes_security_user';
	$dbpass = 'iy4KfR8rSanZrn6';
	$dbname = 'jhelmes_security';
	$conn = new mysqli($host, $dbuser, $dbpass, $dbname);
	if ($conn->connect_error) {die("Connection failed: " . $conn->connect_error);}


	//Vraag resultaat van code
	$sql = $conn->prepare("SELECT * FROM users WHERE code = ?");

	$sql->bind_param("i", $code);

	//voert uit
	$sql->execute();

	//krijg resultaat
	$result = $sql->get_result();

	//Sluit verbinding met database
	$sql->close();

	//check of code in database zit
	if($result->num_rows == 0){
		echo "<script>alert('code niet gevonden');</script>";//geen gebruiker gevonden met die email!
	}else{
		//set code in database
		$hash = password_hash($password, PASSWORD_DEFAULT);
		$sql = $conn->prepare("UPDATE users SET password = ?, code = '' WHERE username = ? AND email = ?");

		$sql->bind_param("sss", $hash, $username, $email);

		//voert uit
		$sql->execute();
		$sql->close();
		echo "<script>alert('new password set');</script>";
	}

	$conn->close();
}
?>


<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<title>Update password</title>
	<!--Externe stylesheets-->
	<link href="https://getbootstrap.com/docs/4.1/dist/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://getbootstrap.com/docs/4.1/examples/sign-in/signin.css" rel="stylesheet">
</head>

<body class="text-center">
<form action="newPassword.php" method="post" class="form-signin">
	<input type="text" id="inputUsername" name="username" class="form-control" placeholder="Username" required autofocus>
	<input type="email" id="inputEmail" name="email" class="form-control" placeholder="Email" required autofocus>
	<input type="hidden" name="code" value="<?php echo !empty($_GET['code']) ?htmlspecialchars($_GET['code']) :''; ?>">
	<input type="password" id="inputPassword" name="password" class="form-control" placeholder="Nieuwe password" required>
	<input  type="submit" class="btn btn-lg btn-primary btn-block" value="set new password">
</form>
</body>
<script>
	var path = window.location.protocol;
	if(path !== 'https:'){
		location.replace(`https:${location.href.substring(location.protocol.length)}`);
	}
</script>
</html>