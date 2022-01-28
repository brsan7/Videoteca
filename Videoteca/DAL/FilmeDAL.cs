using System.Data;
using Videoteca.BLL;

namespace Videoteca.DAL
{
    class FilmeDAL
    {
        public void Cadastrar(FilmeBLL filme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.FilmeBLL.Add(filme);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public List<FilmeBLL> Consultar()
        {
            List<FilmeBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.FilmeBLL select filmes).ToList<FilmeBLL>();
                }
                catch (Exception)
                {
                    resultado = new List<FilmeBLL>();
                }
            }
            return resultado;
        }

        public List<FilmeBLL> FiltrarTitulo(string busca)
        {
            List<FilmeBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.FilmeBLL
                                 where filmes.TITULO_FILME.Contains(busca)
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<FilmeBLL>();
                }
            }
            return resultado;
        }

        public List<FilmeBLL> FiltrarGenero(string busca)
        {
            List<FilmeBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.FilmeBLL
                                 where filmes.GENERO == busca
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<FilmeBLL>();
                }
            }
            return resultado;
        }

        public FilmeBLL BuscarUltimoRegistro(FilmeBLL filme)
        {
            FilmeBLL resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.FilmeBLL.OrderByDescending(f => f.TITULO_FILME == filme.TITULO_FILME).First();
                }
                catch (Exception)
                {
                    resultado = new FilmeBLL();
                }
            }
            return resultado;
        }

        public void Excluir(FilmeBLL filme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.FilmeBLL.Remove(filme);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public FilmeBLL PreecheFilme(int id_filme)
        {
            FilmeBLL resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.FilmeBLL.Find(id_filme) ?? new FilmeBLL();
                }
                catch (Exception)
                {
                    resultado = new FilmeBLL();
                }
            }
            return resultado;
        }

        public void Atualizar(FilmeBLL filme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.FilmeBLL.Update(filme);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public List<string> listarGeneros(List<FilmeBLL> fonte)
        {
            List<string> lstGenero = new List<string>();
            lstGenero.Add("Gênero");
            foreach (var item in fonte)
            {
                if (!lstGenero.Contains(item.GENERO))
                {
                    lstGenero.Add(item.GENERO);
                }
            }
            return lstGenero;
        }
    }
}
