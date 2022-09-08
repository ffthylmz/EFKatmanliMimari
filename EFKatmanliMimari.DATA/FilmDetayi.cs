using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DATA
{
    public class FilmDetayi
    {
        public int FilmID { get; set; }        
        public string Konusu { get; set; }
        public DateTime? Sure { get; set; }
        public DateTime? VizyonaGirisTarihi { get; set; }
        public DateTime? VizyondanCikisTarihi { get; set; }
        public decimal Hasilat { get; set; }
        public byte Puan { get; set; }
        public bool OdulluMu { get; set; }
        public string FilmAciklamasi { get; set; }

        public Film Film { get; set; }

    }
}
