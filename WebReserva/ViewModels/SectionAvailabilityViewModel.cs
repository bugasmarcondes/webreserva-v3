using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReserva.ViewModels
{
    public class SectionAvailabilityViewModel
    {
        //TODO criar classe
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int QuantidadeAdultos { get; set; }
        public int QuantidadeCriancas { get; set; }
    }
}