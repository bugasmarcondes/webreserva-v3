(function () {
    'use strict';

    angular.module('webReservaApp').controller('wrSectionAvailabilityController', wrSectionAvailabilityController);

    function wrSectionAvailabilityController($scope, $http, tenantData) {
        $scope.scaForm = {};

        $scope.checkAvailability = function () {
            var scaArrErros = [];

            if ($scope.scaForm.$invalid) {
                if ($scope.scaForm.scaCheckIn.$error.required) {
                    scaArrErros.push('&bull; Check-in obrigatório');
                }
                if ($scope.scaForm.scaCheckOut.$error.required) {
                    scaArrErros.push('&bull; Check-out obrigatório');
                }
                if ($scope.scaForm.scaAdultos.$error.required) {
                    scaArrErros.push('&bull; Adultos obrigatório');
                }
                if (scaArrErros.length > 0) {
                    var scaTxtErros = '';

                    for (var i = 0; i < scaArrErros.length; i++) {
                        scaTxtErros += scaArrErros[i] + ((scaArrErros[i + 1] != '' && scaArrErros[i + 1] != undefined) ? '<br>' : '');
                    }

                    toastr.error(scaTxtErros, 'CHECAR DISPONIBILIDADE');
                }
            } 
            else if (tenantData.id == '') {
                toastr.error('Erro ao checar disponibilidade. Por favor, comunique o administrador do sistema.', 'CHECAR DISPONIBILIDADE');
                console.log('[Erro | CHECAR DISPONIBILIDADE] tenantData não encontrado');
            }
            else {
                //TODO passar parametros dinamicamente
                window.location.href = '/' + tenantData.url + '/disponibilidade';
            }
        }
    }
})();