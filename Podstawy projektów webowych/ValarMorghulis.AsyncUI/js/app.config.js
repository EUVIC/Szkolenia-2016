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
            });
        $urlRouterProvider.otherwise('/');
    }

    function runBlock() {

    }
})();