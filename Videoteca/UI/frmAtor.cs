using Videoteca.Entidade;
using Videoteca.Repositorio;
using Videoteca.Dominio;

namespace Videoteca.UI
{
    public partial class FrmAtor : Form
    {
        Atores atoresEnt = new();

        bool atualizar;

        public FrmAtor()
        {
            InitializeComponent();
        }

        private void FrmAtor_Load(object sender, EventArgs e)
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

        /////////////////INICIO EVENTO: btnRegistro_Click/////////////////
        private void BtnRegistro_Click(object sender, EventArgs e)
        {
            SetupRegistro();

            if (AtorDom.Validacao(atoresEnt))
            {
                if (atualizar)
                {
                    BtnRegistro_AcaoClick_Atualizar();
                }
                else
                {
                    BtnRegistro_AcaoClick_Cadastrar();
                }
                BtnCancelar_Click(null, null);
            }
            else
            {
                ValidacaoMsg();
            }
        }

        private void SetupRegistro()
        {
            atoresEnt.NOME_ATOR = txtNOME_ATOR.Text;
            atoresEnt.IDADE = Convert.ToInt16(numIDADE.Value);
            atoresEnt.PAIS = txtPAIS.Text;
            atoresEnt.APOSENTADO = Convert.ToBoolean(ckbAPOSENTADO.Checked);
        }

        private void BtnRegistro_AcaoClick_Atualizar()
        {
            AtoresRep.Atualizar(atoresEnt);
            MessageBox.Show("Ator atualizado!");
            btnRegistro.Text = "Cadastrar";
            atualizar = false;
            txtNOME_ATOR.ReadOnly = false;
            btnCancelar.Visible = false;
        }

        private void BtnRegistro_AcaoClick_Cadastrar()
        {
            try
            {
                AtoresRep.Cadastrar(atoresEnt);
                MessageBox.Show("Ator cadastrado!");
            }
            catch (Exception)
            {
                MessageBox.Show("Não foi possível fazer o Registro."
                    + Environment.NewLine + "***O Ator já está cadastrado!***");
            }
        }

        private void ValidacaoMsg()
        {
            txtNOME_ATOR.PlaceholderText = "*Campo Obrigatório";
            MessageBox.Show("O Campo ''Nome'' é obrigatório");
        }
        /////////////////FIM EVENTO: btnRegistro_Click/////////////////

        /////////////////INICIO EVENTO: dgvAtorFilmes_CellDoubleClick/////////////////
        private void DgvAtorFilmes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_filme = Convert.ToInt16(dgvAtorFilmes.SelectedRows[0].Cells["ID_FILME"].Value);
            FrmFilme visualizacao = new();
            visualizacao.MdiParent = FrmMain.ActiveForm;
            visualizacao.Show();
            visualizacao.PreencherRegistroFilme(id_filme);
        }
        /////////////////FIM EVENTO: dgvAtorFilmes_CellDoubleClick/////////////////

        /////////////////INICIO EVENTO: dgvAtorSeries_CellDoubleClick/////////////////
        private void DgvAtorSeries_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_serie = Convert.ToInt16(dgvAtorSeries.SelectedRows[0].Cells["ID_SERIE"].Value);
            FrmSerie visualizacao = new();
            visualizacao.MdiParent = FrmMain.ActiveForm;
            visualizacao.Show();
            visualizacao.PreencherRegistroSerie(id_serie);
        }
        /////////////////FIM EVENTO: dgvAtorSeries_CellDoubleClick/////////////////

        /////////////////INICIO EVENTO: btnCancelar_Click/////////////////
        private void BtnCancelar_Click(object? sender, EventArgs? e)
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
        /////////////////FIM EVENTO: btnCancelar_Click/////////////////

        /////////////////INICIO EVENTO: tabControl1_Selected/////////////////
        private void TabControl1_Selected(object sender, TabControlEventArgs e)
        {
            //Verificar se a aba Consultar foi selecionada
            if(e.TabPageIndex == 1) // 0 --> Cadastrar || 1 --> Consultar
            {
                //Configurar a fonte de dados da DataGridView
                dgvResultado.DataSource = AtoresRep.Consultar();
            }
        }
        /////////////////FIM EVENTO: tabControl1_Selected/////////////////

        /////////////////INICIO EVENTO: txtFiltro_TextChanged/////////////////
        private void TxtFiltro_TextChanged(object? sender, EventArgs? e)
        {
            dgvResultado.DataSource = AtoresRep.Consultar(txtFiltro.Text);
        }
        /////////////////FIM EVENTO: txtFiltro_TextChanged/////////////////

        /////////////////INICIO EVENTO: btnExcluir_Click/////////////////
        private void BtnExcluir_Click(object sender, EventArgs e)
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
                    atoresEnt.NOME_ATOR = dgvResultado.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
                    AtoresRep.Excluir(atoresEnt);
                    TxtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
        /////////////////FIM EVENTO: btnExcluir_Click/////////////////

        /////////////////INICIO EVENTO: dgvResultado_CellDoubleClick/////////////////
        private void DgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
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

            atoresEnt = AtoresRep.PreecheAtor(ator);

            dgvAtorFilmes.DataSource = ElencoFilmesRep.Consultar(atoresEnt.NOME_ATOR);
            dgvAtorSeries.DataSource = ElencoSeriesRep.Consultar(atoresEnt.NOME_ATOR);
            dgvAtorFilmes.Columns["ID_FILME"].Visible = false;
            dgvAtorSeries.Columns["ID_SERIE"].Visible = false;

            txtNOME_ATOR.Text = atoresEnt.NOME_ATOR;
            numIDADE.Value = atoresEnt.IDADE;
            txtPAIS.Text = atoresEnt.PAIS;
            ckbAPOSENTADO.Checked = atoresEnt.APOSENTADO;
        }
        /////////////////FIM EVENTO: dgvResultado_CellDoubleClick/////////////////
    }
}
