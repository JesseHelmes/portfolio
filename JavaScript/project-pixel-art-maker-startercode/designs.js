// Select color input
// Select size input
let height, width, color, max = 100;//100

const pixelCanvas = document.getElementById('pixelCanvas');
const colorPicker = document.getElementById('colorPicker');
//http://jsfiddle.net/Brv6J/3/

// When size is submitted by the user, call makeGrid()
document.getElementById('sizePicker').onsubmit = function(e){
	e.preventDefault();
	height = document.getElementById('inputHeight').value;
	width = document.getElementById('inputWeight').value;

	makeGrid();
};

//change color
pixelCanvas.onclick = function(e){
	paintColor(e);
}

pixelCanvas.oncontextmenu = function(e){
	e.preventDefault();
	pipet(e);
}

//toont hex code van picker
colorPicker.onchange = function(){
	getHexCode();
}

function makeGrid(){
//reset canvas
canvas = '';
//max zodat de pagina niet freeze
height = height <= max ? height : max;
width = width <= max ? width : max;

	for(var i = 0; i < height; i++){
		canvas += '<tr>';

		for(var x = 0; x < width; x++){
			canvas += '<td></td>';
		}
		canvas += '</tr>';
	}
	pixelCanvas.innerHTML = canvas;

	//zorgt er voor dat lengte aanpassed aan breedte van vakjes
	var newLength = document.getElementsByTagName('td')[0].offsetWidth;
	var defaultWidth = 50;
	if(newLength < defaultWidth){
		var tdCount = document.getElementsByTagName('tr').length;
		for(var i = 0; i < tdCount; i++)
		{
			document.getElementsByTagName('tr')[i].style.height = newLength + "px";
		}
	}
}

//change color
// https://stackoverflow.com/questions/5833088/how-do-i-change-a-specific-tds-background-color-on-click-with-javascript-jquery
function paintColor(e){
	if(e.target.tagName == 'TD'){
		var currentColor = e.target.style.background;
		color = colorPicker.value;
		if(color == rgbToHex(currentColor)){
			color = 'transparent';
		}
		e.target.style.background = color;
	}
}
//#00ff40
//get color
function pipet(e){
	if(e.target.tagName == 'TD'){
		var currentColor = e.target.style.background;
		colorPicker.value = rgbToHex(currentColor);
		getHexCode();
	}
}

//zet de hex code onder colorpicker
function getHexCode(){
	color = colorPicker.value;
	document.getElementById('colorCode').innerHTML = color;
}

//convert rgb terug naar hex
function rgbToHex(col)
{
	if(col.charAt(0)=='r')
	{
		col = col.replace('rgb(','').replace(')','').split(',');
		var r = parseInt(col[0], 10).toString(16), g = parseInt(col[1], 10).toString(16), b = parseInt(col[2], 10).toString(16);
		r = r.length==1?'0'+r:r; g=g.length==1?'0'+g:g; b=b.length==1?'0'+b:b;
		var colHex='#'+r+g+b;
		return colHex;
	}
}

//DARK MODE SECTION
url = window.location.href;

//auto naar dark mode
time = (new Date()).getHours();
if(time >= 18 || url.search("jesse")){
	darkMode();
}
/*
document.getElementsByClassName('toggle-dark-mode').onclick = function(e){
	//e.preventDefault();
	darkMode();
};*/

//dark mode fijner voor je ogen
function darkMode(){
	document.body.classList.toggle("dark-mode");
}