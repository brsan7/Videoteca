using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Videoteca.BLL;
using Videoteca.DAL;

namespace Videoteca.UI
{
    public partial class frmAtor : Form
    {
        public frmAtor()
        {
            InitializeComponent();
        }

        AtorBLL atorBLL = new AtorBLL();
        AtorDAL atorDAL = new AtorDAL();
        ElencoFilmeDAL elencoFilmeDAL = new ElencoFilmeDAL();
        ElencoSerieDAL elencoSerieDAL = new ElencoSerieDAL();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preencher o objeto da BLL com o conteudo da UI.
            atorBLL.NOME_ATOR = txtNOME_ATOR.Text;
            atorBLL.IDADE = Convert.ToInt16(txtIDADE.Text);
            atorBLL.PAIS = txtPAIS.Text;
            atorBLL.APOSENTADO = Convert.ToBoolean(ckbAPOSENTADO.Checked);

            if (atualizar)
            {
                atorDAL.Atualizar(atorBLL);
                MessageBox.Show("Ator atualizado!");
                btnCadastrar.Text = "Cadastrar";
                atualizar = false;
                txtNOME_ATOR.ReadOnly = false;
                btnCancelar.Visible = false;
            }

            else
            {
                //Enviar para o Cadastrar da camada DAL
                atorDAL.Cadastrar(atorBLL);
                MessageBox.Show("Ator cadastrado!");

            }

            groupBox1.Text = "Registrar Ator";
            txtNOME_ATOR.Clear();
            txtIDADE.Clear();
            txtPAIS.Clear();
            ckbAPOSENTADO.Checked = false;
            dgvAtorFilmes.DataSource = null;
            dgvAtorSeries.DataSource = null;
            txtNOME_ATOR.Focus();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //Verificar se a aba Consultar foi selecionada
            if(e.TabPageIndex == 1) // 0 --> Cadastrar || 1 --> Consultar
            {
                //Configurar a fonte de dados da DataGridView
                dgvResultado.DataSource = atorDAL.Consultar();
            }
        }

        private void frmAtor_Load(object sender, EventArgs e)
        {
            //Configurar DataGridView
            //Evitar Edição
            dgvResultado.ReadOnly = true;
            //Evitar adicionar linhas (Cadastro direto na grid)
            dgvResultado.AllowUserToAddRows = false;
            //Evitar excluir linha
            dgvResultado.AllowUserToDeleteRows = false;
            //Evitar selecionar mais de uma linha
            dgvResultado.MultiSelect = false;
            //Ajustar colunas para ocupar o espaço disponivel
            dgvResultado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //Remover cabeçalho da linha (seta lateral)
            dgvResultado.RowHeadersVisible = false;
            //Evitar resize de linha
            dgvResultado.AllowUserToResizeRows = false;
            //Selecionar a linha inteira independente de qual selula clicar
            dgvResultado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtorFilmes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAtorSeries.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            atualizar = false;
        }

        private void txtFiltro_TextChanged(object? sender, EventArgs? e)
        {
            atorBLL.NOME_ATOR = txtFiltro.Text;
            dgvResultado.DataSource = atorDAL.Consultar(atorBLL);
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if(dgvResultado.SelectedRows.Count > 0)
            {
                resposta = MessageBox.Show("Deseja realmente excluir?", 
                                            "Confirmação", 
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if(resposta == DialogResult.Yes)
                {
                    atorBLL.NOME_ATOR = dgvResultado.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
                    elencoFilmeDAL.Excluir(atorBLL.NOME_ATOR);
                    elencoSerieDAL.Excluir(atorBLL.NOME_ATOR);
                    atorDAL.Excluir(atorBLL);
                    txtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            groupBox1.Text = "Registrar Ator";
            btnCadastrar.Text = "Cadastrar"; 
            atualizar = false;
            btnCancelar.Visible = false;
            txtNOME_ATOR.ReadOnly = false;

            txtNOME_ATOR.Clear();
            txtIDADE.Clear();
            txtPAIS.Clear();
            ckbAPOSENTADO.Checked = false;
            dgvAtorFilmes.DataSource = null;
            dgvAtorSeries.DataSource = null;

            txtNOME_ATOR.Focus();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ator = dgvResultado.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
            preencherRegistroAtor(ator);

            tabControl1.SelectTab(0); //Seleciona a aba Cadastrar

        }

        public void preencherRegistroAtor(string ator)
        {
            groupBox1.Text = "Atualizar Ator";
            btnCadastrar.Text = "atualizar";
            atualizar = true;
            txtNOME_ATOR.ReadOnly = true;
            btnCancelar.Visible = true;

            atorBLL.NOME_ATOR = ator;
            atorBLL = atorDAL.PreecheAtor(atorBLL);

            dgvAtorFilmes.DataSource = elencoFilmeDAL.Consultar(atorBLL);
            dgvAtorSeries.DataSource = elencoSerieDAL.Consultar(atorBLL);
            dgvAtorFilmes.Columns["ID_FILME"].Visible = false;
            dgvAtorSeries.Columns["ID_SERIE"].Visible = false;

            txtNOME_ATOR.Text = atorBLL.NOME_ATOR;
            txtIDADE.Text = atorBLL.IDADE.ToString();
            txtPAIS.Text = atorBLL.PAIS;
            ckbAPOSENTADO.Checked = atorBLL.APOSENTADO;
        }

        private void dgvAtorFilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_filme = Convert.ToInt16(dgvAtorFilmes.SelectedRows[0].Cells["ID_FILME"].Value);
            frmFilme visualizacao = new frmFilme();
            visualizacao.MdiParent = frmMenu.ActiveForm;
            visualizacao.Show();
            visualizacao.preencherRegistroFilme(id_filme);
        }

        private void dgvAtorSeries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_serie = Convert.ToInt16(dgvAtorSeries.SelectedRows[0].Cells["ID_SERIE"].Value);
            frmSerie visualizacao = new frmSerie();
            visualizacao.MdiParent = frmMenu.ActiveForm;
            visualizacao.Show();
            visualizacao.preencherRegistroSerie(id_serie);
        }
    }
}
