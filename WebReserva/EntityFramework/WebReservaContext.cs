using System.Data.Entity;
using WebReserva.Models;

namespace WebReserva.EntityFramework
{
    public class WebReservaContext : DbContext
    {
        public WebReservaContext() : base("WebReserva")
        {

        }

        public DbSet<WrBloqueioData> WrBloqueioDatas { get; set; }
        public DbSet<WrDisponibilidade> WrDisponibilidades { get; set; }
        public DbSet<WrHotel> WrHotels { get; set; }
        public DbSet<WrReserva> WrReservas { get; set; }
        public DbSet<WrTipoApartamento> WrTipoApartamentos { get; set; }
        public DbSet<WrMailing> WrMailings { get; set; }
        public DbSet<WrPesquisa> WrPesquisas { get; set; }
    }
}
