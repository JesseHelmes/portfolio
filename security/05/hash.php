<?php
//redirct naar https
if(!$_SERVER["HTTPS"]){
	$redirect_url = "https://" . $_SERVER['HTTP_HOST'] . $_SERVER['REQUEST_URI'];
	header("Location: $redirect_url");
	exit();
}


//Als loginformulier reeds werd verzonden
if($_SERVER["REQUEST_METHOD"] == "POST"){
	ConvertToHash($_POST["hash"] . 'azerty1234');
}


function ConvertToHash($hash){
	echo "input: " . $hash . "<br>";
	echo "MD5: " . md5($hash) . "<br>";
	echo "SHA-1: " . sha1($hash) . "<br>";
	echo "SHA-256: " . hash("sha256", $hash) . "<br>";
	echo "is niet altijd hetzelfde<br>";
	echo "password_hash() " . password_hash($hash, PASSWORD_DEFAULT) . "<br>";
}
?>


<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<title>Hash</title>
	<!--Externe stylesheets-->
	<link href="https://getbootstrap.com/docs/4.1/dist/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://getbootstrap.com/docs/4.1/examples/sign-in/signin.css" rel="stylesheet">
</head>

<body class="text-center">
<form action="hash.php" method="post" class="form-signin">
	<input type="text" id="inputHash" name="hash" class="form-control" placeholder="Hashinput" required>
	<input  type="submit" class="btn btn-lg btn-primary btn-block" value="Hash">
</form>
</body>
<script>
	var path = window.location.protocol;
	if(path !== 'https:'){
		location.replace(`https:${location.href.substring(location.protocol.length)}`);
	}
</script>
</html>