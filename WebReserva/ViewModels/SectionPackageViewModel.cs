using System;

namespace WebReserva.ViewModels
{
    public class SectionPackageViewModel
    {
        public int PackageId { get; set; }
        public string Titulo { get; set; }
        public string Imagem { get; set; }
        public decimal Valor { get; set; }
        public string HostUrl { get; set; }
        public string Inicio { get; set; }
        public string Fim { get; set; }
        public int Adultos { get; set; }
        public int QtdDiasDesbloqueio { get; set; }
    }
}