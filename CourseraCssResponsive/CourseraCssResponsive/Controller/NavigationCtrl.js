myapp.controller("NavigationCtrl", function ($scope, $rootScope, AppService) {

   
    $scope.hasactiveclass = false;
    $scope.ApplyClass = function () {

        $scope.hasactiveclass = !$scope.hasactiveclass;
    }
    callLoader()
    function callLoader()
    {
        AppService.ShowLoader();
        $rootScope.showcontent = true;
        AppService.HideLoader();
        
    }
});