using System;
using System.Web.Mvc;
using WebReserva.EntityFramework;
using WebReserva.ViewModels;

namespace WebReserva.Controllers.Web
{
    public class ReservaController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public ReservaController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult Acomodacao(PostDetalhesViewMovel vm)
        {
            if (vm != null)
            {
                var apartamento = _repository.GetWrTipoApartamento(vm.RoomId);
                var checkin = Convert.ToDateTime(vm.CheckIn, System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat);
                var checkout = Convert.ToDateTime(vm.CheckOut, System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat);

                vm.TotalDias = (checkout - checkin).TotalDays;
                vm.TotalPessoas = Convert.ToInt32(vm.Adultos) + Convert.ToInt32(vm.Criancas);
                vm.RoomName = apartamento.Nome;
            }

            var page = new PageReservaViewModel()
            {
                WrHotel = Tenant,
                PostDetalhes = vm
            };

            return View(page);
        }
    }
}