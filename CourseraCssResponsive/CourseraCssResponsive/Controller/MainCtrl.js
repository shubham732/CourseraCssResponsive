﻿myapp.controller("myctrl", function ($scope, AppService) {
    $scope.hasactiveclass = true;
    $scope.ApplyClass = function () {

        $scope.hasactiveclass = !$scope.hasactiveclass;
    }
    getData();
    function getData() {
        //AppService.ShowLoader();
        $.ajax
           ({
               type: "POST",
               async: true,
               url: "Views/Partials/webService.asmx/HelloWorld",
               contentType: "application/json; charset=utf-8",
               dataType: "json",

               success: function (a) {
                   var data = JSON.parse(JSON.stringify(a.d));
                   $scope.$apply(function(){
                   $scope.content = data;
               });
                   



               },
               error: function (r) {
                   alert("Failed Configure Airplane");

               }
           });
        
        

    }
});

