(function () {
	angular.module('app.widgets').directive('loader', loader);

	function loader() {
		return {
			restrict: 'A',
			template: '<div class="loader-overlay"><div class="loader-content"></div></div>',
			link: function (scope, elm, attrs) {
				elm.parent().css('position', 'relative');
			}
		};
	}
})();