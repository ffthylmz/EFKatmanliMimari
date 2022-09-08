using EFKatmanliMimari.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DAL
{
    public class FilmMapping : EntityTypeConfiguration<Film>
    {
        public FilmMapping()
        {
            //Fluent API ' leri ekliyoruz.

            this.ToTable("Filmler");
            this.Property(a => a.Adi).IsRequired().HasMaxLength(50);

            //Bire çok ilişki;
            this.HasRequired(f => f.Kategori).WithMany(h => h.Filmler).HasForeignKey(g => g.KategoriID);
        }
    }
}
