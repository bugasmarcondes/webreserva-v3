using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReserva.ViewModels
{
    public class PostDetalhesViewMovel
    {
        public int RoomId { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Adultos { get; set; }
        public string Criancas { get; set; }
        public decimal ValorDiariaTotal { get; set; }
    }
}