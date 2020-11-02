(function () {
    const form = document.querySelector('#search-form');
    const searchField = document.querySelector('#search-keyword');
    let searchedForText;
    const responseContainer = document.querySelector('#response-container');

    form.addEventListener('submit', function (e) {
        e.preventDefault();
        responseContainer.innerHTML = '';
        searchedForText = searchField.value;

        fetch('https://api.unsplash.com/search/photos?page=1&query=' + searchedForText,{
            headers: {
                Authorization: 'Client-ID 6GS0H6pHse0-jMEcMTN_MvoxsaMwM45Xo4NTJGkxIWo'
            }
        })
        .then(response => response.json())
        .then(handleResponse)
        .catch(e => requestError(e, 'image'));
    });

    function handleResponse(data){
        console.log('the ajax request has finished!');
        console.log(data);
        for(var i = 0; i < 10; i++){
            responseContainer.innerHTML += "<img src='" + data.results[i].urls.regular +"'>"
        }
    }
})();
