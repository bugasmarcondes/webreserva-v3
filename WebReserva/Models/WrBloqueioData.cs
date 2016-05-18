using System;

namespace WebReserva.Models
{
    public class WrBloqueioData
    {
        public int Id { get; set; }

        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public string Titulo { get; set; }

        public string Descricao { get; set; }

        public string DescricaoSlider { get; set; }

        public string Mensagem { get; set; }

        public bool Pacote { get; set; }

        public int WrHotelId { get; set; }

        public string Img01 { get; set; }

        public decimal Valor { get; set; }
    }
}
