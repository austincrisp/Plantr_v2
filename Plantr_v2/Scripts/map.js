function initMap() {
    var church = { lat: 34.780055, lng: -82.374663 };
    var map = new google.maps.Map(document.getElementById('map'), {
        zoom: 13,
        center: church
    });
    var marker = new google.maps.Marker({
        position: church,
        map: map
    });
}