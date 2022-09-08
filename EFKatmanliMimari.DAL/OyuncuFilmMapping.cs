using EFKatmanliMimari.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DAL
{
    public class OyuncuFilmMapping : EntityTypeConfiguration<OyuncuFilm>
    {
        public OyuncuFilmMapping()
        {
            this.Property(a => a.CalismaGunu).IsRequired();

            //Navigation
            this.HasRequired(s => s.Oyuncu).WithMany(c => c.OyuncuFilmleri).HasForeignKey(e => e.OyuncuID);
            this.HasRequired(s => s.Film).WithMany(c => c.OyuncuFilmleri).HasForeignKey(e => e.FilmID);
        }
    }
}
