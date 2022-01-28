using System.Data;
using Videoteca.BLL;

namespace Videoteca.DAL
{
    class ElencoSerieDAL
    {
        public void Cadastrar(ElencoSerieBLL elenco)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoSerieBLL.Add(elenco);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public List<ElencoSerieBLL> Consultar(int id_serie)
        {
            List<ElencoSerieBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from elencoSerie in db.ElencoSerieBLL
                                 where elencoSerie.ID_SERIE == id_serie
                                 select elencoSerie).ToList<ElencoSerieBLL>();
                }
                catch (Exception)
                {
                    resultado = new List<ElencoSerieBLL>();
                }
                return resultado;
            }
        }

        public DataTable Consultar(string nome_ator)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID_SERIE");
            dt.Columns.Add("TITULO_SERIE");
            using (var db = new VideotecaContext())
            {
                try
                {
                    var atuacoesAtor = from elencoSerie in db.ElencoSerieBLL
                                       join serie in db.SerieBLL
                                       on elencoSerie.ID_SERIE equals serie.ID_SERIE
                                       where elencoSerie.NOME_ATOR == nome_ator
                                       select new { serie.ID_SERIE, serie.TITULO_SERIE };

                    foreach (var serie in atuacoesAtor)
                    {
                        dt.Rows.Add(serie.ID_SERIE, serie.TITULO_SERIE);
                    }
                }
                catch (Exception)
                {
                    //return = null;
                }
            }
            return dt;
        }

        public void Excluir(ElencoSerieBLL elencoSerie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoSerieBLL.Remove(
                        db.ElencoSerieBLL.Single(
                            registro => 
                            registro.ID_SERIE == elencoSerie.ID_SERIE
                            && registro.NOME_ATOR == elencoSerie.NOME_ATOR));

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
