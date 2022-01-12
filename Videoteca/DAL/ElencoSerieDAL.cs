﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;
using Videoteca.BLL;

namespace Videoteca.DAL
{
    class ElencoSerieDAL
    {
        Conexao con = new Conexao();

        public void Cadastrar(ElencoSerieBLL e)
        {
            
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"INSERT INTO ElencoSerie(                                 
                                    ID_SERIE,
                                    NOME_ATOR
                                    )
                                VALUES(@id_serie, @nome_ator)";
            cmd.Parameters.AddWithValue("@id_serie", e.ID_SERIE);
            cmd.Parameters.AddWithValue("@nome_ator", e.NOME_ATOR);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }



        public List<string> Consultar(int id_serie)
        {
            List<string> resultado = new List<string>();

            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"SELECT 
                                    *                                                               
                                FROM
                                    ElencoSerie
                                WHERE
                                    ID_SERIE = @id_serie";
            cmd.Parameters.AddWithValue("@id_serie", id_serie);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                resultado.Add(dr["NOME_ATOR"].ToString());
            }
            dr.Close();
            con.Desconectar();
            
            return resultado;
        }

        public void Excluir(ElencoSerieBLL e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = @"DELETE
                                FROM 
                                    ElencoSerie
                                WHERE
                                    ID_SERIE = @id_serie
                                AND
                                    NOME_ATOR = @nome_ator";
            cmd.Parameters.AddWithValue("@id_serie", e.ID_SERIE);
            cmd.Parameters.AddWithValue("@nome_ator", e.NOME_ATOR);
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}