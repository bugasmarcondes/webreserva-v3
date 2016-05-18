(function () {
    'use strict';

    angular.module('webReservaApp').controller('wrMailingController', wrMailingController);

    function wrMailingController($scope, $http, tenantData) {
        $scope.mailing = {};

        $scope.addMail = function () {
            if ($scope.noForm.$invalid) {
                if ($scope.noForm.noEmail.$error.required) {
                    toastr.error('E-mail obrigatório', 'NOTÍCIAS & OFERTAS');
                }
                if ($scope.noForm.noEmail.$error.email) {
                    toastr.error('E-mail inválido', 'NOTÍCIAS & OFERTAS');
                }
            } 
            else if (tenantData.id == '') {
                toastr.error('Erro ao gravar e-mail. Por favor, comunique o administrador do sistema.', 'NOTÍCIAS & OFERTAS');
                console.log('[Erro | NOTÍCIAS & OFERTAS] tenantData não encontrado');
            }
            else {
                var url = '/' + tenantData.url + '/api/v1/mailing';
                $scope.mailing.wrHotelId = tenantData.id;
                $http.post(url, $scope.mailing)
                    .then(function (result) {
                        var mailing = result.data;

                        toastr.success('E-mail gravado com sucesso', 'NOTÍCIAS & OFERTAS');
                    },
                    function (result) {
                        if (result.status == 500) {
                            toastr.error(result.data.message, 'NOTÍCIAS & OFERTAS');
                        }
                        else if (result.status == 400) {
                            toastr.error('Erro! ' + result.data.exceptionMessage, 'NOTÍCIAS & OFERTAS');
                        }
                        else {
                            toastr.error('Erro desconhecido ao gravar e-mail.', 'NOTÍCIAS & OFERTAS');
                        }
                    });
            }
        };
    }
})();