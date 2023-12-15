//var map;


//function initialize() {
//    var latlng = new google.maps.LatLng(40.716948, -74.003563);
//    var options = {
//        zoom: 14, centet: latlng,
//        mapTypeId: google.maps.MapTypeId.ROADMAP
//    };

//    map = new google.maps.Map(document.getElementById("map"), options);
//}


export function load_map(/*raw*/) {
    /*console.log(JSON.parse(String(raw)));*/
    //let map = L.map('map').setView({ lon: 73.084488, lat: 33.738045 }, 16); //map: on div (page)
    //L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', { maxZoom: 19 }).addTo(map); //adds layer to map control

    //var geojson_layer = L.geoJSON().addTo(map);
    //var geojson_data = JSON.parse(String(raw));
    //for (var geojson_item of geojson_data) {
    //    geojson_layer.addData(geojson_item);
    //    var marker = new L.marker(
    //        [geojson_item.geometry.coordinates[1],
    //        geojson_item.geometry.coordinates[0]],
    //        {
    //            opacity: 0.01
    //        }
    //    );
    //    marker.bindTooltip(geojson_item.properties.name,
    //        {
    //            permanent: true;
    //            className: "my-label",
    //            offset: [0, 0]
    //        }
    //    );
    //    marker.addTo(map);
    //}

    let map = L.map('map').setView([33.738045, 73.084488], 13);

    // Add OpenStreetMap tiles as the base layer
    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', { maxZoom: 19 }).addTo(map);

    // Pet clinic data with their coordinates
        const petClinics = [
            { name: "Veteran Pets Care", coordinates: [33.642586, 72.952192] },
            { name: "Paws & Feathers Pet Clinic", coordinates: [33.651397, 72.953219] },
            { name: "Aliyan Pets Hospital", coordinates: [33.698398, 72.968182] },
            { name: "Royal Pets Hospital", coordinates: [33.708926, 73.046278] },
            { name: "Paws N Claws Pets Clinic", coordinates: [33.663761, 73.076413] },
            { name: "Capital Pets Hospital", coordinates: [33.648787, 73.040667] },
            { name: "Pets Empire Hospital", coordinates: [33.663825, 73.075930] },
        ];

    // Loop through the pet clinic data and add markers for each location
    petClinics.forEach(clinic => {
        const marker = L.marker(clinic.coordinates).addTo(map);
        marker.bindPopup(clinic.name); // Display clinic name as popup on marker click
    });

    return "";
}