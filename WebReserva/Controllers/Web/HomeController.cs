using System.Web.Mvc;
using WebReserva.EntityFramework;

namespace WebReserva.Controllers.Web
{
    public class HomeController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public HomeController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public ActionResult Index()
        {
            return View(Tenant);
        }

        public ActionResult SectionSlider()
        {
            var pacotes = _repository.GetSectionSlider(Tenant.Id);

            return PartialView(pacotes);
        }

        public ActionResult SectionAbout()
        {
            var sectionAbout = _repository.GetSectionAbout(Tenant.Id);

            return PartialView(sectionAbout);
        }

        public ActionResult SectionPackage()
        {
            var pacotes = _repository.GetSectionPackage(Tenant.Id);

            return PartialView(pacotes);
        }

        public ActionResult SectionAvailability()
        {
            return PartialView();
        }
    }
}