(function () {
    angular.module('app').config(configure).run(runBlock);

    function configure($stateProvider, $urlRouterProvider, $httpProvider, states) {
        $stateProvider
            .state(states.COMMON, {
                templateUrl: 'views/common.html',
                abstract: true,
                controller: 'CommonController',
                controllerAs: 'vm'
            })
            .state(states.HOME, {
                url: '/',
                templateUrl: 'views/home.html',
                controller: 'HomeController',
                controllerAs: 'vm',
                parent: 'common'
            })
            .state(states.CHARACTERS, {
                url: '/characters',
                templateUrl: 'views/characters.html',
                controller: 'CharactersController',
                controllerAs: 'vm',
                parent: 'common'
            })
            .state(states.CHARACTER_DETAILS, {
                url: '/characters/details/{characterId}',
                templateUrl: 'views/character-details.html',
                controller: 'CharacterDetailsController',
                controllerAs: 'vm',
                parent: 'common',
                resolve: {
                    character: function ($stateParams, charactersService) {
                        return charactersService.getCharacterDetails($stateParams.characterId);
                    }
                }
            })
            .state(states.CHARACTER_CREATE, {
                url: '/characters/create',
                templateUrl: 'views/character-create.html',
                controller: 'CharacterCreateController',
                controllerAs: 'vm',
                parent: 'common'
            })
            .state(states.CHARACTER_EDIT, {
                url: '/characters/edit/{characterId}',
                templateUrl: 'views/character-edit.html',
                controller: 'CharacterEditController',
                controllerAs: 'vm',
                parent: 'common',
                resolve: {
                    character: function ($stateParams, charactersService) {
                        return charactersService.getCharacterDetails($stateParams.characterId);
                    }
                }
            });
        $urlRouterProvider.otherwise('/');
    }

    function runBlock() {

    }
})();