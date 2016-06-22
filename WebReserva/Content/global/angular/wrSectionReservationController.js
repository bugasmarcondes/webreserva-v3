﻿(function () {
    'use strict';

    angular.module('webReservaApp').controller('wrSectionReservationController', wrSectionReservationController);

    function wrSectionReservationController($scope, $http, tenantData) {
        $scope.srForm = {};

        $scope.saveReservation = function () {
            $('#btn-reservar').hide();

            var url = '/' + tenantData.url + '/api/v1/reservation';
            $scope.srForm.wrHotelId = tenantData.id;
            $scope.srForm.checkin = $('#srCheckin').val();
            $scope.srForm.checkout = $('#srCheckout').val();
            $scope.srForm.adultos = $('#srAdultos').val();
            $scope.srForm.criancas = $('#srCriancas').val();
            $scope.srForm.wrTipoApartamentoId = $('#srApartamentoId').val();
            $scope.srForm.valorTotal = $('#srValorTotal').val().replace(',', '.');
            $http.post(url, $scope.srForm)
                .then(function (result) {
                    var newReservation = result.data;

                    //TODO recuperar id da reserva
                    toastr.success('Reserva efetuada com sucesso');

                    $scope.srForm = {};

                    setTimeout(function () {
                        window.location = '/' + tenantData.url;
                    }, 3000);
                },
                function (result) {
                    $('#btn-reservar').show();

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