using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Videoteca.BLL
{
    internal class VideotecaContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer($@"
                                    Server={Properties.Settings.Default.EnderecoServidorSQL};
                                    Database={Properties.Settings.Default.NomeBaseDeDados};
                                    Integrated Security=true");
        }

        public DbSet<AtorBLL> AtorBLL { get; set; } = null!;
        public DbSet<FilmeBLL> FilmeBLL { get; set; } = null!;
        public DbSet<SerieBLL> SerieBLL { get; set; } = null!;
        public DbSet<ElencoFilmeBLL> ElencoFilmeBLL { get; set; } = null!;
        public DbSet<ElencoSerieBLL> ElencoSerieBLL { get; set; } = null!;
    }
}
