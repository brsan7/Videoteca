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
            UI.frmFilme tela = new UI.frmFilme();

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
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.Titulo;
            this.BackColor = Properties.Settings.Default.CorDasTelas;

            DAL.Conexao status = new DAL.Conexao();

            atoresToolStripMenuItem.Enabled = false;
            filmesToolStripMenuItem.Enabled = false;
            seriesToolStripMenuItem.Enabled = false;
            backupToolStripMenuItem.Enabled = false;

            if (Properties.Settings.Default.EnderecoServidorSQL.ToString().Equals("(local)"))
            {
                lblUsuario.Text = "Status : Banco de Dados não configurado";
                MessageBox.Show("Configure a conexão com o Banco de Dados");
                configuracoesToolStripMenuItem_Click(null, null);
            }
            else
            {
                if(status.TestarConexao())
                {
                    lblUsuario.Text = "Status : Conexão Estabelecida";
                    atoresToolStripMenuItem.Enabled = true;
                    filmesToolStripMenuItem.Enabled = true;
                    seriesToolStripMenuItem.Enabled = true;
                    backupToolStripMenuItem.Enabled = true;
                }
                else
                {
                    lblUsuario.Text = "Status : Conexão não Estabelecida";
                    MessageBox.Show("Verifique a configuração de conexão com o Banco de Dados");
                    configuracoesToolStripMenuItem_Click(null, null);
                }
                
            }
        }

        private void configuracoesToolStripMenuItem_Click(object? sender, EventArgs? e)
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
