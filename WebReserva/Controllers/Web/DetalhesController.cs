using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebReserva.EntityFramework;

namespace WebReserva.Controllers.Web
{
    public class DetalhesController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public DetalhesController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Acomodacao(int id)
        {
            return View(Tenant);
        }

        public ActionResult Pacote(int id)
        {
            return View(Tenant);
        }
    }
}