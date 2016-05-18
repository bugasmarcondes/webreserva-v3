using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebReserva.EntityFramework;

namespace WebReserva.Controllers.Web
{
    public class DisponibilidadeController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public DisponibilidadeController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(Tenant);
        }

        public ActionResult SectionRoom()
        {
            var acomodacoes = _repository.GetSectionRoom(Tenant.Id);

            return PartialView(acomodacoes);
        }
    }
}