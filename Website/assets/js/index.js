var Index = function () {

	return {
		//Revolution Slider
		initRevolutionSlider: function () {
			var revapi;
			jQuery(document).ready(function () {
				revapi = jQuery('.tp-banner').revolution(
	            {
	            	delay: 9000,
	            	startwidth: 1170,
	            	startheight: 500,
	            	hideThumbs: 10
	            });
			});
		}
	};
}();