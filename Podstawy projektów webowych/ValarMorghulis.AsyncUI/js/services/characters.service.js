(function () {
    angular.module('app.services').factory('charactersService', charactersService);

    charactersService.$inject = ['$http', 'apiConfig'];

    function charactersService($http, apiConfig) {

        var apiURI = apiConfig.baseApiUrl;

        var charactersService = {
            getCharacters: getCharacters,
            getCharacterDetails: getCharacterDetails,
            createCharacter: createCharacter
        };

        return charactersService;

        function getCharacters() {
            return $http.get(apiURI + '/Characters/GetCharacters/');
        }

        function getCharacterDetails(id) {
            return $http.get(apiURI + '/Characters/GetCharacterDetails/' + id);
        }
        
        function createCharacter(vm) {
            return $http.post(apiURI + '/Characters/CreateCharacter', vm);
        }
    };

    return charactersService;

})();