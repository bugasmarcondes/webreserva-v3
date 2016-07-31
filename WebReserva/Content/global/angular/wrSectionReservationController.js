(function () {
    'use strict';

    angular.module('webReservaApp').controller('wrSectionReservationController', wrSectionReservationController);

    function wrSectionReservationController($scope, $http, tenantData) {
        $scope.srFormSearch = {};
        $scope.srForm = {};

        $scope.saveReservationSearch = function () {
            $('#btn-salvar-pesquisa').hide();

            var url = '/' + tenantData.url + '/api/v1/reservation/saveReservationSearch';
            $scope.srFormSearch.wrHotelId = tenantData.id;
            $scope.srFormSearch.checkin = $('#srCheckin').val();
            $scope.srFormSearch.checkout = $('#srCheckout').val();
            $scope.srFormSearch.wrTipoApartamentoId = $('#srApartamentoId').val();

            $http
            .post(url, $scope.srFormSearch)
            .then(function (result) {
                $('#srReservaId').val(result.data);
                $('#srNome').val($scope.srFormSearch.srNome.$$rawModelValue);
                $('#srEmail').val($scope.srFormSearch.srEmail.$$rawModelValue);

                $('#srFormSearch').addClass('hide');
                $('#srForm').removeClass('hide');
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

            $('#srNome').val($scope.srFormSearch.srNome.$$rawModelValue);
            $('#srEmail').val($scope.srFormSearch.srEmail.$$rawModelValue);

            $('#srNome').trigger('change');
            $('#srEmail').trigger('change');

            $('#srFormSearch').addClass('hide');
            $('#srForm').removeClass('hide');
        }

        $scope.updateReservation = function () {
            $('#btn-reservar').hide();

            var url = '/' + tenantData.url + '/api/v1/reservation/updateReservation';
            $scope.srForm.wrReservaId = $('#srReservaId').val();
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