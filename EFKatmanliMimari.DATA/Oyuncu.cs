using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DATA
{
    public class Oyuncu
    {
        //ID, Film, Adı, Soyadı, DoğumTarihi, Cinsiyet, Uyruğu

        public int OyuncuID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public DateTime DogumTarihi { get; set; }
        public bool Cinsiyet { get; set; }
        public string Uyruk { get; set; }
        public List<OyuncuFilm> OyuncuFilmleri { get; set; }
    }
}
