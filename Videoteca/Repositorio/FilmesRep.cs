using System.Data;
using Videoteca.Entidade;

namespace Videoteca.Repositorio
{
    class FilmesRep
    {
        public static void Cadastrar(Filmes filme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Filmes.Add(filme);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static List<Filmes> Consultar()
        {
            List<Filmes> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.Filmes select filmes).ToList<Filmes>();
                }
                catch (Exception)
                {
                    resultado = new List<Filmes>();
                }
            }
            return resultado;
        }

        public static List<Filmes> FiltrarTitulo(string busca)
        {
            List<Filmes> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.Filmes
                                 where filmes.TITULO_FILME.Contains(busca)
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<Filmes>();
                }
            }
            return resultado;
        }

        public static List<Filmes> FiltrarGenero(string busca)
        {
            List<Filmes> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.Filmes
                                 where filmes.GENERO == busca
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<Filmes>();
                }
            }
            return resultado;
        }

        public static Filmes BuscarUltimoRegistro(Filmes filme)
        {
            Filmes resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.Filmes.OrderByDescending(f => f.TITULO_FILME == filme.TITULO_FILME).First();
                }
                catch (Exception)
                {
                    resultado = new Filmes();
                }
            }
            return resultado;
        }

        public static void Excluir(Filmes filme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Filmes.Remove(filme);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static Filmes PreecheFilme(int id_filme)
        {
            Filmes resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.Filmes.Find(id_filme) ?? new Filmes();
                }
                catch (Exception)
                {
                    resultado = new Filmes();
                }
            }
            return resultado;
        }

        public static void Atualizar(Filmes filme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Filmes.Update(filme);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }
    }
}
