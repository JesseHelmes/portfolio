<?php

class JWT{

	function getNewToken($id, $username, $authlvl){
		$header = '{"typ":"JWT", "alg":"HS256"}';	//de header is een JSON met gegevens
		$header = base64_encode($header);	//de header moet worden omgezet naar base64 string om bruikbaar te kunnen zijn
		$header = str_replace("=", "", $header);	//de base64 string kon nog = tekens bevatten, die moeten er uit worden gehaald

		$payload = '{"id":'.$id.', "username":'.$username.', "authlvl":'.$authlvl.'}';
		//$payload = '{"id":1, "username":"admin", "authlvl":4}';	//de payload is een JSON met data vaak specifieke info over client bevat
		$payload = base64_encode($payload);		//de payload moet worden omgezet naar base64 string om bruikbaar te kunnen zijn
		$payload = str_replace("=", "", $payload);	//de base64 string kon nog = tekens bevatten, die moeten er uit worden gehaald

		$signature = hash_hmac("sha256", $header . "." . $payload, "qwerty1234");	//de signature wordt op een speciale manier gehashed, geef het algoritme mee, dan de header.payload en dan nog wachtwoord
		$signature = base64_encode($signature);		//de signature moet worden omgezet naar base64 string om bruikbaar te kunnen zijn
		$signature = str_replace("=", "", $signature);	//de base64 string kon nog = tekens bevatten, die moeten er uit worden gehaald

		$jwt = $header . "." . $payload . "." . $signature;		//de hele jwt is de header.payload.signature
		$token = "Bearer " . $jwt;	//en dit zetten we in de header uiteindelijk

		return $token;
	}

	function decodeToken($token){

		$token = str_replace("Bearer ", "", $token);

		$tokenParts = explode(".", $token);
		$header = base64_decode($tokenParts[0]);
		$payload = base64_decode($tokenParts[1]);
		$signature = base64_decode($tokenParts[2]);

		if($this->checkToken($header, $payload, $tokenParts[2])){
			//var_dump($payload);
			return json_decode($payload, true);

		}else{
			return false;
		}
	}

	function checkToken($header, $payload, $signature){

		$header = base64_encode($header);
		$header = str_replace("=", "", $header);

		$payload = base64_encode($payload);
		$payload = str_replace("=", "", $payload);

		$signatureCheck = hash_hmac("sha256", $header . "." . $payload, "qwerty1234");

		$signatureCheck = base64_encode($signatureCheck);
		$signatureCheck = str_replace("=", "", $signatureCheck);

		return $signature == $signatureCheck;
	}
}

?>