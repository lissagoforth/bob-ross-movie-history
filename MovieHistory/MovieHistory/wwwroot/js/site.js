$("#movieSearch__button").click(evt => {
    const userSearchString = $("#movieSearch").val()
    $.ajax({
        method: "GET",
        url: `https://api.themoviedb.org/3/search/movie?api_key=17cff13a17c80fa95a77eb4a3a16ac68&language=en-US&query=${userSearchString}&page=1&include_adult=false`,
        success: (Response => console.log(Response))
    })
});