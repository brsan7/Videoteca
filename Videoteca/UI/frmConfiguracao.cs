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
    public partial class frmConfiguracao : Form
    {
        public frmConfiguracao()
        {
            InitializeComponent();
        }

        private void frmConfiguracao_Load(object sender, EventArgs e)
        {
            txtTitulo.Text = Properties.Settings.Default.Titulo;
            txtNomeBase.Text = Properties.Settings.Default.NomeBaseDeDados;
            txtEndereco.Text = Properties.Settings.Default.EnderecoServidorSQL;
            txtCor.Text = Properties.Settings.Default.CorDasTelas.ToString();
        }

        private void btnCor_Click(object sender, EventArgs e)
        {
            DialogResult resposta = colorDialog1.ShowDialog();
            if(resposta != DialogResult.Cancel)
            {
                Properties.Settings.Default.CorDasTelas = colorDialog1.Color;
                txtCor.Text = colorDialog1.Color.ToString();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Titulo = txtTitulo.Text;
            Properties.Settings.Default.EnderecoServidorSQL = txtEndereco.Text;
            Properties.Settings.Default.NomeBaseDeDados = txtNomeBase.Text;

            Properties.Settings.Default.Save();

            MessageBox.Show("Configurações salvas! \n\n Para que as alterações sejam aplicadas reinicie o programa.");
            this.Close();
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            frmConfiguracao_Load(null, null);
        }
    }
}
