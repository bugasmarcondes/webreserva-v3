using System;

namespace WebReserva.Models
{
    public class WrPesquisa
    {
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public DateTime? DataPesquisa { get; set; }
        public int WrHotelId { get; set; }
    }
}