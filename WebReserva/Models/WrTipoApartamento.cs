using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebReserva.Models
{
    public class WrTipoApartamento
    {
        public int Id { get; set; }

        [StringLength(100)]
        public string Nome { get; set; }

        [StringLength(300)]
        public string Descricao { get; set; }

        [StringLength(1000)]
        public string Img01 { get; set; }

        [StringLength(1000)]
        public string Img02 { get; set; }

        [StringLength(1000)]
        public string Img03 { get; set; }

        [StringLength(100)]
        public string DestaqueTitulo { get; set; }

        [Column(TypeName = "text")]
        public string DestaqueDescricao { get; set; }

        [StringLength(100)]
        public string OpcionalTitulo01 { get; set; }

        [Column(TypeName = "text")]
        public string OpcionalDescricao01 { get; set; }

        [StringLength(100)]
        public string OpcionalTitulo02 { get; set; }

        [Column(TypeName = "text")]
        public string OpcionalDescricao02 { get; set; }

        [StringLength(100)]
        public string OpcionalTitulo03 { get; set; }

        [Column(TypeName = "text")]
        public string OpcionalDescricao03 { get; set; }

        public int IdLetoh { get; set; }

        public int WrHotelId { get; set; }

        public ICollection<WrReserva> WrReserva { get; set; }

        public ICollection<WrDisponibilidade> WrDisponibilidade { get; set; }
    }
}
