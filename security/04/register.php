<?php
//redirct naar https
if(!$_SERVER["HTTPS"]){
	$redirect_url = "https://" . $_SERVER['HTTP_HOST'] . $_SERVER['REQUEST_URI'];
	header("Location: $redirect_url");
	exit();
}

//Als registerformulier reeds werd verzonden
if($_SERVER["REQUEST_METHOD"] == "POST"){
	// https://www.codexworld.com/how-to/validate-password-strength-in-php/
	//https://www.w3resource.com/javascript/form/password-validation.php	helemaal onderaan
	//check sterk wachtwoord

	//IMAGE
	//profiel foto varieables

	//veranderd naam in een nummer
	$temp = explode(".", $_FILES["profielfoto"]["name"]);
	$newfilename = round(microtime(true)) . '.' . end($temp);

	$target_dir = "images/";
	$target_file = "../" . $target_dir . basename($newfilename);
	$uploadOk = 1;
	$imageFileType = strtolower(pathinfo($target_file,PATHINFO_EXTENSION));

	$check = getimagesize($_FILES["profielfoto"]["tmp_name"]);
	if($check !== false) {
		echo "File is an image - " . $check["mime"] . ".";
		$uploadOk = 1;
	} else {
		echo "File is not an image.";
		$uploadOk = 0;
	}

	// Check if file already exists
	if (file_exists($target_file)) {
		echo "Sorry, file already exists.";
		$uploadOk = 0;
	}

	// Check file size
	if ($_FILES["profielfoto"]["size"] < 50000 || $_FILES["profielfoto"]["size"] > 5000000 ) {//min 50kb max 5mb
		echo "Sorry, your file does not fit size. min 50kb max 5mb.";
		$uploadOk = 0;
	}

	// Allow certain file formats
	if($imageFileType != "jpg" && $imageFileType != "png" && $imageFileType != "jpeg"
	&& $imageFileType != "gif" ) {
		echo "Sorry, only JPG, JPEG, PNG & GIF files are allowed.";
		$uploadOk = 0;
	}

	// Check if $uploadOk is set to 0 by an error
	if ($uploadOk == 0) {
		echo "Sorry, your file was not uploaded.";
	// if everything is ok, try to upload file
	} else {
		if (move_uploaded_file($_FILES["profielfoto"]["tmp_name"], $target_file)) {
		echo "The file ". basename( $_FILES["profielfoto"]["name"]). " has been uploaded.";
		} else {
		echo "Sorry, there was an error uploading your file.";
		}
	}

	if($uploadOk){
		register($_POST["username"], $_POST["password"], $target_file);
	}
}


function register($username, $password, $target_file){
	//hash password
	$hash = password_hash($password, PASSWORD_DEFAULT);

	if(password_verify($password, $hash)){
		//Maak verbinding met database
		$host = 'localhost';
		$dbuser = 'jhelmes_security_user';
		$dbpass = 'iy4KfR8rSanZrn6';
		$dbname = 'jhelmes_security';
		$conn = new mysqli($host, $dbuser, $dbpass, $dbname);
		if ($conn->connect_error) {die("Connection failed: " . $conn->connect_error);}

		//Insert resultaat
		$sql = $conn->prepare("INSERT INTO users (username, password, profielfoto) VALUES (?, ?, ?)");

		$sql->bind_param("sss", $username, $hash, $target_file);

		//voert uit
		$sql->execute();

		//Sluit verbinding met database
		$sql->close();
		$conn->close();
	}else{
		echo "<script>alert('hash klopt niet met password!');</script>";
	}
}
?>


<html lang="en">
<head>
	<meta charset="utf-8">
	<meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	<title>Register</title>
	<!--Externe stylesheets-->
	<link href="https://getbootstrap.com/docs/4.1/dist/css/bootstrap.min.css" rel="stylesheet">
	<link href="https://getbootstrap.com/docs/4.1/examples/sign-in/signin.css" rel="stylesheet">
</head>

<body class="text-center">
<form action="register.php" method="post" class="form-signin" enctype="multipart/form-data">
	<input type="text" id="inputUsername" name="username" class="form-control" placeholder="Username" required autofocus>
	<input type="password" id="inputPassword" name="password" class="form-control" placeholder="Password" required>
	<input type="file" id="inputProfielfoto" name="profielfoto" accept="image/*">
	<input  type="submit" class="btn btn-lg btn-primary btn-block" value="Register">
</form>
</body>
<script>
	var path = window.location.protocol;
	if(path !== 'https:'){
		location.replace(`https:${location.href.substring(location.protocol.length)}`);
	}
</script>
</html>