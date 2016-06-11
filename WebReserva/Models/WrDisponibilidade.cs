using System;

namespace WebReserva.Models
{
    public class WrDisponibilidade
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public int Quantidade { get; set; }
        public decimal ValorDiaria { get; set; }
        public int WrTipoApartamentoId { get; set; }
        public virtual WrTipoApartamento WrTipoApartamento { get; set; }
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
