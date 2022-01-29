using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Videoteca.Entidade
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

        public DbSet<Atores> Atores { get; set; } = null!;
        public DbSet<Filmes> Filmes { get; set; } = null!;
        public DbSet<Series> Series { get; set; } = null!;
        public DbSet<ElencoFilmes> ElencoFilmes { get; set; } = null!;
        public DbSet<ElencoSeries> ElencoSeries { get; set; } = null!;
    }
}
