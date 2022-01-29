using Videoteca.Entidade;

namespace Videoteca.Dominio
{
    class ElencoDom
    {
        public static List<string> LstAtoresInserir(List<string> lstRegistrada, List<Atores> lstAtualizada)
        {
            List<string> inserir = new();
            foreach (Atores item in lstAtualizada)
            {
                if (!lstRegistrada.Contains(item.NOME_ATOR))
                {
                    inserir.Add(item.NOME_ATOR);
                }
            }
            return inserir;
        }

        public static List<string> LstAtoresRemover(List<string> lstRegistrada, List<Atores> lstAtualizada)
        {
            List<string> remover = new();
            bool contido = false;

            foreach (string ator_lstRegistrada in lstRegistrada)
            {
                foreach (Atores item_lstAtualizada in lstAtualizada)
                {
                    if (item_lstAtualizada.NOME_ATOR.Equals(ator_lstRegistrada))
                    {
                        contido = true;
                    }
                }
                if (!contido)
                {
                    remover.Add(ator_lstRegistrada);
                }
                contido = false;
            }
            return remover;
        }
    }
}
