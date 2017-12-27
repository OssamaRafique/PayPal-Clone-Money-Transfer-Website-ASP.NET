(function($) {
	"use strict";
	
    $(function () {
		
		// Vector Map
		jQuery('#world-map-markers').vectorMap(
		{
			map: 'world_mill_en',
			backgroundColor: '#fff',
			borderColor: '#818181',
			borderOpacity: 0.25,
			borderWidth: 1,
			color: '#f4f3f0',
			regionStyle : {
				initial : {
				  fill : '#5867dd'
				}
			  },
			markerStyle: {
			  initial: {
							r: 9,
							'fill': '#f8c200',
							'fill-opacity':1,
							'stroke': '#fff',
							'stroke-width' : 3,
							'stroke-opacity': 0.8
						
						}
						},
			enableZoom: true,
			hoverColor: '#1E88E5',
			markers : [{
				latLng : [38.6118797, 26.2539233],
				name : 'Turkey'
			  
			  }],
			hoverOpacity: null,
			normalizeFunction: 'linear',
			scaleColors: ['#FF5722', '#FF5722'],
			selectedColor: '#FF5722',
			selectedRegions: [],
			showTooltip: true,
		});

        // Page View Chart
		var lineData = {
        labels: ["January", "February", "March", "April", "May", "June", "July"],
        datasets: [
            {
                label: "Example 1",
                fillColor: "rgba(78,162,236,0)",
                strokeColor: "#5867dd",
                pointColor: "#5867dd",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(78,162,236,1)",
                data: [120, 180, 120, 90, 120, 110, 170]
            },
			{
                label: "Example 2",
                fillColor: "rgba(232, 17, 35,0)",
                strokeColor: "#f4516c",
                pointColor: "#f4516c",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(232, 17, 35,1)",
                data: [100, 130, 170, 130, 150, 70, 190]
            },
            {
                label: "Example 3",
                fillColor: "rgba(74, 190, 105,0)",
                strokeColor: "#34bfa3",
                pointColor: "#34bfa3",
                pointStrokeColor: "#fff",
                pointHighlightFill: "#fff",
                pointHighlightStroke: "rgba(74, 190, 105,1)",
                data: [40, 170, 100, 40, 70, 150, 140]
            }
        ]
    };

    var lineOptions = {
        scaleShowGridLines: true,
        scaleGridLineColor: "rgba(0,0,0,.00)",
        scaleGridLineWidth: 2,
        bezierCurve: true,
        bezierCurveTension: 0.4,
        pointDot: true,
        pointDotRadius: 5,
		scaleFontFamily : "'Rubik'",
		scaleFontColor : "#455a64",
        pointDotStrokeWidth: 2,
        pointHitDetectionRadius: 20,
        datasetStroke: true,
        datasetStrokeWidth: 3,
        datasetFill: true,
        responsive: true
		
    };
	
	
    var ctx = document.getElementById("linechart").getContext("2d");
    var myNewChart = new Chart(ctx).Line(lineData, lineOptions);
    });



})(jQuery);