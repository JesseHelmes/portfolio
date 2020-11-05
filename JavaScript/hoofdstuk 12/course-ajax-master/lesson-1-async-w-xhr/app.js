(function () {
	const form = document.querySelector('#search-form');
	const searchField = document.querySelector('#search-keyword');
	let searchedForText;
	const responseContainer = document.querySelector('#response-container');

	form.addEventListener('submit', function (e) {
		e.preventDefault();
		responseContainer.innerHTML = '';
		searchedForText = searchField.value;

		const asyncRequestObject = new XMLHttpRequest();
		asyncRequestObject.open('GET', 'https://api.unsplash.com/search/photos?query='+searchedForText);
		asyncRequestObject.setRequestHeader('Authorization', 'Client-ID 6GS0H6pHse0-jMEcMTN_MvoxsaMwM45Xo4NTJGkxIWo');
		asyncRequestObject.onload = handleSuccess;
		asyncRequestObject.onerror = handleError;
		asyncRequestObject.send();
	});

	

	function handleSuccess(){
		const data = JSON.parse(this.responseText)
		console.log(data.results[0]);
		for(var i = 0; i < 10; i++){
			responseContainer.innerHTML += "<img src='" + data.results[i].urls.regular +"'>"
		}
	}

	function handleError(){
		console.log('An error occured!');
	}
})();
