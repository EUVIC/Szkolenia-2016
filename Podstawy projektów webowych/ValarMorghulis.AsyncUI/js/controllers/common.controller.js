(function() {
	angular.module('app.controllers').controller('CommonController', CommonController);

	function CommonController($timeout, $state, $rootScope, $http, states) {
		var vm = this;

		vm.stateNames = states;
		vm.isDangerAlertVisible = false;
		vm.isSuccessAlertVisible = false;

		$rootScope.$on('showErrorAlert', function (event, data) {
			if (data) {
				vm.errorMessage = data;
			} else {
				vm.errorMessage = "Błąd przy wysyłaniu zapytania do serwera";
			}
			vm.isDangerAlertVisible = true;
			$timeout(function () { vm.isDangerAlertVisible = false; }, 2500);
		});

		$rootScope.$on('showSuccessAlert', function (event, data) {
			if (data) {
				vm.errorMessage = data;
			} else {
				vm.errorMessage = "Sukces.";
			} $timeout(function () { vm.isSuccessAlertVisible = false; }, 2500);
		});

		$rootScope.$on('setLoaderVisibility', function (event, data) {
			vm.isLoading = data;
		});

		vm.isLoaderVisible = function () {
			// display loader whether there are pending requests or it was manually displayed
			return $http.pendingRequests.length > 0 || vm.isLoading;
		}

		vm.isMenuElementActive = function (state) {
			return $state.current.name === state;
		}

		vm.logOutButtonClick = function () {
			authService.logout();
		}
	}

})();