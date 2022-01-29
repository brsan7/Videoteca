using Videoteca.Entidade;

namespace Videoteca.Dominio
{
    class AtorDom
    {
        public static bool Validacao(Atores atoresEnt)
        {
            bool valido = true;
            if (atoresEnt.NOME_ATOR.Equals(""))
            {
                valido = false;
            }
            return valido;
        }
    }
}
