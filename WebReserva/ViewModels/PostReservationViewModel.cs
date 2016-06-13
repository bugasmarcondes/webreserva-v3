using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebReserva.ViewModels
{
    public class PostReservationViewModel
    {
        public int WrHotelId { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Endereco { get; set; }
        public string Complemento { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Observacoes { get; set; }
        public int TipoPagamento { get; set; }
        public int Adultos { get; set; }
        public int Criancas { get; set; }
        public string CheckIn { get; set; }
        public string CheckOut { get; set; }
        public DateTime Chegada { get; set; }
        public DateTime Saida { get; set; }
        public string Cpf { get; set; }
        public int IdLetoh { get; set; }
        public int Status { get; set; }
        public int WrTipoApartamentoId { get; set; }
        public decimal ValorTotal { get; set; }
    }
}