using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Videoteca.BLL;

namespace Videoteca.DAL
{
    class FilmeDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(FilmeBLL f)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Filmes(                                   
                                    TITULO_FILME,
                                    DESCRICAO,
                                    GENERO,
                                    PAIS,
                                    ANO,
                                    DURACAO,
                                    AVALIACAO,
                                    ASSISTIDO)
                                VALUES(@titulo_filme,@descricao,@genero,@pais,@ano,@duracao,@avaliacao,@assistido)";

            cmd.Parameters.AddWithValue("@titulo_filme", f.TITULO_FILME);
            cmd.Parameters.AddWithValue("@descricao", f.DESCRICAO);
            cmd.Parameters.AddWithValue("@genero", f.GENERO);
            cmd.Parameters.AddWithValue("@pais", f.PAIS);
            cmd.Parameters.AddWithValue("@ano", f.ANO);
            cmd.Parameters.AddWithValue("@duracao", f.DURACAO);
            cmd.Parameters.AddWithValue("@avaliacao", f.AVALIACAO);
            cmd.Parameters.AddWithValue("@assistido", f.ASSISTIDO);

            cmd.ExecuteNonQuery();

            con.Desconectar();
        }   

        public DataTable Consultar()
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Filmes";

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public DataTable Consultar(FilmeBLL f)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Filmes
                                WHERE
                                    TITULO_FILME like @titulo_filme";
            cmd.Parameters.AddWithValue("@titulo_filme", "%" + f.TITULO_FILME + "%");
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public DataTable Consultar(string GENERO)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Filmes
                                WHERE
                                    GENERO = @genero";
            cmd.Parameters.AddWithValue("@genero", GENERO);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public FilmeBLL BuscarUltimoRegistro(FilmeBLL f)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Filmes
                                WHERE
                                    TITULO_FILME = @titulo_filme AND
                                    DESCRICAO = @descricao AND
                                    GENERO = @genero AND
                                    PAIS = @pais AND
                                    ANO = @ano AND
                                    DURACAO = @duracao AND
                                    AVALIACAO = @avaliacao AND
                                    ASSISTIDO = @assistido";
            cmd.Parameters.AddWithValue("@titulo_filme", f.TITULO_FILME);
            cmd.Parameters.AddWithValue("@descricao", f.DESCRICAO);
            cmd.Parameters.AddWithValue("@genero", f.GENERO);
            cmd.Parameters.AddWithValue("@pais", f.PAIS);
            cmd.Parameters.AddWithValue("@ano", f.ANO);
            cmd.Parameters.AddWithValue("@duracao", f.DURACAO);
            cmd.Parameters.AddWithValue("@avaliacao", f.AVALIACAO);
            cmd.Parameters.AddWithValue("@assistido", f.ASSISTIDO);
            SqlDataReader dr = cmd.ExecuteReader();
            
            if (dr.HasRows)
            {
                dr.Read();
                f.ID_FILME = Convert.ToInt16(dr["ID_FILME"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                f.ID_FILME = 0;
            }

            return (f);
        }

        public void Excluir(FilmeBLL f)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    Filmes
                                WHERE
                                    ID_FILME = @id_filme";
            cmd.Parameters.AddWithValue("@id_filme", f.ID_FILME);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public FilmeBLL PreecheFilme(FilmeBLL f)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM 
                                    Filmes
                                WHERE 
                                    ID_FILME = @id_filme";
            cmd.Parameters.AddWithValue("@id_filme", f.ID_FILME);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                f.ID_FILME = Convert.ToInt16(dr["ID_FILME"]);
                f.TITULO_FILME = dr["TITULO_FILME"].ToString();
                f.DESCRICAO = dr["DESCRICAO"].ToString();
                f.GENERO = dr["GENERO"].ToString();
                f.PAIS = dr["PAIS"].ToString();
                f.ANO = Convert.ToInt32(dr["ANO"]);
                f.DURACAO = Convert.ToInt32(dr["DURACAO"]);
                f.AVALIACAO = Convert.ToInt32(dr["AVALIACAO"]);
                f.ASSISTIDO = Convert.ToBoolean(dr["ASSISTIDO"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                f.ID_FILME = 0;
            }

            return (f);

        }
        
        public void Atualizar(FilmeBLL f)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    Filmes
                                SET
                                    TITULO_FILME = @titulo_filme,
                                    DESCRICAO = @descricao,
                                    GENERO = @genero,
                                    PAIS = @pais,
                                    ANO = @ano,
                                    DURACAO = @duracao,
                                    AVALIACAO = @avaliacao,
                                    ASSISTIDO = @assistido
                                WHERE
                                    ID_FILME = @id_filme";
            cmd.Parameters.AddWithValue("@titulo_filme", f.TITULO_FILME);
            cmd.Parameters.AddWithValue("@descricao", f.DESCRICAO);
            cmd.Parameters.AddWithValue("@genero", f.GENERO);
            cmd.Parameters.AddWithValue("@pais", f.PAIS);
            cmd.Parameters.AddWithValue("@ano", f.ANO);
            cmd.Parameters.AddWithValue("@duracao", f.DURACAO);
            cmd.Parameters.AddWithValue("@avaliacao", f.AVALIACAO);
            cmd.Parameters.AddWithValue("@assistido", f.ASSISTIDO);
            cmd.Parameters.AddWithValue("@id_filme", f.ID_FILME);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public List<string> listarGeneros(DataTable fonte)
        {
            DataTableReader dr = new DataTableReader(fonte);
            List<string> lstGenero = new List<string>();
            lstGenero.Add("Gêneros");
            while (dr.Read())
            {
                if (!lstGenero.Contains(dr["GENERO"].ToString()))
                {
                    lstGenero.Add(dr["GENERO"].ToString());
                }
            }
            dr.Close();
            return lstGenero;
        }
    }
}
