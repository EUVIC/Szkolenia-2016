(function () {
    angular.module('app.controllers').controller('CharactersController', CharactersController);

    function CharactersController(sweet, DTOptionsBuilder, charactersService, states) {
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
            sweet.show({
                title: 'Confirm',
                text: 'Delete this record?',
                type: 'warning',
                showCancelButton: true,
            }, function () {
                charactersService.deleteCharacter(id).then(function () {
                    getCharacters();
                })
            });

        }
        
        // activate function
        function activate() {
            getCharacters();
        }

        activate();
    }
})();