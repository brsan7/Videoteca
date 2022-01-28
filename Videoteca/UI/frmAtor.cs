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

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            //Preencher o objeto da BLL com o conteudo da UI.
            atorBLL.NOME_ATOR = txtNOME_ATOR.Text;
            atorBLL.IDADE = Convert.ToInt16(numIDADE.Value);
            atorBLL.PAIS = txtPAIS.Text;
            atorBLL.APOSENTADO = Convert.ToBoolean(ckbAPOSENTADO.Checked);

            if (atorBLL.validacao())
            {
                if (atualizar)
                {
                    btnRegistro_Atualizar();
                }
                else
                {
                    btnRegistro_Cadastrar();
                }
                btnCancelar_Click(null, null);
            }
            else
            {
                txtNOME_ATOR.PlaceholderText = "*Campo Obrigatório";
                MessageBox.Show("O Campo ''Nome'' é obrigatório");
            }
        }

        private void btnRegistro_Atualizar()
        {
            atorDAL.Atualizar(atorBLL);
            MessageBox.Show("Ator atualizado!");
            btnRegistro.Text = "Cadastrar";
            atualizar = false;
            txtNOME_ATOR.ReadOnly = false;
            btnCancelar.Visible = false;
        }

        private void btnRegistro_Cadastrar()
        {
            try
            {
                atorDAL.Cadastrar(atorBLL);
                MessageBox.Show("Ator cadastrado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível fazer o Registro."
                    + Environment.NewLine + "***O Ator já está cadastrado!***");
            }
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
        }

        private void txtFiltro_TextChanged(object? sender, EventArgs? e)
        {
            dgvResultado.DataSource = atorDAL.Consultar(txtFiltro.Text);
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
                    atorDAL.Excluir(atorBLL);
                    txtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void btnCancelar_Click(object? sender, EventArgs? e)
        {
            groupBox1.Text = "Registrar Ator";
            btnRegistro.Text = "Cadastrar"; 
            atualizar = false;
            btnCancelar.Visible = false;
            txtNOME_ATOR.ReadOnly = false;

            txtNOME_ATOR.Clear();
            numIDADE.Value = 0;
            txtPAIS.Clear();
            ckbAPOSENTADO.Checked = false;
            dgvAtorFilmes.DataSource = null;
            dgvAtorSeries.DataSource = null;

            txtNOME_ATOR.Focus();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ator = dgvResultado.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
            PreencherRegistroAtor(ator);

            tabControl1.SelectTab(0); //Seleciona a aba Cadastrar
        }

        public void PreencherRegistroAtor(string ator)
        {
            groupBox1.Text = "Atualizar Ator";
            btnRegistro.Text = "Atualizar";
            atualizar = true;
            txtNOME_ATOR.ReadOnly = true;
            btnCancelar.Visible = true;

            atorBLL = atorDAL.PreecheAtor(ator);

            dgvAtorFilmes.DataSource = elencoFilmeDAL.Consultar(atorBLL.NOME_ATOR);
            dgvAtorSeries.DataSource = elencoSerieDAL.Consultar(atorBLL.NOME_ATOR);
            dgvAtorFilmes.Columns["ID_FILME"].Visible = false;
            dgvAtorSeries.Columns["ID_SERIE"].Visible = false;

            txtNOME_ATOR.Text = atorBLL.NOME_ATOR;
            numIDADE.Value = atorBLL.IDADE;
            txtPAIS.Text = atorBLL.PAIS;
            ckbAPOSENTADO.Checked = atorBLL.APOSENTADO;
        }

        private void dgvAtorFilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_filme = Convert.ToInt16(dgvAtorFilmes.SelectedRows[0].Cells["ID_FILME"].Value);
            frmFilme visualizacao = new frmFilme();
            visualizacao.MdiParent = frmMenu.ActiveForm;
            visualizacao.Show();
            visualizacao.PreencherRegistroFilme(id_filme);
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
