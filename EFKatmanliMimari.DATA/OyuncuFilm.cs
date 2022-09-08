using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DATA
{
    public class OyuncuFilm
    {
        public int ID { get; set; }
        public int CalismaGunu { get; set; }
        public bool BasrolMu { get; set; }

        //Navigation
        public Film Film { get; set; }
        public int FilmID { get; set; }
        public Oyuncu Oyuncu { get; set; }
        public int OyuncuID { get; set; }
    }
}
