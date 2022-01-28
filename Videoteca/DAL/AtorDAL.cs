using System.Data;
using Videoteca.BLL;


namespace Videoteca.DAL
{
    class AtorDAL
    {
        public void Cadastrar(AtorBLL ator)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.AtorBLL.Add(ator);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public List<AtorBLL> Consultar()
        {
            List<AtorBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from Atores in db.AtorBLL select Atores).ToList<AtorBLL>();
                }
                catch (Exception)
                {
                    resultado = new List<AtorBLL>();
                }
            }
            return resultado;
        }

        public List<AtorBLL> Consultar(string busca)
        {
            List<AtorBLL> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from atores in db.AtorBLL
                                 where atores.NOME_ATOR.Contains(busca)
                                 select atores).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<AtorBLL>();
                }
            }
            return resultado;
        }

        public void Excluir(AtorBLL ator)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.AtorBLL.Remove(ator);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public AtorBLL PreecheAtor(string ator)
        {
            AtorBLL resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.AtorBLL.Find(ator) ?? new AtorBLL();
                }
                catch (Exception)
                {
                    resultado = new AtorBLL();
                }
            }
            return resultado;
        }

        public void Atualizar(AtorBLL ator)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.AtorBLL.Update(ator);
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
