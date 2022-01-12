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
    class AtorDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(AtorBLL a)
        {
            //Instanciar um objeto de comando SQL.
            SqlCommand cmd = new SqlCommand();
            //Configurar a conexao.
            cmd.Connection = con.Conectar();
            //Configurar o comando SQL.
            cmd.CommandText = @"INSERT INTO Atores(
                                    NOME_ATOR,
                                    IDADE,
                                    PAIS,
                                    ATIVO)
                                VALUES(@NOME_ATOR,@IDADE,@PAIS,@ATIVO)";
            //Configurar os valores.
            cmd.Parameters.AddWithValue("@NOME_ATOR", a.NOME_ATOR);
            cmd.Parameters.AddWithValue("@IDADE", a.IDADE);
            cmd.Parameters.AddWithValue("@PAIS", a.PAIS);
            cmd.Parameters.AddWithValue("@ATIVO", a.ATIVO);
            //Executar os comandos SQL.
            cmd.ExecuteNonQuery();
            //Fechar a conexão com o banco de dados.
            con.Desconectar();
        }

        public DataTable Consultar()
        {
            //Tabela de dados no padrão C# (String, double, float, int...).
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Atores";
            //Adaptador de dados padrão SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar qual comando de consulta
            da.SelectCommand = cmd;
            //Preencher o DataTable com o resultado adaptado da consulta
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        //Sobrecarga do metodo consultar (Filtro).
        public DataTable Consultar(AtorBLL a)
        {
            //Tabela de dados no padrão C# (String, double, float, int...).
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM
                                    Atores
                                WHERE
                                    NOME_ATOR like @nome_ator";
            cmd.Parameters.AddWithValue("@nome_ator", "%" + a.NOME_ATOR + "%");
            //Adaptador de dados padrão SQL para C#
            SqlDataAdapter da = new SqlDataAdapter();
            //Configurar qual comando de consulta
            da.SelectCommand = cmd;
            //Preencher o DataTable com o resultado adaptado da consulta
            da.Fill(dt);

            con.Desconectar();

            return dt;
        }

        public void Excluir(AtorBLL a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    Atores
                                WHERE
                                    NOME_ATOR = @nome_ator";
            cmd.Parameters.AddWithValue("@nome_ator", a.NOME_ATOR);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public AtorBLL PreecheAtor(AtorBLL a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *
                                FROM 
                                    Atores
                                WHERE 
                                    NOME_ATOR = @nome_ator";
            cmd.Parameters.AddWithValue("@nome_ator", a.NOME_ATOR);
            SqlDataReader dr = cmd.ExecuteReader();

            if (dr.HasRows)
            {
                dr.Read();
                a.NOME_ATOR = dr["NOME_ATOR"].ToString();
                a.IDADE = Convert.ToInt16(dr["IDADE"].ToString());
                a.PAIS = dr["PAIS"].ToString();
                a.ATIVO = Convert.ToInt16(dr["ATIVO"]);
                dr.Close();
                con.Desconectar();
            }
            else
            {
                a.NOME_ATOR = "Inválido";
            }

            return (a);

        }

        public void Atualizar(AtorBLL a)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"UPDATE
                                    Atores
                                SET
                                    NOME_ATOR = @nome_ator,
                                    IDADE = @idade,
                                    PAIS = @pais,
                                    ATIVO = @ativo
                                WHERE
                                    NOME_ATOR = @nome_ator";
            cmd.Parameters.AddWithValue("@nome_ator", a.NOME_ATOR);
            cmd.Parameters.AddWithValue("@idade", a.IDADE);
            cmd.Parameters.AddWithValue("@pais", a.PAIS);
            cmd.Parameters.AddWithValue("@ativo", a.ATIVO);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
