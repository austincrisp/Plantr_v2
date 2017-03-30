var church = { lat: 34.780055, lng: -82.374663 };
var position1 = { lat: 34.720075, lng: -82.511174 }

function initmap() {
    var map = new google.maps.Map(document.getElementById('map'), {
        center: church,
        zoom: 13,
        mapTypeId: 'hybrid',
        scrollwheel: true,
        disableDefaultUI: true
    });
    var pinColor = '1abbac';
    var pinIcon = new google.maps.MarkerImage("http://chart.apis.google.com/chart?chst=d_map_pin_letter&chld=%E2%80%A2|" + pinColor,
        new google.maps.Size(21, 34),
        new google.maps.Point(0, 0),
        new google.maps.Point(10, 34));

    //Drop Marker 1
    marker1 = new google.maps.Marker({
        map: map,
        draggable: false,
        animation: google.maps.Animation.DROP,
        position: position1,
        icon: pinIcon,
    });

    /*function (results, status) {
        if (status == google.maps.GeocoderStatus.OK) {
            marker2 = new google.maps.Marker({
                map: map,
                position: results[0].geometry.location,
                animation: google.maps.Animation.DROP,
                draggable: false,
                icon: pinIcon,
            });
        }
        var latString = results[0].geometry.location.lat().toString();
        var lngString = results[0].geometry.location.lng().toString();
        var lat = Number(latString)
        var lng = Number(lngString)
        pos2 = { lat: lat, lng: lng };
    });
    */
}