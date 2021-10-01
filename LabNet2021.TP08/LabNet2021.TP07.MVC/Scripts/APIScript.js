function getRandomQuote(block, nb) {
    var url = 'https://breaking-bad-quotes.herokuapp.com/v1/quotes/' + nb;


    fetch(url).then(response => {
        return response.json();
    }).then(data => {

        document.getElementById("quote").innerHTML = data[0].quote + '<cite>' + data[0].author + '</cite>';

    }).catch(err => {
        console.log(err);
    });
}