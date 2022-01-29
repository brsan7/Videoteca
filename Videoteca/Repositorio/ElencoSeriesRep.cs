using System.Data;
using Videoteca.Entidade;

namespace Videoteca.Repositorio
{
    class ElencoSeriesRep
    {
        public static void Cadastrar(ElencoSeries elenco)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoSeries.Add(elenco);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static List<ElencoSeries> Consultar(int id_serie)
        {
            List<ElencoSeries> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from elencoSerie in db.ElencoSeries
                                 where elencoSerie.ID_SERIE == id_serie
                                 select elencoSerie).ToList<ElencoSeries>();
                }
                catch (Exception)
                {
                    resultado = new List<ElencoSeries>();
                }
                return resultado;
            }
        }

        public static DataTable Consultar(string nome_ator)
        {
            DataTable dt = new();
            dt.Columns.Add("ID_SERIE");
            dt.Columns.Add("TITULO_SERIE");
            using (var db = new VideotecaContext())
            {
                try
                {
                    var atuacoesAtor = from elencoSerie in db.ElencoSeries
                                       join serie in db.Series
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

        public static void Excluir(ElencoSeries elencoSerie)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoSeries.Remove(
                        db.ElencoSeries.Single(
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
