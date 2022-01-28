using System.Data;
using Videoteca.BLL;

namespace Videoteca.DAL
{
    class SerieDAL
    {
        public void Cadastrar(SerieBLL serie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.SerieBLL.Add(serie);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public List<SerieBLL> Consultar()
        {
            List<SerieBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.SerieBLL select filmes).ToList<SerieBLL>();
                }
                catch (Exception)
                {
                    resultado = new List<SerieBLL>();
                }
            }
            return resultado;
        }

        public List<SerieBLL> FiltrarTitulo(string busca)
        {
            List<SerieBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.SerieBLL
                                 where filmes.TITULO_SERIE.Contains(busca)
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<SerieBLL>();
                }
            }
            return resultado;
        }

        public List<SerieBLL> FiltrarGenero(string busca)
        {
            List<SerieBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from filmes in db.SerieBLL
                                 where filmes.GENERO == busca
                                 select filmes).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<SerieBLL>();
                }
            }
            return resultado;
        }

        public SerieBLL BuscarUltimoRegistro(SerieBLL serie)
        {
            SerieBLL resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.SerieBLL.OrderByDescending(f => f.TITULO_SERIE == serie.TITULO_SERIE).First();
                }
                catch (Exception)
                {
                    resultado = new SerieBLL();
                }
            }
            return resultado;
        }
        public void Excluir(SerieBLL serie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.SerieBLL.Remove(serie);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public SerieBLL PreecheSerie(int id_serie)
        {
            SerieBLL resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.SerieBLL.Find(id_serie) ?? new SerieBLL();
                }
                catch (Exception)
                {
                    resultado = new SerieBLL();
                }
            }
            return resultado;
        }

        public void Atualizar(SerieBLL serie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.SerieBLL.Update(serie);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public List<string> listarGeneros(List<SerieBLL> fonte)
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
