using EFKatmanliMimari.DATA;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFKatmanliMimari.DAL
{
    public class Context : DbContext
    {
        public Context() : base("Server=ASUS\\SQLEXPRESS; Database=KatmanliDB; Trusted_Connection=True;")
        {

        }

        public DbSet<Film> Filmler { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }
        public DbSet<Oyuncu> Oyuncular { get; set; }
        public DbSet<OyuncuFilm> OyuncularFilmlerTablosu { get; set; }
        public DbSet<FilmDetayi> FilmDetaylariTablosu { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FilmMapping());
            modelBuilder.Configurations.Add(new FilmDetayiMapping());
            modelBuilder.Configurations.Add(new OyuncuFilmMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}
