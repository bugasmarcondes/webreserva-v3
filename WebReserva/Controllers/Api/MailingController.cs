using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebReserva.EntityFramework;
using WebReserva.Models;

namespace WebReserva.Controllers.Api
{
    public class MailingController : ApiController
    {
        private IWebReservaRepository _repository;

        public MailingController(IWebReservaRepository repository)
        {
            _repository = repository;
        }
        
        public HttpResponseMessage Post([FromBody]WrMailing newEmail)
        {
            try
            {
                if (_repository.AddEmail(newEmail) && _repository.Save())
                {
                    return Request.CreateResponse(HttpStatusCode.Created, newEmail);
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
