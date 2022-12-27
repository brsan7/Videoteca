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
            /*
             * INSTRUÇÕES DE TESTE:
             * 1 - para criar o banco de dados, comente a string de conexão no trecho de código abaixo.
             */

            optionsBuilder.UseSqlServer($@"
                                        Server={Properties.Settings.Default.EnderecoServidorSQL};
                                        Database={Properties.Settings.Default.NomeBaseDeDados};
                                        Integrated Security=true;
                                        Trust Server Certificate=true");

            /*
             * 2 - descomente a string de conexão no trecho de código abaixo e preencha o campo "Server=".
             * 3 - no console do gerenciador de pacotes execute o comando Update-Database.
             * 4 - execute o script SQLQueryVideoteca.sql com dados de teste, localizado na raiz do projeto.
             * 5 - inverta novamente o comentário nas string's de conexão.
             */

            //optionsBuilder.UseSqlServer($@"
            //                            Server=*adicione o nome do servidor rodando na sua máquina*;
            //                            Database=Videoteca;
            //                            Integrated Security=true;
            //                            Trust Server Certificate=true");
        }

        public DbSet<Atores> Atores { get; set; } = null!;
        public DbSet<Filmes> Filmes { get; set; } = null!;
        public DbSet<Series> Series { get; set; } = null!;
        public DbSet<ElencoFilmes> ElencoFilmes { get; set; } = null!;
        public DbSet<ElencoSeries> ElencoSeries { get; set; } = null!;
    }
}
