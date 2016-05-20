using System;
using WebReserva.Models;

namespace WebReserva.ViewModels
{
    public class SectionAvailabilityViewModel
    {
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Adultos { get; set; }
        public int Criancas { get; set; }
        public double TotalDias {
            get
            {
                return (CheckOut - CheckIn).TotalDays;
            }
        }
        public int WrHotelId { get; set; }
    }
}