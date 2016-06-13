using SendGrid;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity.SqlServer;
using System.Linq;
using System.Net.Mail;
using WebReserva.Models;
using WebReserva.ViewModels;

namespace WebReserva.EntityFramework
{
    public class WebReservaRepository : IWebReservaRepository
    {
        private WebReservaContext _context;

        public WebReservaRepository(WebReservaContext context)
        {
            _context = context;
        }

        public bool AddEmail(WrMailing newEmail)
        {
            var hasEmail = _context.WrMailings.SingleOrDefault(a =>
                    a.Email == newEmail.Email &&
                    a.WrHotelId == newEmail.WrHotelId);

            //TODO validar se tenant existe

            if (hasEmail != null)
            {
                throw new Exception("E-mail já cadastrado");
            }

            _context.WrMailings.Add(newEmail);

            return true;
        }

        public List<WrBloqueioData> GetSectionSlider(int wrHotelId)
        {
            var bloqueios = _context.WrBloqueioDatas.Where(a =>
                a.Inicio > DateTime.Now &&
                a.WrHotelId == wrHotelId &&
                a.Pacote == true);
            var b = bloqueios.OrderBy(a => a.Inicio).Skip(Math.Max(0, bloqueios.Count() - 3)).ToList();

            return b;
        }

        public List<SectionPackageViewModel> GetSectionPackage(int wrHotelId)
        {
            var hostUrl = _context.WrHotels.FirstOrDefault(s => s.Id == wrHotelId);

            var pacotes = (from p in _context.WrBloqueioDatas
                           where p.Inicio > DateTime.Now &&
                                 p.WrHotelId == wrHotelId &&
                                 p.Pacote == true
                           select new SectionPackageViewModel
                           {
                               PackageId = p.Id,
                               Titulo = p.Titulo,
                               Imagem = p.Img01,
                               Valor = p.Valor,
                               HostUrl = hostUrl.HostUrl,
                               Inicio = SqlFunctions.DateName("day", p.Inicio) + "/" + SqlFunctions.DatePart("month", p.Inicio) + "/" + SqlFunctions.DateName("year", p.Inicio),
                               Fim = SqlFunctions.DateName("day", p.Fim) + "/" + SqlFunctions.DatePart("month", p.Fim) + "/" + SqlFunctions.DateName("year", p.Fim),
                               Adultos = 1
                           }).ToList();

            return pacotes;
        }

        public SectionAboutViewModel GetSectionAbout(int wrHotelId)
        {
            var wrHotel = _context.WrHotels.Where(a => a.Id == wrHotelId).SingleOrDefault();

            if (wrHotel == null)
            {
                throw new Exception("Hotel não encontrado");
            }

            var about = new SectionAboutViewModel()
            {
                NomeHotel = wrHotel.Nome,
                DescricaoHotel = wrHotel.Descricao,
                ImgSobre01 = wrHotel.ImgSobre01,
                ImgSobre02 = wrHotel.ImgSobre02,
                ImgSobre03 = wrHotel.ImgSobre03
            };

            return about;
        }

        public WrHotel GetTenantBasedOnUrl(string hostUrl)
        {
            return _context.WrHotels.FirstOrDefault(a => a.HostUrl.ToLower().Equals(hostUrl));
        }

        public bool Save()
        {
            try
            {
                return _context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                // TODO log

                return false;
            }
        }

        public bool SendEmail(SectionContactViewModel newEmail)
        {
            var wrHotel = _context.WrHotels.Where(a => a.Id == newEmail.WrHotelId).SingleOrDefault();

            if (wrHotel == null)
            {
                throw new Exception("Email do hotel não encontrado");
            }

            SendGridMessage myMessage = new SendGridMessage();
            myMessage.AddTo(wrHotel.EmailAdministrador);
            myMessage.From = new MailAddress("contato@webreserva.com", wrHotel.Nome);
            myMessage.Subject = newEmail.Assunto;

            myMessage.Html = "";
            myMessage.Html += "<center>";
            myMessage.Html += "	<table style=\"width:600px;padding:15px;background-color:#999;font-family:verdana,tahoma,sans-serif;color:#fff;\">";
            myMessage.Html += "		<tbody>";
            myMessage.Html += "			<tr>";
            myMessage.Html += "				<td align=\"center\" colspan=\"2\" style=\"padding-bottom:50px;\">";
            myMessage.Html += "					<a href=\"http://webreserva-v3.azurewebsites.net/" + wrHotel.HostUrl + "\"><img src=\"http://webreserva-v3.azurewebsites.net/Content/" + wrHotel.HostUrl + "/img/logo.png\" alt=\"WebReserva\"></a>";
            myMessage.Html += "				</td>";
            myMessage.Html += "			</tr>";
            myMessage.Html += "			<tr>";
            myMessage.Html += "				<td>";
            myMessage.Html += "					<strong>Nome:</strong>";
            myMessage.Html += "				</td>";
            myMessage.Html += "				<td style=\"padding:0 15px;\">" + newEmail.Nome + "</td>";
            myMessage.Html += "			</tr>";
            myMessage.Html += "			<tr>";
            myMessage.Html += "				<td>";
            myMessage.Html += "					<strong>Email:</strong>";
            myMessage.Html += "				</td>";
            myMessage.Html += "				<td style=\"padding:0 15px;\">" + newEmail.Email + "</td>";
            myMessage.Html += "			</tr>";
            myMessage.Html += "			<tr>";
            myMessage.Html += "				<td>";
            myMessage.Html += "					<strong>Assunto:</strong>";
            myMessage.Html += "				</td>";
            myMessage.Html += "				<td style=\"padding:0 15px;\">" + newEmail.Assunto + "</td>";
            myMessage.Html += "			</tr>";
            myMessage.Html += "			<tr>";
            myMessage.Html += "				<td>";
            myMessage.Html += "					<strong>Mensagem:</strong>";
            myMessage.Html += "				</td>";
            myMessage.Html += "				<td style=\"padding:0 15px;\">" + newEmail.Mensagem + "</td>";
            myMessage.Html += "			</tr>";
            myMessage.Html += "		</tbody>";
            myMessage.Html += "	</table>";
            myMessage.Html += "</center>";

            var transportWeb = new Web(ConfigurationManager.AppSettings["SendGridApiKey"]);

            transportWeb.DeliverAsync(myMessage);

            return true;
        }

        public WrTipoApartamento GetWrTipoApartamento(int wrHotelId)
        {
            var acomodacao = _context.WrTipoApartamentos.FirstOrDefault(a => a.Id == wrHotelId);

            return acomodacao;
        }

        public List<SectionPackageViewModel> AlertIfPackageFound(SectionAvailabilityViewModel sectionAvailability)
        {
            var hostUrl = _context.WrHotels.FirstOrDefault(s => s.Id == sectionAvailability.WrHotelId);

            var bloqueios = (from a in _context.WrBloqueioDatas
                             where (sectionAvailability.CheckIn < a.Inicio &&
                                   sectionAvailability.CheckIn < a.Fim &&
                                   sectionAvailability.CheckOut > a.Inicio &&
                                   sectionAvailability.CheckOut < a.Fim) ||
                                   (sectionAvailability.CheckIn >= a.Inicio &&
                                   sectionAvailability.CheckIn < a.Fim &&
                                   sectionAvailability.CheckOut > a.Inicio &&
                                   sectionAvailability.CheckOut < a.Fim) ||
                                   (sectionAvailability.CheckIn > a.Inicio &&
                                   sectionAvailability.CheckIn < a.Fim &&
                                   sectionAvailability.CheckOut > a.Inicio &&
                                   sectionAvailability.CheckOut > a.Fim) ||
                                   (sectionAvailability.CheckIn > a.Inicio &&
                                   sectionAvailability.CheckIn < a.Fim &&
                                   sectionAvailability.CheckOut > a.Inicio &&
                                   sectionAvailability.CheckOut <= a.Fim)
                             select new SectionPackageViewModel
                             {
                                 PackageId = a.Id,
                                 Titulo = a.Titulo,
                                 Imagem = a.Img01,
                                 Valor = a.Valor,
                                 HostUrl = hostUrl.HostUrl,
                                 Inicio = SqlFunctions.DateName("day", a.Inicio) + "/" + SqlFunctions.DatePart("month", a.Inicio) + "/" + SqlFunctions.DateName("year", a.Inicio),
                                 Fim = SqlFunctions.DateName("day", a.Fim) + "/" + SqlFunctions.DatePart("month", a.Fim) + "/" + SqlFunctions.DateName("year", a.Fim),
                                 Adultos = 1
                             }).ToList();

            return bloqueios;
        }

        public List<SectionRoomViewModel> GetAvailability(SectionAvailabilityViewModel sectionAvailability)
        {
            var availability = (from a in _context.WrDisponibilidades
                                where a.Data >= sectionAvailability.CheckIn &&
                                      a.Data < sectionAvailability.CheckOut &&
                                      a.Quantidade > 0
                                group a by a.WrTipoApartamentoId into g
                                select new SectionRoomViewModel
                                {
                                    RoomId = g.Key,
                                    Nome = g.FirstOrDefault().WrTipoApartamento.Nome,
                                    Descricao = g.FirstOrDefault().WrTipoApartamento.Descricao,
                                    Img01 = g.FirstOrDefault().WrTipoApartamento.Img01,
                                    DestaqueTitulo = g.FirstOrDefault().WrTipoApartamento.DestaqueTitulo,
                                    OpcionalTitulo01 = g.FirstOrDefault().WrTipoApartamento.OpcionalTitulo01,
                                    OpcionalTitulo02 = g.FirstOrDefault().WrTipoApartamento.OpcionalTitulo02,
                                    OpcionalTitulo03 = g.FirstOrDefault().WrTipoApartamento.OpcionalTitulo03,
                                    ValorDiariaTotal = g.Sum(x => x.ValorDiaria),
                                    QuantidadeDiasRetornados = g.Select(x => x.Data).Distinct().Count(),
                                    QuantidadeDiasPesquisados = sectionAvailability.TotalDias,
                                    DatasDisponiveis = g.Select(x => x.Data)
                                }).ToList();

            return availability;
        }

        public int SaveReservation(PostReservationViewModel newReservation)
        {
            var wrHotel = _context.WrHotels.Where(a => a.Id == newReservation.WrHotelId).SingleOrDefault();

            if (wrHotel == null)
            {
                throw new Exception("Hotel não encontrado");
            }

            //TODO converter datas para formato correto
            try
            {
                var reserva = new WrReserva()
                {
                    Adulto = newReservation.Adultos,
                    Chd = newReservation.Criancas,
                    CheckIn = Convert.ToDateTime(newReservation.CheckIn, System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat),
                    CheckOut = Convert.ToDateTime(newReservation.CheckOut, System.Globalization.CultureInfo.GetCultureInfo("pt-BR").DateTimeFormat),
                    Chegada = DateTime.Now,
                    Saida = DateTime.Now,
                    Cpf = "",
                    IdLetoh = 0,
                    Status = 0,
                    ApartamentoNomeHospede = newReservation.Nome,
                    DataIntegra = DateTime.Now,
                    Email = newReservation.Email,
                    Nome = newReservation.Nome,
                    Telefone = newReservation.Telefone,
                    Observacao = newReservation.Observacoes,
                    QtdUh = 1,
                    WrTipoApartamentoId = newReservation.WrTipoApartamentoId,
                    ValorTotal = newReservation.ValorTotal
                };

                _context.WrReservas.Add(reserva);

                if (_context.SaveChanges() > 0)
                {
                    SendGridMessage myMessage = new SendGridMessage();
                    myMessage.AddTo(wrHotel.EmailAdministrador);
                    myMessage.From = new MailAddress("contato@webreserva.com", wrHotel.Nome);
                    myMessage.Subject = "Pré-reserva";

                    myMessage.Html = "";
                    myMessage.Html += "<center>";
                    myMessage.Html += "	<table style=\"width:600px;padding:15px;background-color:#999;font-family:verdana,tahoma,sans-serif;color:#fff;\">";
                    myMessage.Html += "		<tbody>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td align=\"center\" colspan=\"2\" style=\"padding-bottom:50px;\">";
                    myMessage.Html += "					<a href=\"http://webreserva-v3.azurewebsites.net/" + wrHotel.HostUrl + "\"><img src=\"http://webreserva-v3.azurewebsites.net/Content/" + wrHotel.HostUrl + "/img/logo.png\" alt=\"WebReserva\"></a>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Nome:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Nome + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Sobrenome:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Sobrenome + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Endereço:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Endereco + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Complemento:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Complemento + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Cidade:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Cidade + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Estado:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Estado + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Email:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Email + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Telefone:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Telefone + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Observações:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.Observacoes + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Tipo de pagamento:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.TipoPagamento + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Ticket da reserva:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + reserva.Id + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Quantidade de adultos:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + reserva.Adulto + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Quantidade de crianças:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + reserva.Chd + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Check-in:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.CheckIn + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "			<tr>";
                    myMessage.Html += "				<td>";
                    myMessage.Html += "					<strong>Check-out:</strong>";
                    myMessage.Html += "				</td>";
                    myMessage.Html += "				<td style=\"padding:0 15px;\">" + newReservation.CheckOut + "</td>";
                    myMessage.Html += "			</tr>";
                    myMessage.Html += "		</tbody>";
                    myMessage.Html += "	</table>";
                    myMessage.Html += "</center>";

                    var transportWeb = new Web(ConfigurationManager.AppSettings["SendGridApiKey"]);

                    transportWeb.DeliverAsync(myMessage);

                    return reserva.Id;
                }
            }
            catch (Exception ex)
            {
                //TODO log
                throw ex;
            }

            return 0;
        }
    }
}
