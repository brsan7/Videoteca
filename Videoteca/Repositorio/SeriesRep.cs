using System.Data;
using Videoteca.Entidade;

namespace Videoteca.Repositorio
{
    class SeriesRep
    {
        public static void Cadastrar(Series serie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Series.Add(serie);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static List<Series> Consultar()
        {
            List<Series> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.Series select filmes).ToList<Series>();
                }
                catch (Exception)
                {
                    resultado = new();
                }
            }
            return resultado;
        }

        public static List<Series> FiltrarTitulo(string busca)
        {
            List<Series> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.Series
                                 where filmes.TITULO_SERIE.Contains(busca)
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new();
                }
            }
            return resultado;
        }

        public static List<Series> FiltrarGenero(string busca)
        {
            List<Series> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.Series
                                 where filmes.GENERO == busca
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new();
                }
            }
            return resultado;
        }

        public static Series BuscarUltimoRegistro(Series serie)
        {
            Series resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.Series.OrderByDescending(f => f.TITULO_SERIE == serie.TITULO_SERIE).First();
                }
                catch (Exception)
                {
                    resultado = new();
                }
            }
            return resultado;
        }
        public static void Excluir(Series serie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Series.Remove(serie);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static Series PreecheSerie(int id_serie)
        {
            Series resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.Series.Find(id_serie) ?? new();
                }
                catch (Exception)
                {
                    resultado = new();
                }
            }
            return resultado;
        }

        public static void Atualizar(Series serie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Series.Update(serie);
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
