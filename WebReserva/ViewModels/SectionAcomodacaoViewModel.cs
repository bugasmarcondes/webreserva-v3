using System;

namespace WebReserva.ViewModels
{
    public class SectionAcomodacaoViewModel
    {
        public int RoomId { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Img01 { get; set; }
        public string Img02 { get; set; }
        public string Img03 { get; set; }
        public string DestaqueTitulo { get; set; }
        public string DestaqueDescricao { get; set; }
        public string OpcionalTitulo01 { get; set; }
        public string OpcionalDescricao01 { get; set; }
        public string OpcionalTitulo02 { get; set; }
        public string OpcionalDescricao02 { get; set; }
        public string OpcionalTitulo03 { get; set; }
        public string OpcionalDescricao03 { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public string Adultos { get; set; }
        public string Criancas { get; set; }
        public decimal ValorDiariaTotal { get; set; }
    }
}