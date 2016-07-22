(function () {
    angular.module('app.controllers').controller('CharacterEditController', CharacterEditController);

    function CharacterEditController($state, sweet, character, charactersService, states) {
        var vm = this;
        
        // public members
        vm.updatedCharacter = {};

        vm.saveChanges = saveChanges;
        
        // private members
        
        function saveChanges() {
            charactersService.updateCharacter(vm.updatedCharacter).then(function () {
                $state.go(states.CHARACTERS);
            }, function(response) {
                sweet.show('Oops...', response.data.message, 'error');
            });
        }
        
        // activate function
        function activate() {
            vm.updatedCharacter = character.data;
        }

        activate();
    }
})();