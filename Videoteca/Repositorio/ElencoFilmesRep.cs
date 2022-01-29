using System.Data;
using Videoteca.Entidade;

namespace Videoteca.Repositorio
{
    class ElencoFilmesRep
    {
        public static void Cadastrar(ElencoFilmes elenco)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoFilmes.Add(elenco);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static List<ElencoFilmes> Consultar(int id_filme)
        {
            List<ElencoFilmes> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from elencoFilme in db.ElencoFilmes 
                                 where elencoFilme.ID_FILME == id_filme
                                 select elencoFilme).ToList<ElencoFilmes>();
                }
                catch (Exception)
                {
                    resultado = new List<ElencoFilmes>();
                }
                return resultado;
            }
        }

        public static DataTable Consultar(string nome_ator)
        {
            DataTable dt = new();
            dt.Columns.Add("ID_FILME");
            dt.Columns.Add("TITULO_FILME");
            using (var db = new VideotecaContext())
            {
                try
                {
                    var atuacoesAtor = from elencoFilme in db.ElencoFilmes
                                       join filme in db.Filmes
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

        public static void Excluir(ElencoFilmes elencoFilme)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.ElencoFilmes.Remove(
                        db.ElencoFilmes.Single(
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
