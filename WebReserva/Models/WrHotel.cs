using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebReserva.Models
{
    public class WrHotel
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        public string Descricao { get; set; }

        public string ImgLogo { get; set; }

        public string ImgSobre01 { get; set; }

        public string ImgSobre02 { get; set; }

        public string ImgSobre03 { get; set; }

        public string HostUrl { get; set; }

        public string Tema { get; set; }

        public int? MaxAdultos { get; set; }

        public int? MaxCriancas { get; set; }

        public string EmailAdministrador { get; set; }

        public string MsgCustomizadaEmail { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string Instagram { get; set; }

        public string Telefone { get; set; }

        public string LatitudeLongitude { get; set; }

        public ICollection<WrTipoApartamento> WrTipoApartamento { get; set; }
    }
}
