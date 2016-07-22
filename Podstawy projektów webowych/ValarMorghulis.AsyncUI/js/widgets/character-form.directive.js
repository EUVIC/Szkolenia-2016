(function () {
    angular.module('app.widgets').directive('characterForm', characterForm);

    function characterForm() {
        var directive = {
            templateUrl: 'views/character-form.html',
            restrict: 'EA',
            controller: CharacterFormController,
            controllerAs: 'vm',
            bindToController: true,
            scope: {
                character: '=',
                onSaveChanges: '&',
            }
        }

        return directive;
    }

    CharacterFormController.$inject = ['$scope', 'culturesService', 'charactersService'];

    function CharacterFormController($scope, culturesService, charactersService) {
        var vm = this;

        vm.isFormSubmitted = false;
        vm.availableCultures = [];
        vm.saveChanges = saveChanges;

        function getAvailableCultures() {
            culturesService.getCultures().then(function (response) {
                vm.availableCultures = response.data;
            })
        }
        
        function saveChanges(isFormValid) {
            vm.isFormSubmitted = true;
            if (isFormValid) {
                vm.onSaveChanges();
            }
        }
        
        // activate function
        function activate() {
            getAvailableCultures();
        }

        activate();
    }

})();