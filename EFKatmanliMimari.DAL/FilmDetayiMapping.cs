using EFKatmanliMimari.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DAL
{
    public class FilmDetayiMapping : EntityTypeConfiguration<FilmDetayi>
    {
        public FilmDetayiMapping()
        {
            this.HasKey(x => x.FilmID);
            this.Property(a => a.Konusu).IsRequired().HasMaxLength(50);

            this.HasRequired(d => d.Film).WithRequiredPrincipal(v => v.FilmDetayi);
        }
    }
}
