using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebReserva.EntityFramework;

namespace WebReserva.Controllers.Web
{
    public class ContatoController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public ContatoController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(Tenant);
        }

        public ActionResult SectionContact()
        {
            return PartialView(Tenant);
        }
    }
}