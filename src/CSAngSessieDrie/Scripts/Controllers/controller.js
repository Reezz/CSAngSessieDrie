(function () {
    'use strict';

    angular
        .module('championsApp')
        .controller('championsController', championsController);

    championsController.$inject = ['$scope', 'Champions'];

    function championsController($scope, Champions) {
        $scope.Champions = Champions.query();
    }
})();
