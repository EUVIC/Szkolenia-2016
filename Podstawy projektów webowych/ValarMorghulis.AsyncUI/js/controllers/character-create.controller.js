(function () {
    angular.module('app.controllers').controller('CharacterCreateController', CharacterCreateController);

    function CharacterCreateController($state, culturesService, charactersService, states) {
        var vm = this;
        
        // public members
        vm.newCharacter = {};

        vm.saveChanges = saveChanges;
        
        // private members
        
        function saveChanges() {
            charactersService.createCharacter(vm.newCharacter).then(function () {
                $state.go(states.CHARACTERS);
            })
        }
    }
})();