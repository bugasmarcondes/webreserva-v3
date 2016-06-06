using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebReserva.Models;

namespace WebReserva.ViewModels
{
    public class PageAvailabilityViewModel
    {
        public WrHotel WrHotel { get; set; }
        public SectionAvailabilityViewModel SectionAvailability { get; set; }
        public List<SectionRoomViewModel> SectionRoomList { get; set; }
        public bool HasBloqueio { get; set; }
        public List<SectionPackageViewModel> SectionPackage { get; set; }
    }
}