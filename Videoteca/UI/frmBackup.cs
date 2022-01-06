using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteca.UI
{
    public partial class frmBackup : Form
    {
        public frmBackup()
        {
            InitializeComponent();
        }

        DAL.BackupDAL bkpDAL = new DAL.BackupDAL();

        private void btnGerar_Click(object sender, EventArgs e)
        {
            DialogResult resposta = 
            saveFileDialog1.ShowDialog();

            if (resposta != DialogResult.Cancel)
            {
                bkpDAL.GerarBackup(saveFileDialog1.FileName);
                MessageBox.Show("Backup Concluído");
            }
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            DialogResult resposta =
            openFileDialog1.ShowDialog();

            if (resposta != DialogResult.Cancel)
            {
                bkpDAL.RestaurarBackup(openFileDialog1.FileName);
                MessageBox.Show("Backup Restaurado");
            }
        }

        private void frmBackup_Load(object sender, EventArgs e)
        {

        }
    }
}
