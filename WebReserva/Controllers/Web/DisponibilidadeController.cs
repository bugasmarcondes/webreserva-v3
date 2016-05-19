using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebReserva.EntityFramework;
using WebReserva.ViewModels;

namespace WebReserva.Controllers.Web
{
    public class DisponibilidadeController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public DisponibilidadeController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index(string checkin, string checkout, string adultos, string criancas)
        {
            List<SectionRoomViewModel> sectionRoomList = null;

            var sectionAvailability = new SectionAvailabilityViewModel()
            {
                CheckIn = Convert.ToDateTime(checkin, System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat),
                CheckOut = Convert.ToDateTime(checkout, System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat),
                Adultos = Convert.ToInt32(adultos),
                Criancas = Convert.ToInt32(criancas),
                WrHotelId = Tenant.Id
            };

            if (sectionAvailability != null)
            {
                sectionRoomList = _repository.GetAvailability(sectionAvailability);
            }

            var page = new PageAvailabilityViewModel()
            {
                WrHotel = Tenant,
                SectionAvailability = sectionAvailability,
                SectionRoomList = sectionRoomList
            };

            return View(page);
        }

        /*
        public ActionResult SectionRoom()
        {
            var acomodacoes = _repository.GetSectionRoom(Tenant.Id);

            return PartialView(acomodacoes);
        }
        */
    }
}