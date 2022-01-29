using Videoteca.Entidade;

namespace Videoteca.Dominio
{
    class FilmeDom
    {
        public static string[] Validacao(Filmes filmesEnt)
        {
            string[] arrayValidacao = new string[3];
            arrayValidacao[0] = "valido";
            if (filmesEnt.TITULO_FILME.Equals(""))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[1] = "TITULO_FILME";
            }
            if (filmesEnt.GENERO.Equals("Gênero"))
            {
                arrayValidacao[0] = "invalido";
                arrayValidacao[2] = "GENERO";
            }
            return arrayValidacao;
        }

        public static List<string> ListarGeneros(List<Filmes> fonte)
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
