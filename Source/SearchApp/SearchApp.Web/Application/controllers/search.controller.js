/// <reference path="E:\Search\Source\SeachApp\SearchApp.Web\Scripts/angular.js" />
SearchEngine.searchController = function ($scope, searchService) {
    $scope.searchCriteria = "";
    $scope.focusControl = true;

    $scope.$watch("searchCriteria", function (criteria) {
        if (criteria && criteria.length > 3) {
            $scope.searchGroups = searchService.query({ criteria: criteria });
        } else {
            $scope.searchGroups = [];
        }
    });

    $scope.changeIndex = function ($event) {
        if (!$scope.focusControl) {
            $scope.focusControl = true;
            $scope.searchCriteria += $event.char;
        }
    };
};