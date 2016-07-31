using System;

namespace WebReserva.Models
{
    public class WrReserva
    {
        public int Id { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Adulto { get; set; }
        public int? Chd { get; set; }
        public int QtdUh { get; set; }
        public string Observacao { get; set; }
        public int? IdLetoh { get; set; }
        public DateTime? DataIntegra { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Cpf { get; set; }
        public string ApartamentoNomeHospede { get; set; }
        public int Status { get; set; }
        public int WrTipoApartamentoId{ get; set; }
        public decimal ValorTotal { get; set; }
        public int TipoPagamento { get; set; }
        public string NumeroCartaoCredito { get; set; }
    }
}