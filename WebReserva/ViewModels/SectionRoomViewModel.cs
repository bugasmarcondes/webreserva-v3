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
    }
}