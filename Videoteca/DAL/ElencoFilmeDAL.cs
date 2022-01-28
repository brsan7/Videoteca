using System.Data;
using Videoteca.BLL;

namespace Videoteca.DAL
{
    class ElencoFilmeDAL
    {
        public void Cadastrar(ElencoFilmeBLL elenco)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoFilmeBLL.Add(elenco);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }



        public List<ElencoFilmeBLL> Consultar(int id_filme)
        {
            List<ElencoFilmeBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from elencoFilme in db.ElencoFilmeBLL 
                                 where elencoFilme.ID_FILME == id_filme
                                 select elencoFilme).ToList<ElencoFilmeBLL>();
                }
                catch (Exception)
                {
                    resultado = new List<ElencoFilmeBLL>();
                }
                return resultado;
            }
        }


        public DataTable Consultar(string nome_ator)
        {
            DataTable dt = new DataTable ();
            dt.Columns.Add("ID_FILME");
            dt.Columns.Add("TITULO_FILME");
            using (var db = new VideotecaContext())
            {
                try
                {
                    var atuacoesAtor = from elencoFilme in db.ElencoFilmeBLL
                                       join filme in db.FilmeBLL
                                       on elencoFilme.ID_FILME equals filme.ID_FILME
                                       where elencoFilme.NOME_ATOR == nome_ator
                                       select new { filme.ID_FILME, filme.TITULO_FILME };

                    foreach (var filme in atuacoesAtor)
                    {
                        dt.Rows.Add(filme.ID_FILME, filme.TITULO_FILME);
                    }
                }
                catch (Exception)
                {
                    //return = null;
                }
            }
            return dt;
        }

        public void Excluir(ElencoFilmeBLL elencoFilme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoFilmeBLL.Remove(
                        db.ElencoFilmeBLL.Single(
                            registro =>
                            registro.ID_FILME == elencoFilme.ID_FILME
                            && registro.NOME_ATOR == elencoFilme.NOME_ATOR));

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
