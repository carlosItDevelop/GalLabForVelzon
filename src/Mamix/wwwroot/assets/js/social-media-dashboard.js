 /* Visitors By Country Map */
 var markers = [
    {
        name: "Usa",
        coords: [40.3, -101.38],
    },
    {
        name: "India",
        coords: [20.5937, 78.9629],
    },
    {
        name: "Vatican City",
        coords: [41.9, 12.45],
    },
    {
        name: "Canada",
        coords: [56.1304, -106.3468],
    },
    {
        name: "Mauritius",
        coords: [-20.2, 57.5],
    },
    {
        name: "Singapore",
        coords: [1.3, 103.8],
    },
    {
        name: "Palau",
        coords: [7.35, 134.46],
    },
    {
        name: "Maldives",
        coords: [3.2, 73.22],
    },
    {
        name: "São Tomé and Príncipe",
        coords: [0.33, 6.73],
    },
];
var map = new jsVectorMap({
    map: "world_merc",
    selector: "#visitors-countries",
    markersSelectable: true,
    zoomOnScroll: false,
    zoomButtons: false,

    onMarkerSelected(index, isSelected, selectedMarkers) {
        console.log(index, isSelected, selectedMarkers);
    },

    // -------- Labels --------
    labels: {
        markers: {
            render: function (marker) {
                return marker.name;
            },
        },
    },

    // -------- Marker and label style --------
    markers: markers,
    markerStyle: {
        hover: {
            stroke: "#DDD",
            strokeWidth: 3,
            fill: "#FFF",
        },
        selected: {
            fill: "#ff525d",
        },
    },
    regionStyle: {
        initial: {
            stroke: "var(--primary01)",
            strokeWidth: 1.5,
        }
    },
    markerLabelStyle: {
        initial: {
            fontFamily: "Poppins",
            fontSize: 13,
            fontWeight: 500,
            fill: "#35373e",
        },
    },
});
/* Visitors By Country Map */