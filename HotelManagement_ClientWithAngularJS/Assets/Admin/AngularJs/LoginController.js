app.controller("LoginController", ['$scope','$http', function ($scope,$http) {
    $scope.DangNhap = function () {
        console.log("Ban da toi day");
        console.log($scope.username);
        $http.get('http://localhost:61740/api/users').success(function (response) {
            console.log(response);
        }).error(function (response) {
            console.log(response);
        });
    };
}]);