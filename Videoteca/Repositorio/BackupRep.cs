using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.SqlClient;

namespace Videoteca.Repositorio
{
    class BackupRep
    {
        Conexao con = new Conexao();

        public void GerarBackup(string caminho)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "BACKUP DATABASE [" +
                               Properties.Settings.Default.NomeBaseDeDados + "]" +
                               " TO DISK = '" + caminho + "' WITH COPY_ONLY";
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }

        public void RestaurarBackup(string caminho)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con.Conectar();
            cmd.CommandText = "Use Master; RESTORE DATABASE [" +
                               Properties.Settings.Default.NomeBaseDeDados + "]" +
                               " FROM DISK = '" + caminho + "' ";
            cmd.ExecuteNonQuery();
            con.Desconectar();
        }
    }
}
