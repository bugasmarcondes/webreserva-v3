using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebReserva.EntityFramework;
using WebReserva.ViewModels;

namespace WebReserva.Controllers.Api
{
    public class ReservationController : ApiController
    {
        private IWebReservaRepository _repository;

        public ReservationController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        public HttpResponseMessage Post([FromBody]PostReservationViewModel newReservation)
        {
            try
            {
                if (_repository.SaveReservation(newReservation) > 0)
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
