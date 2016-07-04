(function () {
    angular.module('app.controllers').controller('CharacterDetailsController', CharacterDetailsController);

    function CharacterDetailsController(character, DTOptionsBuilder, charactersService, states) {
        var vm = this;
        
        // public members
        vm.characterDetails = {};
        
        // activate function
        function activate() {
            vm.characterDetails = character.data;
        }

        activate();
    }
})();