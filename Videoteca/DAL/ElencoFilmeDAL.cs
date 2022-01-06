using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Videoteca.DAL
{
    class ElencoFilmeDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(BLL.ElencoFilmeBLL e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO ElencoFilme(                                 
                                    ID_FILME,
                                    NOME_ATOR
                                    )
                                VALUES(@id_filme, @nome_ator)";
            cmd.Parameters.AddWithValue("@id_filme", e.ID_FILME);
            cmd.Parameters.AddWithValue("@nome_ator", e.NOME_ATOR);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }



        public List<string> Consultar(int id_filme)
        {
            List<string> resultado = new List<string>();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *                                                               
                                FROM
                                    ElencoFilme
                                WHERE
                                    ID_FILME = @id_filme";
            cmd.Parameters.AddWithValue("@id_filme", id_filme);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                resultado.Add(dr["NOME_ATOR"].ToString());
            }
            dr.Close();
            con.Desconectar();
            
            return resultado;
        }

    }
}
