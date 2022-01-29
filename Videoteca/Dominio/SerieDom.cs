using Videoteca.Entidade;

namespace Videoteca.Dominio
{
    class SerieDom
    {
        public static string[] Validacao(Series seriesEnt)
        {
            string[] arrayValidacao = new string[5];
            arrayValidacao[0] = "valido";
            if (seriesEnt.TITULO_SERIE.Equals(""))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[1] = "TITULO_SERIE";
            }
            if (seriesEnt.TEMPORADA == 0)
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[2] = "TEMPORADA";
            }
            if (seriesEnt.EPISODIO == 0)
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[3] = "EPISODIO";
            }
            if (seriesEnt.GENERO.Equals("Gênero"))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[4] = "GENERO";
            }
            return arrayValidacao;
        }

        public static List<string> ListarGeneros(List<Series> fonte)
        {
            List<string> lstGenero = new();
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
