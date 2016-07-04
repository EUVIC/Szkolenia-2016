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
        
        // private members
        function getCharacters() {
            charactersService.getCharacters().then(function (result) {
                vm.characters = result.data;
            });
        }
        
        // activate function
        function activate() {
            getCharacters();
        }

        activate();
    }
})();