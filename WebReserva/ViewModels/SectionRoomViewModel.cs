using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReserva.ViewModels
{
    public class SectionRoomViewModel
    {
        public int RoomId { get; set; }
        public string Img01 { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string DestaqueTitulo { get; set; }
        public string OpcionalTitulo01 { get; set; }
        public string OpcionalTitulo02 { get; set; }
        public string OpcionalTitulo03 { get; set; }
        public double QuantidadeDiasPesquisados { get; set; }
        public int QuantidadeDiasRetornados { get; set; }
        public decimal ValorAdulto { get; set; }
        public decimal ValorCrianca { get; set; }
        public decimal ValorDiariaTotal {
            get
            {
                return ValorAdulto + ValorCrianca;
            }
        }
        public IEnumerable<DateTime> DatasDisponiveis { get; set; }

        public decimal DiariaAdulto01 { get; set; }
        public decimal DiariaAdulto02 { get; set; }
        public decimal DiariaAdulto03 { get; set; }
        public decimal DiariaAdulto04 { get; set; }
        public decimal DiariaAdulto05 { get; set; }
        public decimal DiariaAdulto06 { get; set; }
        public decimal DiariaAdulto07 { get; set; }
        public decimal DiariaAdulto08 { get; set; }
        public decimal DiariaAdulto09 { get; set; }
        public decimal DiariaAdulto10 { get; set; }
        public decimal DiariaCriancaFaixa01 { get; set; }
        public decimal DiariaCriancaFaixa02 { get; set; }
        public decimal DiariaCriancaFaixa03 { get; set; }
    }
}