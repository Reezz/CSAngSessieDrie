(function () {
    'use strict';

    var championsService = angular.module('championsService', ['ngResource']);

    championsService.factory('Champions', ['$resource',
        function ($resource) {
            return $resource('api/champions', {}, {
                query: { method: 'GET', params: {}, isArray: true }
            });
        }
    ])
})();