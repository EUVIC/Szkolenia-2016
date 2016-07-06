(function () {
    angular.module('app.controllers').controller('CharactersController', CharactersController);

    function CharactersController(DTOptionsBuilder, charactersService, states) {
        var vm = this;
        
        // public members
        vm.characters = [];
        vm.dtOptions = DTOptionsBuilder.newOptions()
            .withOption('columns', [
                { width: "75%" },
                { width: "25%" }
            ]);
        vm.deleteCharacter = deleteCharacter;

        // private members
        function getCharacters() {
            charactersService.getCharacters().then(function (result) {
                vm.characters = result.data;
            });
        }

        function deleteCharacter(id) {
            charactersService.deleteCharacter(id).then(function () {
                getCharacters();
            })
        }
        
        // activate function
        function activate() {
            getCharacters();
        }

        activate();
    }
})();