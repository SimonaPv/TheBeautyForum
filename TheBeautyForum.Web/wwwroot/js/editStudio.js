$(".chosen-select").chosen({
    no_results_text: "Nothing found!"
});

document.getElementsByClassName('chosen-choices')[0].style = "height:38px;"
let collection = Array.from(document.getElementsByClassName('search-field'))
collection.forEach(function (f) {
    f.style = "margin: 6px 0px 0px 4px;"
    f.style = "border: none;"
})

Array.from(document.getElementsByClassName('search-choice')).forEach(function (f) {
    f.style = "margin-top: 7px"
})

document.getElementsByClassName('chosen-container').style = "width: 544px;"

Array.from(document.getElementsByClassName('search-choice')).forEach(function (f) {
    f.style = "margin-top: 7px"
})

Array.from(document.getElementsByClassName('chosen-choices')).forEach(function (f) {
    f.style = "border: none; background: #f7f7f7; margin-top: 9px;"
})