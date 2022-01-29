using Videoteca.UI;

namespace Videoteca
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void AtorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            FrmAtor tela = new();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void FilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            FrmFilme tela = new();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void SerieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Instanciando um objeto da tela frmAluno
            FrmSerie tela = new();

            //Prender dentro deste formulario (frmMenu)
            tela.MdiParent = this;

            //Exibir a tela
            tela.Show();
        }

        private void FrmMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult resposta;

            resposta = MessageBox.Show("Deseja realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void FrmMenu_Load(object sender, EventArgs e)
        {
            this.Text = Properties.Settings.Default.Titulo;
            this.BackColor = Properties.Settings.Default.CorDasTelas;

            Repositorio.Conexao status = new();

            atoresToolStripMenuItem.Enabled = false;
            filmesToolStripMenuItem.Enabled = false;
            seriesToolStripMenuItem.Enabled = false;
            backupToolStripMenuItem.Enabled = false;

            if (Properties.Settings.Default.EnderecoServidorSQL.ToString().Equals("(local)"))
            {
                lblUsuario.Text = "Status : Banco de Dados não configurado";
                MessageBox.Show("Configure a conexão com o Banco de Dados");
                ConfiguracoesToolStripMenuItem_Click(null, null);
            }
            else
            {
                if (status.TestarConexao())
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
                    ConfiguracoesToolStripMenuItem_Click(null, null);
                }

            }
        }

        private void ConfiguracoesToolStripMenuItem_Click(object? sender, EventArgs? e)
        {
            FrmConfiguracao tela = new();
            tela.MdiParent = this;
            tela.Show();
        }

        private void BackupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmBackup tela = new();
            tela.MdiParent = this;
            tela.Show();
        }
    }
}
