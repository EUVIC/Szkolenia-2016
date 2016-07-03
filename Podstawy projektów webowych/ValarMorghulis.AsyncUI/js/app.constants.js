(function () {
	angular.module('app')
		.constant('states', {
            HOME: 'home',
			COMMON: 'common',
            CHARACTERS: 'characters'
		})
		.constant('apiConfig', {
			baseApiUrl: 'http://localhost:42001/',
			getApiUrlBase: function () {
				return this.baseApiUrl + 'api/';
			}
		})
})();