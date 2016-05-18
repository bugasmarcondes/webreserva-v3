(function () {
    'use strict';

    angular.module('webReservaApp').controller('wrSectionContactController', wrSectionContactController);

    //TODO consertar HTML do btn submit

    function wrSectionContactController($scope, $http, tenantData) {
        $scope.smForm = {};

        $scope.sendMessage = function () {
            var url = '/' + tenantData.url + '/api/v1/contact';
            $scope.smForm.wrHotelId = tenantData.id;
            $http.post(url, $scope.smForm)
                .then(function (result) {
                    var mailing = result.data;

                    toastr.success('E-mail enviado com sucesso');

                    $scope.smForm = {};
                },
                function (result) {
                    if (result.status == 500) {
                        toastr.error(result.data.message);
                    }
                    else if (result.status == 400) {
                        toastr.error('Erro! ' + result.data.exceptionMessage);
                    }
                    else {
                        toastr.error('Erro desconhecido ao enviar e-mail');
                    }
                });
        }
    }
})();