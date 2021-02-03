$('[data-fancybox="images"]').fancybox({
	buttons: [ 
	  'slideShow',
	  'share',
	  'zoom',
	  'fullScreen',
	  'close'
	],
	thumbs: {
	  autoStart: true
	},
  });


$.fancybox.defaults.animationEffect = "fade";
$.fancybox.defaults.transitionEffect = "tube";

var instance = $.fancybox.getInstance();
$('[data-fancybox="gallery"]').fancybox({
	afterShow : function( instance, current ) {
		console.info( instance );
	}
});