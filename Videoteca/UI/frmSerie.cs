using System.Data;
using Videoteca.Entidade;
using Videoteca.Repositorio;
using Videoteca.Dominio;

namespace Videoteca.UI
{
    public partial class FrmSerie : Form
    {
        Series seriesEnt = new();
        Atores atoresEnt = new();
        ElencoSeries elencoSeriesEnt = new();
        List<Atores> lstElencoSerie = new();
        List<string> lstElencoRegistrado = new();

        bool atualizar;

        public FrmSerie()
        {
            InitializeComponent();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            //Fonte de dados do ComboBox(DataTable)
            setup_cmbAtores();

            //Fonte de dados do ComboBox(Lista)
            cmbGENERO.DataSource = SerieDom.ListarGeneros(SeriesRep.Consultar());

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
            dgvElenco.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        /////////////////INICIO EVENTO: btnRegistro_Click/////////////////
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            SetupRegistro();

            string[] validacao = SerieDom.Validacao(seriesEnt);

            if (validacao[0].Equals("valido"))
            {
                if (atualizar)
                {
                    btnRegistro_AcaoClick_Atualizar();
                }
                else
                {
                    btnRegistro_AcaoClick_Cadastrar();
                }
                btnCancelar_Click(null, null);
            }
            else
            {
                ValidacaoMsg(validacao);
            }
        }

        private void SetupRegistro()
        {
            numTEMPORADA.ForeColor = Color.Black;
            numEPISODIO.ForeColor = Color.Black;
            cmbGENERO.ForeColor = Color.Black;

            seriesEnt.TITULO_SERIE = txtTITULO_SERIE.Text;
            seriesEnt.CAPITULO = txtCAPITULO.Text;
            seriesEnt.DESCRICAO = txtDESCRICAO.Text;
            seriesEnt.TEMPORADA = Convert.ToInt32(numTEMPORADA.Value);
            seriesEnt.EPISODIO = Convert.ToInt32(numEPISODIO.Value);
            seriesEnt.GENERO = cmbGENERO.Text;
            seriesEnt.PAIS = txtPAIS.Text;
            seriesEnt.ANO = Convert.ToInt32(numANO.Value);
            seriesEnt.DURACAO = Convert.ToInt32(numDURACAO.Value);
            seriesEnt.AVALIACAO = Convert.ToInt32(numAVALIACAO.Value);
            seriesEnt.ASSISTIDO = txtASSISTIDO.Checked;
        }

        private void btnRegistro_AcaoClick_Atualizar()
        {
            SeriesRep.Atualizar(seriesEnt);

            elencoSeriesEnt.ID_SERIE = seriesEnt.ID_SERIE;
            foreach (var ator in ElencoDom.LstAtoresRemover(lstElencoRegistrado, lstElencoSerie))
            {
                elencoSeriesEnt.NOME_ATOR = ator;
                ElencoSeriesRep.Excluir(elencoSeriesEnt);
            }

            foreach (var ator in ElencoDom.LstAtoresInserir(lstElencoRegistrado, lstElencoSerie))
            {
                elencoSeriesEnt.ID_ELENCO = 0;
                elencoSeriesEnt.NOME_ATOR = ator;
                ElencoSeriesRep.Cadastrar(elencoSeriesEnt);
            }
            MessageBox.Show("Serie Atualizada!");
        }

        private void btnRegistro_AcaoClick_Cadastrar()
        {
            seriesEnt.ID_SERIE = 0;

            SeriesRep.Cadastrar(seriesEnt);

            elencoSeriesEnt.ID_SERIE = SeriesRep.BuscarUltimoRegistro(seriesEnt).ID_SERIE;
            foreach (var item in lstElencoSerie)
            {
                elencoSeriesEnt.ID_ELENCO = 0;
                elencoSeriesEnt.NOME_ATOR = item.NOME_ATOR;
                ElencoSeriesRep.Cadastrar(elencoSeriesEnt);
            }
            MessageBox.Show("Série Cadastrada!");
        }

        private void ValidacaoMsg(string[] validacao)
        {
            string mensagem = "";

            foreach (string itemValidacao in validacao)
            {
                switch (itemValidacao)
                {
                    case "TITULO_SERIE":
                        txtTITULO_SERIE.PlaceholderText = "*Campo Obrigatório";
                        mensagem += "O Campo ''Título'' é obrigatório"
                            + Environment.NewLine + Environment.NewLine;
                        break;
                    case "TEMPORADA":
                        numTEMPORADA.ForeColor = Color.Red;
                        mensagem += "O Campo ''Temporada'' é obrigatório"
                            + Environment.NewLine + Environment.NewLine;
                        break;
                    case "EPISODIO":
                        numEPISODIO.ForeColor = Color.Red;
                        mensagem += "O Campo ''Episódio'' é obrigatório"
                            + Environment.NewLine + Environment.NewLine;
                        break;
                    case "GENERO":
                        cmbGENERO.ForeColor = Color.Red;
                        mensagem += "O Campo ''Gênero'' é obrigatório"
                            + Environment.NewLine + Environment.NewLine;
                        break;
                }
            }
            MessageBox.Show(mensagem);
        }
        /////////////////FIM EVENTO: btnRegistro_Click/////////////////

        /////////////////INICIO EVENTO: btnInserirAtorElenco_Click/////////////////
        private void btnInserirAtorElenco_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            string cmbAtorInsert = cmbAtores.Text;

            if (btnInserir.Text.Equals("Registrar"))
            {
                resposta = MessageBox.Show("Ator não registrado, Deseja registrar?",
                                    "Confirmação",
                                    MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question,
                                    MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    atoresEnt.NOME_ATOR = cmbAtorInsert;
                    AtoresRep.Cadastrar(atoresEnt);
                    MessageBox.Show("Ator Cadastrado!");

                    lstElencoSerie.Add(new Atores() { NOME_ATOR = cmbAtorInsert });
                    setup_cmbAtores();
                    cmbAtores.Text = cmbAtorInsert;

                    btnInserir.Text = "Remover";
                }
            }
            else
            {
                if (verificarAtorInserido(cmbAtorInsert))
                {
                    lstElencoSerie.RemoveAt(lstElencoFilme_getIndex(cmbAtorInsert));
                    btnInserir.Text = "Inserir";
                }
                else
                {
                    lstElencoSerie.Add(new Atores() { NOME_ATOR = cmbAtorInsert });
                    btnInserir.Text = "Remover";
                }
            }
            setup_dgvElenco();
        }

        private void setup_cmbAtores()
        {
            //Fonte de dados do ComboBox(DataTable)
            cmbAtores.DataSource = AtoresRep.Consultar();
            //Configurar qual coluna sera utilizada para os valores
            cmbAtores.ValueMember = "NOME_ATOR";
            //Configurar qual coluna sera utilizada para exibiçao
            cmbAtores.DisplayMember = "NOME_ATOR";
        }

        private bool verificarAtorInserido(string ator)
        {
            bool contido = false;
            foreach (Atores item in lstElencoSerie)
            {
                if (item.NOME_ATOR.Equals(ator))
                {
                    contido = true;
                    break;
                }
            }
            return contido;
        }

        private int lstElencoFilme_getIndex(string ator)
        {
            int index = 0;
            foreach (var a in lstElencoSerie)
            {
                if (a.NOME_ATOR.Equals(ator))
                {
                    break;
                }
                index++;
            }
            return index;
        }

        private void setup_dgvElenco()
        {
            List<Atores> fonte = new(lstElencoSerie);
            dgvElenco.DataSource = fonte;
            dgvElenco.Columns["IDADE"].Visible = false;
            dgvElenco.Columns["PAIS"].Visible = false;
            dgvElenco.Columns["APOSENTADO"].Visible = false;
        }
        /////////////////FIM EVENTO: btnInserirAtorElenco_Click/////////////////

        /////////////////INICIO EVENTO: dgvElenco_CellDoubleClick/////////////////
        private void dgvElenco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ator = dgvElenco.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
            FrmAtor visualizacao = new();
            visualizacao.MdiParent = FrmMain.ActiveForm;
            visualizacao.Show();
            visualizacao.PreencherRegistroAtor(ator);
        }
        /////////////////FIM EVENTO: dgvElenco_CellDoubleClick/////////////////

        /////////////////INICIO EVENTOS: cmbAtores/////////////////
        private void cmbAtores_SelectedIndexChanged(object sender, EventArgs e)
        {
            StatusTexto_btnInserir(false);
        }

        private void cmbAtores_TextChanged(object sender, EventArgs e)
        {
            bool registrar = true;

            foreach (var cmbItem in cmbAtores.Items)
            {
                if (cmbAtores.Text.Equals(cmbAtores.GetItemText(cmbItem)))
                {
                    registrar = false;
                }
            }

            StatusTexto_btnInserir(registrar);

            txtASSISTIDO.Checked = registrar;
        }

        private void StatusTexto_btnInserir(bool registrar)
        {
            if (registrar)
            {
                btnInserir.Text = "Registrar";
            }
            else
            {
                if (verificarAtorInserido(cmbAtores.Text))
                {
                    btnInserir.Text = "Remover";
                }
                else
                {
                    btnInserir.Text = "Inserir";
                }
            }
        }
        /////////////////FIM EVENTOS: cmbAtores/////////////////

        /////////////////INICIO EVENTO: btnCancelar_Click/////////////////
        private void btnCancelar_Click(object? sender, EventArgs? e)
        {
            btnCadastrar.Text = "Cadastrar";
            atualizar = false;
            btnCancelar.Visible = false;

            groupBox1.Text = "Registro de Série";
            txtTITULO_SERIE.Clear();
            txtCAPITULO.Clear();
            txtDESCRICAO.Clear();
            numTEMPORADA.Value = 0;
            numEPISODIO.Value = 0;
            cmbGENERO.DataSource = SerieDom.ListarGeneros(SeriesRep.Consultar());
            txtPAIS.Clear();
            numANO.Value = 0;
            numDURACAO.Value = 0;
            numAVALIACAO.Value = 0;
            txtASSISTIDO.Checked = false;
            dgvElenco.DataSource = new List<Atores>();
            lstElencoSerie.Clear();
            lstElencoRegistrado.Clear();
            StatusTexto_btnInserir(false);

            txtTITULO_SERIE.Focus();
        }
        /////////////////FIM EVENTO: btnCancelar_Click/////////////////
        
        /////////////////INICIO EVENTO: tabControl1_Selected/////////////////
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                dgvResultado.DataSource = SeriesRep.Consultar();

                cmbFiltroGenero.DataSource = SerieDom.ListarGeneros(SeriesRep.Consultar());
            }
        }
        /////////////////FIM EVENTO: tabControl1_Selected/////////////////

        /////////////////INICIO EVENTO: txtFiltro_TextChanged/////////////////
        private void txtFiltro_TextChanged(object? sender, EventArgs? e)
        {
            cmbFiltroGenero.SelectedIndex = 0;
            dgvResultado.DataSource = SeriesRep.FiltrarTitulo(txtFiltro.Text);
        }
        /////////////////FIM EVENTO: txtFiltro_TextChanged/////////////////

        /////////////////INICIO EVENTO: cmbGeneros_SelectedIndexChanged/////////////////
        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroGenero.SelectedIndex > 0)
            {
                dgvResultado.DataSource = SeriesRep.FiltrarGenero(cmbFiltroGenero.Text);
            }
            else
            {
                dgvResultado.DataSource = SeriesRep.Consultar();
            }
        }
        /////////////////FIM EVENTO: cmbGeneros_SelectedIndexChanged/////////////////

        /////////////////INICIO EVENTO: btnExcluir_Click/////////////////
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta;

            if (dgvResultado.SelectedRows.Count > 0)
            {
                resposta = MessageBox.Show("Deseja realmente excluir?",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                if (resposta == DialogResult.Yes)
                {
                    seriesEnt.ID_SERIE = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_SERIE"].Value);
                    SeriesRep.Excluir(seriesEnt);
                    txtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }
        /////////////////FIM EVENTO: btnExcluir_Click/////////////////

        /////////////////INICIO EVENTO: dgvResultado_CellDoubleClick/////////////////
        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_serie = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_SERIE"].Value);
            PreencherRegistroSerie(id_serie);

            tabControl1.SelectTab(0);
        }

        public void PreencherRegistroSerie(int id_serie)
        {
            groupBox1.Text = "Atualização de Série";
            atualizar = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "Atualizar";
            
            seriesEnt = SeriesRep.PreecheSerie(id_serie);
            
            txtTITULO_SERIE.Text = seriesEnt.TITULO_SERIE;
            txtCAPITULO.Text = seriesEnt.CAPITULO;
            txtDESCRICAO.Text = seriesEnt.DESCRICAO;
            numTEMPORADA.Value = seriesEnt.TEMPORADA;
            numEPISODIO.Value = seriesEnt.EPISODIO;
            cmbGENERO.Text = seriesEnt.GENERO;
            txtPAIS.Text = seriesEnt.PAIS;
            numANO.Value = seriesEnt.ANO;
            numDURACAO.Value = seriesEnt.DURACAO;
            numAVALIACAO.Value = seriesEnt.AVALIACAO;
            txtASSISTIDO.Checked = Convert.ToBoolean(seriesEnt.ASSISTIDO);

            lstElencoSerie.Clear();
            lstElencoRegistrado.Clear();

            foreach (var elencoSerie in ElencoSeriesRep.Consultar(Convert.ToInt16(seriesEnt.ID_SERIE)))
            {
                lstElencoSerie.Add(new Atores() { NOME_ATOR = elencoSerie.NOME_ATOR });
                lstElencoRegistrado.Add(elencoSerie.NOME_ATOR);
            }
            setup_dgvElenco();
            StatusTexto_btnInserir(false);
        }
        /////////////////FIM EVENTO: dgvResultado_CellDoubleClick/////////////////

        /////////////////INICIO EVENTO: dgvElenco_CellClick/////////////////
        private void dgvElenco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string nome_ator = dgvElenco.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? String.Empty;
            cmbAtores.Text = nome_ator;
        }
        /////////////////FIM EVENTO: dgvElenco_CellClick/////////////////
    }
}
