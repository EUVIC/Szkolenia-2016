(function () {
	angular.module('app')
		.constant('states', {
            HOME: 'home',
			COMMON: 'common',
            CHARACTERS: 'characters',
            CHARACTER_DETAILS: 'character-details',
            CHARACTER_CREATE: 'character-create'
		})
		.constant('apiConfig', {
			baseApiUrl: 'http://localhost:52476/api'
		})
})();