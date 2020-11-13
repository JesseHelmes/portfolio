$(document).ready(function(){

	//school
	//const baseApi = "http://10.9.6.104:8000/api/";

	//thuis frits box
	const baseApi = "http://192.168.178.86:8000/api/";

	//belangerijk html classen die aangepast worden
	const cpu = document.querySelector('.cpu');
	const omgeving = document.querySelector('.omgeving');
	const leds = document.querySelector('.leds');
	const temperatures = document.querySelector('.temperatures');

	const morseCode = document.querySelector('.morse-code');


	$(document).ready(function(){
		url = window.location.href;

		//auto naar dark mode
		time = (new Date()).getHours();
		if(time >= 18 || url.search("jesse")){//ik gebruik mijn naam omdat ik lui ben en van dark mode houd
			darkMode();
		}

		//leds knoppen
		getData('leds', setLeds);

		getData('temperature/cpu', setCPU);
		getData('temperature', setTemp);

		//list
		getData('temperatures', setTemps);

		//refresh elke 30 secs
		setInterval(function(){
			getData('temperature/cpu', setCPU);
			getData('temperature', setTemp);
			//getData('temperatures', setTemps); //is veel internet verkeer zonder max
		}, 30000);
   });

   //verkort ajax code herhalen
   function getData(api, func){
	   $.ajax({
			url: baseApi + api
		}).done(func);
   }

   function setTemps(data){

		var table = "<tr> <th>cpu temperature</th> <th>datum + tijd</th> <th>id</th> </tr>";
		var max = 30;//data.length

		for(var i = 0; i < 30; i++){
				table += "<tr>" +
					"<td>" + data[i].temperature + " °C</td>" +
					"<td>" + data[i].time + "</td>" +
					"<td>" + data[i].id + "</td>" +
				"</tr>";
		}

		temperatures.innerHTML = table;
	}

	function setLeds(data){
		console.log(data);

		var led = "";
		var ledStatus = "", id = 0;

		for(var i = 0; i < data.length; i++){
			ledStatus = (data[i].status == 0) ? 'off' : 'on';
			id = data[i].id;

			//background on / off color
			var color = (ledStatus == "off") ? "green" : "red";
			$(this).css("background", color);

			led += '<button id="led' + id + '" ledStatus="' + ledStatus + '" style="background:'+ color + '"> turn led ' + id + " " + ledStatus + '</button>';
		}
		//console.log(leds);
		leds.innerHTML = led;
	}

	//ledAction
	$(leds).on('click', 'button', function(){
		var id = parseInt($(this).attr("id").replace("led", ""));
		var ledStatus = $(this).attr("ledStatus");
		ledStatus = (ledStatus == 'off') ? 1 : 0;

		var json = {"id": id, "status": ledStatus };
		json = JSON.stringify(json);
		console.log(json);

		$.ajax({
			type: "POST",
			url: baseApi + 'leds',
			dataType: 'JSON',
			data: json,
			headers: {
				"Content-Type": "application/json"
			},
		}).done(function(){
			console.log("post led");
		});

		updateLed($(this));
	});

	function updateLed(led){
		var id = led.attr("id").replace("led", "");
		var ledStatus = (led.attr("ledStatus") == 'on') ? 'off' : 'on';

		//background on / off color
		var color = (ledStatus == "off") ? "green" : "red";
		$(led).css("background", color);

		led.attr("ledStatus", ledStatus);
		led.html("turn led " + id + " " + ledStatus);
	}

	function setCPU(data){
		//console.log(data);
		var celsius = data.celsius;
		var color = "";

		cpu.innerHTML = data.celsius;

		//kleur text met temperature
		if(celsius < 40)
			color = "blue";
		else if(celsius >= 40 && celsius < 60){
			color = "orange";
		}else{
			color = "red";
		}

		$(cpu).css("color", color);

	}

	function setTemp(data){
		//console.log(data);
		var celsius = data.celsius;
		var color = "";

		omgeving.innerHTML = celsius;

		//kleur text met temperature
		if(celsius < 20)
			color = "blue";
		else if(celsius >= 20 && celsius < 30){
			color = "orange";
		}else{
			color = "red";
		}

		$(omgeving).css("color", color);
	}

	$(".sendMorse").on("click", function(){
		morse();
	});

	function morse(){
		//verkomt dat je op knop kunt blijven drukken door het te verbergen
		$(leds).css( "visibility", "hidden" );

		message = $(morseCode).val();

		var json = {"message": message};
		json = JSON.stringify(json);
		console.log(json);

		$.ajax({
			type: "POST",
			url: baseApi + 'leds/morse',
			dataType: 'JSON',
			data: json,
			headers: {
				"Content-Type": "application/json"
			}
		}).done(function(){
			console.log("post morse code");

			//simple leds reset
			//getData('leds', setLeds);
		}).always(function(){
			$(leds).css( "visibility", "visible" );
		});
	}

	$('.toggle-dark-mode').on('click', function(){
		darkMode();
	});

	//DARK MODE fijner voor je ogen
	function darkMode(){
		document.body.classList.toggle("dark-mode");
	}
});
