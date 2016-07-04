(function () {
    angular.module('app.controllers').controller('CharacterCreateController', CharacterCreateController);

    function CharacterCreateController($state, culturesService, charactersService, states) {
        var vm = this;
        
        // public members
        vm.newCharacter = {};
        vm.isFormSubmitted = false;

        vm.availableCultures = [];
        vm.submitForm = function (isFormValid) {
            vm.isFormSubmitted = true;
            if (isFormValid) {
                createCharacter(vm.newCharacter);
            }
        }
        
        // private members
        
        function createCharacter(char) {
            charactersService.createCharacter(char).then(function () {
                $state.go(states.CHARACTERS);
            })
        }

        function getAvailableCultures() {
            culturesService.getCultures().then(function (response) {
                vm.availableCultures = response.data;
            })
        }
        
        // activate function
        function activate() {
            getAvailableCultures();
        }

        activate();
    }
})();