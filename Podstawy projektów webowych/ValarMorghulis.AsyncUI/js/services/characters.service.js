(function () {
    angular.module('app.services').factory('charactersService', charactersService);

    charactersService.$inject = ['$http', 'apiConfig'];

    function charactersService($http, apiConfig) {

        var apiURI = apiConfig.baseApiUrl;

        var charactersService = {
            getCharacters: getCharacters,
            getCharacterDetails: getCharacterDetails,
            createCharacter: createCharacter,
            deleteCharacter: deleteCharacter,
            updateCharacter: updateCharacter
        };

        return charactersService;

        function getCharacters() {
            return $http.get(apiURI + '/characters');
        }

        function getCharacterDetails(id) {
            return $http.get(apiURI + '/characters/' + id);
        }

        function createCharacter(vm) {
            return $http.post(apiURI + '/characters', vm);
        }

        function updateCharacter(vm) {
            return $http.put(apiURI + '/characters/' + vm.id, vm);
        }

        function deleteCharacter(id) {
            return $http.delete(apiURI + '/characters/' + id);
        }
    };

    return charactersService;

})();