using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DATA
{
    public class Film
    {
        //Adı, Konusu, Süresi, Türü, Yönetmeni, Oyuncuları, VizyonaGiriş ve Çıkış Tarihi, Hasılat, Puan(IMDB), ÖdüllüMü

        public int FilmID { get; set; }
        public string Adi { get; set; }

        public Kategori Kategori { get; set; }
        public int KategoriID { get; set; }
        public FilmDetayi FilmDetayi { get; set; }
        public List<OyuncuFilm> OyuncuFilmleri { get; set; }
    }
}
