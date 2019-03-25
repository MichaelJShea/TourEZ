// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

var map;
function initMap() {
  map = new google.maps.Map(document.getElementById('map'), {
    center: {lat: 38.8781, lng: -97.6298},
    zoom: 4.3
  });
}


function AutoCompleteLocation () {
  var input = document.getElementById("location");
  var autocomplete = new google.maps.places.Autocomplete(input)
  console.log(autocomplete);
}


