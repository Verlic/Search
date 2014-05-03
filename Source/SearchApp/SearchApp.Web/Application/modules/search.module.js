/// <reference path="~/Application/app.js" />
/// <reference path="~/Scripts/angular.js" />
/// <reference path="~/Scripts/angular-mocks.js" />
/// <reference path="../services/search.service.js" />
/// <reference path="../controllers/search.controller.js" />

SearchEngine.app = angular.module("search", ["ngResource"]);

// Register Services
SearchEngine.app.factory("searchService", ["$resource", SearchEngine.searchService]);

// Register Controllers
SearchEngine.app.controller("searchController", ["$scope", "searchService", SearchEngine.searchController]);