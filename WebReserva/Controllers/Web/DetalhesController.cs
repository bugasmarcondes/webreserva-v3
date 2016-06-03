using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebReserva.EntityFramework;
using WebReserva.Models;
using WebReserva.ViewModels;

namespace WebReserva.Controllers.Web
{
    public class DetalhesController : MultiTenantController
    {
        private IWebReservaRepository _repository;

        public DetalhesController(IWebReservaRepository repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ActionResult Acomodacao(PostDetalhesViewMovel vm)
        {
            var wrTipoApartamento = new WrTipoApartamento();

            if (vm.RoomId > 0)
            {
                wrTipoApartamento = _repository.GetWrTipoApartamento(vm.RoomId);
            }

            var page = new PageAcomodacaoViewModel()
            {
                WrHotel = Tenant,
                Acomodacao = new SectionAcomodacaoViewModel()
                {
                    RoomId = wrTipoApartamento.Id,
                    Nome = wrTipoApartamento.Nome,
                    Descricao = wrTipoApartamento.Descricao,
                    Img01 = wrTipoApartamento.Img01,
                    Img02 = wrTipoApartamento.Img02,
                    Img03 = wrTipoApartamento.Img03,
                    DestaqueTitulo = wrTipoApartamento.DestaqueTitulo,
                    DestaqueDescricao = wrTipoApartamento.DestaqueDescricao,
                    OpcionalTitulo01 = wrTipoApartamento.OpcionalTitulo01,
                    OpcionalDescricao01 = wrTipoApartamento.OpcionalDescricao01,
                    OpcionalTitulo02 = wrTipoApartamento.OpcionalTitulo02,
                    OpcionalDescricao02 = wrTipoApartamento.OpcionalDescricao02,
                    OpcionalTitulo03 = wrTipoApartamento.OpcionalTitulo03,
                    OpcionalDescricao03 = wrTipoApartamento.OpcionalDescricao03,
                    CheckIn = vm.CheckIn,
                    CheckOut = vm.CheckOut,
                    Adultos = vm.Adultos,
                    Criancas = vm.Criancas,
                    ValorDiariaTotal = vm.ValorDiariaTotal
                }
            };

            return View(page);
        }
    }
}