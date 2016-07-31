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

        [HttpPost]
        public HttpResponseMessage SaveReservationSearch([FromBody]PostReservationSearchViewModel reservationSearch)
        {
            try
            {
                var reservaId = _repository.SaveReservationSearch(reservationSearch);

                if (reservaId > 0)
                {
                    return Request.CreateResponse(HttpStatusCode.OK, reservaId);
                }

                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, "Oops! Algo deu errado.\nEstamos consertando! Por favor volte em instantes.");
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ex);
            }
        }

        [HttpPost]
        public HttpResponseMessage UpdateReservation([FromBody]PostReservationViewModel existingReservation)
        {
            try
            {
                if (_repository.UpdateReservation(existingReservation) > 0)
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
