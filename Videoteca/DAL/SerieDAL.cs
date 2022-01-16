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
    class SerieDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(SerieBLL s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO Series(                                   
                                    TITULO_SERIE,
                                    CAPITULO,
                                    DESCRICAO,
                                    TEMPORADA,
                                    EPISODIO,
                                    GENERO,
                                    PAIS,
                                    ANO,
                                    DURACAO,
                                    AVALIACAO,
                                    ASSISTIDO)
                                VALUES(@titulo_serie,@capitulo,@descricao,@temporada,@episodio,@genero,@pais,@ano,@duracao,@avaliacao,@assistido)";

            cmd.Parameters.AddWithValue("@titulo_serie", s.TITULO_SERIE);
            cmd.Parameters.AddWithValue("@capitulo", s.CAPITULO);
            cmd.Parameters.AddWithValue("@descricao", s.DESCRICAO);
            cmd.Parameters.AddWithValue("@temporada", s.TEMPORADA);
            cmd.Parameters.AddWithValue("@episodio", s.EPISODIO);
            cmd.Parameters.AddWithValue("@genero", s.GENERO);
            cmd.Parameters.AddWithValue("@pais", s.PAIS);
            cmd.Parameters.AddWithValue("@ano", s.ANO);
            cmd.Parameters.AddWithValue("@duracao", s.DURACAO);
            cmd.Parameters.AddWithValue("@avaliacao", s.AVALIACAO);
            cmd.Parameters.AddWithValue("@assistido", s.ASSISTIDO);

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
                                    Series";

            SqlDataAdapter da = new SqlDataAdapter();

            da.SelectCommand = cmd;

            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public DataTable Consultar(SerieBLL s)
        {

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Series
                                WHERE
                                    TITULO_SERIE like @titulo_serie";
            cmd.Parameters.AddWithValue("@titulo_serie", "%" + s.TITULO_SERIE + "%");
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
                                    Series
                                WHERE
                                    GENERO = @genero";
            cmd.Parameters.AddWithValue("@genero", GENERO);
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public SerieBLL BuscarUltimoRegistro(SerieBLL s)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Series
                                WHERE
                                    TITULO_SERIE = @titulo_serie AND
                                    CAPITULO = @capitulo AND
                                    DESCRICAO = @descricao AND
                                    TEMPORADA = @temporada AND
                                    EPISODIO = @episodio AND
                                    GENERO = @genero AND
                                    PAIS = @pais AND
                                    ANO = @ano AND
                                    DURACAO = @duracao AND
                                    AVALIACAO = @avaliacao AND
                                    ASSISTIDO = @assistido";
            cmd.Parameters.AddWithValue("@titulo_serie", s.TITULO_SERIE);
            cmd.Parameters.AddWithValue("@capitulo", s.CAPITULO);
            cmd.Parameters.AddWithValue("@descricao", s.DESCRICAO);
            cmd.Parameters.AddWithValue("@temporada", s.TEMPORADA);
            cmd.Parameters.AddWithValue("@episodio", s.EPISODIO);
            cmd.Parameters.AddWithValue("@genero", s.GENERO);
            cmd.Parameters.AddWithValue("@pais", s.PAIS);
            cmd.Parameters.AddWithValue("@ano", s.ANO);
            cmd.Parameters.AddWithValue("@duracao", s.DURACAO);
            cmd.Parameters.AddWithValue("@avaliacao", s.AVALIACAO);
            cmd.Parameters.AddWithValue("@assistido", s.ASSISTIDO);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                s.ID_SERIE = Convert.ToInt16(dr["ID_SERIE"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                s.ID_SERIE = 0;
            }

            return (s);
        }
        public void Excluir(SerieBLL s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    Series
                                WHERE
                                    ID_SERIE = @id_serie";
            cmd.Parameters.AddWithValue("@id_serie", s.ID_SERIE);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public SerieBLL PreecheSerie(SerieBLL s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM 
                                    Series
                                WHERE 
                                    ID_SERIE = @id_serie";
            cmd.Parameters.AddWithValue("@id_serie", s.ID_SERIE);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                s.ID_SERIE = Convert.ToInt16(dr["ID_SERIE"]);
                s.TITULO_SERIE = dr["TITULO_SERIE"].ToString();
                s.CAPITULO = dr["CAPITULO"].ToString();
                s.DESCRICAO = dr["DESCRICAO"].ToString();
                s.TEMPORADA = Convert.ToInt32(dr["TEMPORADA"]);
                s.EPISODIO = Convert.ToInt32(dr["EPISODIO"]);
                s.GENERO = dr["GENERO"].ToString();
                s.PAIS = dr["PAIS"].ToString();
                s.ANO = Convert.ToInt32(dr["ANO"]);
                s.DURACAO = Convert.ToInt32(dr["DURACAO"]);
                s.AVALIACAO = Convert.ToInt32(dr["AVALIACAO"]);
                s.ASSISTIDO = Convert.ToBoolean(dr["ASSISTIDO"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                s.ID_SERIE = 0;
            }

            return (s);

        }

        public void Atualizar(SerieBLL s)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    Series
                                SET
                                    TITULO_SERIE = @titulo_serie,
                                    CAPITULO = @capitulo,
                                    DESCRICAO = @descricao,
                                    TEMPORADA = @temporada,
                                    EPISODIO = @episodio,
                                    GENERO = @genero,
                                    PAIS = @pais,
                                    ANO = @ano,
                                    DURACAO = @duracao,
                                    AVALIACAO = @avaliacao,
                                    ASSISTIDO = @assistido
                                WHERE
                                    ID_SERIE = @id_serie";
            cmd.Parameters.AddWithValue("@id_serie", s.ID_SERIE);
            cmd.Parameters.AddWithValue("@titulo_serie", s.TITULO_SERIE);
            cmd.Parameters.AddWithValue("@capitulo", s.CAPITULO);
            cmd.Parameters.AddWithValue("@descricao", s.DESCRICAO);
            cmd.Parameters.AddWithValue("@temporada", s.TEMPORADA);
            cmd.Parameters.AddWithValue("@episodio", s.EPISODIO);
            cmd.Parameters.AddWithValue("@genero", s.GENERO);
            cmd.Parameters.AddWithValue("@pais", s.PAIS);
            cmd.Parameters.AddWithValue("@ano", s.ANO);
            cmd.Parameters.AddWithValue("@duracao", s.DURACAO);
            cmd.Parameters.AddWithValue("@avaliacao", s.AVALIACAO);
            cmd.Parameters.AddWithValue("@assistido", s.ASSISTIDO);
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
