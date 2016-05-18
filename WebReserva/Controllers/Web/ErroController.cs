using System;
using System.Web.Mvc;

namespace WebReserva.Controllers.Web
{
    public class ErroController : Controller
    {
        // GET: Erro
        public ActionResult Status(int status, Exception error)
        {
            Response.StatusCode = status;

            return View(status);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}