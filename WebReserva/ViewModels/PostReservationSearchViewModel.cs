namespace WebReserva.ViewModels
{
    public class PostReservationSearchViewModel
    {
        public int WrHotelId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public int Status { get; set; }
        public int WrTipoApartamentoId { get; set; }
    }
}