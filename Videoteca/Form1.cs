using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Videoteca
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void atorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            UI.frmAtor tela = new UI.frmAtor();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            UI.frmSerie tela = new UI.frmSerie();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void serieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            UI.frmSerie tela = new UI.frmSerie();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void frmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                MessageBox.Show(e.CloseReason.ToString());
            }
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.Titulo;
            this.BackColor = Properties.Settings.Default.CorDasTelas;

            DAL.Conexao status = new DAL.Conexao();

            if (status.TestarConexao())
            {
                lblUsuario.Text = "Conexão Estabelecida";
                atoresToolStripMenuItem.Enabled = true;
                filmesToolStripMenuItem.Enabled = true;
                seriesToolStripMenuItem.Enabled = true;
                backupToolStripMenuItem.Enabled = true;
            }
            else
            {
                lblUsuario.Text = "Conexão não Estabelecida";
                atoresToolStripMenuItem.Enabled = false;
                filmesToolStripMenuItem.Enabled = false;
                seriesToolStripMenuItem.Enabled = false;
                backupToolStripMenuItem.Enabled = false;
            }
            //this.Text = Properties.Settings.Default.Titulo;
            //this.BackColor = Properties.Settings.Default.CorDasTelas;

            //lblUsuario.Text = "Nenhum usuario logado";
            //atoresToolStripMenuItem.Enabled = false;
            //coordenadorToolStripMenuItem.Enabled = false;
            //cursoToolStripMenuItem.Enabled = false;
            //matriculaToolStripMenuItem.Enabled = false;
            //backupToolStripMenuItem.Enabled = false;

            //loginLogoutToolStripMenuItem.Text = "Login";

            //UI.frmLogin tela = new UI.frmLogin();
            //tela.ShowDialog();

            //if (tela.RetornaLogin().Autenticado)
            //{
            //    lblUsuario.Text = "Usuário logado: " + tela.RetornaLogin().Usuario;
            //    atoresToolStripMenuItem.Enabled = true;
            //    coordenadorToolStripMenuItem.Enabled = true;
            //    cursoToolStripMenuItem.Enabled = true;
            //    matriculaToolStripMenuItem.Enabled = true;
            //    backupToolStripMenuItem.Enabled = true;

            //    loginLogoutToolStripMenuItem.Text = "Logout";
            //}
            //atoresToolStripMenuItem.Enabled = true;
        }

        private void loginLogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmMenu_Load(null, null);
        }

        private void configuracoesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmConfiguracao tela = new UI.frmConfiguracao();
            tela.MdiParent = this;
            tela.Show();
        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UI.frmBackup tela = new UI.frmBackup();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
