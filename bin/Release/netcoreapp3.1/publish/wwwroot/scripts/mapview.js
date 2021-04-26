function initMap(vehiculos) {
    var latlngRepDom = new google.maps.LatLng(18.735693, -70.162651);

    var options = {
        zoom: 8,
        center: latlngRepDom,
        mapTypeId: google.maps.MapTypeId.ROADMAP
    };
    var map = new google.maps.Map(document.getElementById("map"), options);

    vehiculos.forEach((veh) => {
        var marker = new google.maps.Marker({
            position: new google.maps.LatLng(veh.latitude, veh.longitude),
            map: map,
            label: veh.marca + " " + veh.modelo
        });

    })


}

function initAdd() {
    let map;
    const myLatlng = { lat: 18.735693, lng: -70.162651 };
    map = new google.maps.Map(document.getElementById("map"), {
        center: myLatlng,
        zoom: 8,
    });

    let infoWindow = new google.maps.InfoWindow({
        content: "Click al mapa para obtener latitud y longitud",
        position: myLatlng,
    });
    infoWindow.open(map);
    // Configure the click listener.
    map.addListener("click", (mapsMouseEvent) => {
        // Close the current InfoWindow.
        infoWindow.close();
        // Create a new InfoWindow.
        infoWindow = new google.maps.InfoWindow({
            position: mapsMouseEvent.latLng,
        });
        infoWindow.setContent(
            JSON.stringify(mapsMouseEvent.latLng.toJSON(), null, 2)
        );
        infoWindow.open(map);
    });

}