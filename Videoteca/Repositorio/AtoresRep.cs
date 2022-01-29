using System.Data;
using Videoteca.Entidade;


namespace Videoteca.Repositorio
{
    class AtoresRep
    {
        public static void Cadastrar(Atores ator)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Atores.Add(ator);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static List<Atores> Consultar()
        {
            List<Atores> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from Atores in db.Atores select Atores).ToList<Atores>();
                }
                catch (Exception)
                {
                    resultado = new List<Atores>();
                }
            }
            return resultado;
        }

        public static List<Atores> Consultar(string busca)
        {
            List<Atores> resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = (from atores in db.Atores
                                 where atores.NOME_ATOR.Contains(busca)
                                 select atores).ToList();
                }
                catch (Exception)
                {
                    resultado = new List<Atores>();
                }
            }
            return resultado;
        }

        public static void Excluir(Atores ator)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Atores.Remove(ator);
                    db.SaveChanges();
                }
                catch (Exception)
                {
                    //
                }
            }
        }

        public static Atores PreecheAtor(string ator)
        {
            Atores resultado;
            using (var db = new VideotecaContext())
            {
                try
                {
                    resultado = db.Atores.Find(ator) ?? new Atores();
                }
                catch (Exception)
                {
                    resultado = new Atores();
                }
            }
            return resultado;
        }

        public static void Atualizar(Atores ator)
        {
            using (var db = new VideotecaContext())
            {
                try
                {
                    db.Atores.Update(ator);
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
