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

var platform = new H.service.Platform({
  'app_id': 'jTxAxWdgGProrFVfcpt8',
  'app_code': '_QGvHdLBY-_It0AEd3f9kA'
});

// var defaultLayers = platform.createDefaultLayers();

// // Instantiate (and display) a map object:
// var map = new H.Map(
//   document.getElementById('map'),
//   defaultLayers.normal.map,
//   {
//     zoom: 4,
//     center: { lat: 38.8781, lng: -97.6298 }
//   });
  
//   var mapEvents = new H.mapevents.MapEvents(map);
//   map.addEventListener('tap', function(evt) {
//     // Log 'tap' and 'mouse' events:
//     console.log(evt.type, evt.currentPointer.type); 
//   });
  
  // Instantiate the default behavior, providing the mapEvents object: 
  // var behavior = new H.mapevents.Behavior(mapEvents);
  // map.setBaseLayer(defaultLayers.satellite.traffic)

  // var geocodingParams = {
  //   searchText: "Coding Dojo Tulsa, South Detroit Avenue, Tulsa, OK, USA"
  // };

// Define a callback function to process the geocoding response:
// var onResult = function(result) {
//   var locations = result.Response.View[0].Result,
//     position,
//     marker;
//   // Add a marker for each location found
//   for (i = 0;  i < locations.length; i++) {
//   position = {
//     lat: locations[i].Location.DisplayPosition.Latitude,
//     lng: locations[i].Location.DisplayPosition.Longitude
//   };
//   marker = new H.map.Marker(position);
//   map.addObject(marker);
//   }
// };

// Get an instance of the geocoding service:
// var geocoder = platform.getGeocodingService();

// // Call the geocode method with the geocoding parameters,
// // the callback and an error callback function (called if a
// // communication error occurs):
// geocoder.geocode(geocodingParams, onResult, function(e) {
//   alert(e);
// });



