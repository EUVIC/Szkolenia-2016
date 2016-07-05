(function () {
    angular.module('app.services').factory('culturesService', culturesService);

    culturesService.$inject = ['$http', 'apiConfig'];

    function culturesService($http, apiConfig) {

        var apiURI = apiConfig.baseApiUrl;

        var culturesService = {
            getCultures: getCultures,
        };

        return culturesService;

        function getCultures() {
            return $http.get(apiURI + '/cultures');
        }
    };

    return culturesService;

})();