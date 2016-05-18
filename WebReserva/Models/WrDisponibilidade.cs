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

        public decimal DiariaCrianca00 { get; set; }
        public decimal DiariaCrianca01 { get; set; }
        public decimal DiariaCrianca02 { get; set; }
        public decimal DiariaCrianca03 { get; set; }
        public decimal DiariaCrianca04 { get; set; }
        public decimal DiariaCrianca05 { get; set; }
        public decimal DiariaCrianca06 { get; set; }
        public decimal DiariaCrianca07 { get; set; }
        public decimal DiariaCrianca08 { get; set; }
        public decimal DiariaCrianca09 { get; set; }
        public decimal DiariaCrianca10 { get; set; }
        public decimal DiariaCrianca11 { get; set; }
        public decimal DiariaCrianca12 { get; set; }
        public decimal DiariaCrianca13 { get; set; }
        public decimal DiariaCrianca14 { get; set; }
        public decimal DiariaCrianca15 { get; set; }
        public decimal DiariaCrianca16 { get; set; }
        public decimal DiariaCrianca17 { get; set; }
    }
}
