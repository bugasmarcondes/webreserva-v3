using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebReserva.EntityFramework;
using WebReserva.ViewModels;

namespace WebReserva.Controllers.Api
{
    public class ContactController : ApiController
    {
        private IWebReservaRepository _repository;

        public ContactController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public HttpResponseMessage Post([FromBody]SectionContactViewModel newEmail)
        {
            try
            {
                if (_repository.SendEmail(newEmail))
                {
                    return Request.CreateResponse(HttpStatusCode.OK);
                }

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Oops! Algo deu errado.\nEstamos consertando! Por favor volte em instantes.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }
    }
}
