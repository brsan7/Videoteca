using Videoteca.Entidade;
using Videoteca.Repositorio;
using Videoteca.Dominio;

namespace Videoteca.UI
{
    public partial class FrmFilme : Form
    {
        Filmes filmesEnt = new();
        Atores atoresEnt = new();
        ElencoFilmes elencoFilmesEnt = new();
        List<Atores> lstElencoFilme = new();
        List<string> lstElencoRegistrado = new();

        bool atualizar;

        public FrmFilme()
        {
            InitializeComponent();
        }

        private void frmFilme_Load(object sender, EventArgs e)
        {
            //Fonte de dados do ComboBox(DataTable)
            setup_cmbAtores();

            //Fonte de dados do ComboBox(Lista)
            cmbGENERO.DataSource = FilmeDom.ListarGeneros(FilmesRep.Consultar());

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

            string[] validacao = FilmeDom.Validacao(filmesEnt);

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

                btnCancelar_Click(null,null);
            }
            else
            {
                ValidacaoMsg(validacao);
            }
        }

        private void SetupRegistro()
        {
            cmbGENERO.ForeColor = Color.Black;

            filmesEnt.TITULO_FILME = txtTITULO_FILME.Text;
            filmesEnt.DESCRICAO = txtDESCRICAO.Text;
            filmesEnt.GENERO = cmbGENERO.Text;
            filmesEnt.PAIS = txtPAIS.Text;
            filmesEnt.ANO = Convert.ToInt32(numANO.Value);
            filmesEnt.DURACAO = Convert.ToInt32(numDURACAO.Value);
            filmesEnt.AVALIACAO = Convert.ToInt32(numAVALIACAO.Value);
            filmesEnt.ASSISTIDO = txtASSISTIDO.Checked;
        }

        private void btnRegistro_AcaoClick_Atualizar()
        {
            FilmesRep.Atualizar(filmesEnt);

            elencoFilmesEnt.ID_FILME = filmesEnt.ID_FILME;
            foreach (var ator in ElencoDom.LstAtoresRemover(lstElencoRegistrado, lstElencoFilme))
            {
                elencoFilmesEnt.NOME_ATOR = ator;
                ElencoFilmesRep.Excluir(elencoFilmesEnt);
            }

            foreach (var ator in ElencoDom.LstAtoresInserir(lstElencoRegistrado, lstElencoFilme))
            {
                elencoFilmesEnt.ID_ELENCO = 0;
                elencoFilmesEnt.NOME_ATOR = ator;
                ElencoFilmesRep.Cadastrar(elencoFilmesEnt);
            }

            MessageBox.Show("Filme Atualizado!");
        }

        private void btnRegistro_AcaoClick_Cadastrar()
        {
            filmesEnt.ID_FILME = 0;

            FilmesRep.Cadastrar(filmesEnt);

            elencoFilmesEnt.ID_FILME = FilmesRep.BuscarUltimoRegistro(filmesEnt).ID_FILME;
            foreach (var item in lstElencoFilme)
            {
                elencoFilmesEnt.ID_ELENCO = 0;
                elencoFilmesEnt.NOME_ATOR = item.NOME_ATOR;
                ElencoFilmesRep.Cadastrar(elencoFilmesEnt);
            }
            MessageBox.Show("Filme Cadastrado!");
        }

        private void ValidacaoMsg(string[] validacao)
        {
            string mensagem = "";

            foreach (string itemValidacao in validacao)
            {
                switch (itemValidacao)
                {
                    case "TITULO_FILME":
                        txtTITULO_FILME.PlaceholderText = "*Campo Obrigatório";
                        mensagem += "O Campo ''Título'' é obrigatório"
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

                    lstElencoFilme.Add(new Atores() { NOME_ATOR = cmbAtorInsert });
                    setup_cmbAtores();
                    cmbAtores.Text = cmbAtorInsert;

                    btnInserir.Text = "Remover";
                }
            }
            else
            {
                if (verificarAtorInserido(cmbAtorInsert))
                {
                    lstElencoFilme.RemoveAt(lstElencoFilme_getIndex(cmbAtorInsert));
                    btnInserir.Text = "Inserir";
                }
                else
                {
                    lstElencoFilme.Add(new Atores() { NOME_ATOR = cmbAtorInsert });
                    btnInserir.Text = "Remover";
                }
            }
            setup_dgvElenco();
        }

        private void setup_cmbAtores()
        {
            AtoresRep atoresDAL = new();

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
            foreach (Atores item in lstElencoFilme)
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
            foreach (var a in lstElencoFilme)
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
            dgvElenco.DataSource = null;
            dgvElenco.DataSource = lstElencoFilme;
            dgvElenco.Columns["IDADE"].Visible = false;
            dgvElenco.Columns["PAIS"].Visible = false;
            dgvElenco.Columns["APOSENTADO"].Visible = false;
        }
        /////////////////FIM EVENTO: btnInserirAtorElenco_Click/////////////////

        /////////////////INICIO EVENTO: dgvElenco_CellDoubleClick/////////////////
        private void dgvElenco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ator = dgvElenco.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
            txtDESCRICAO.Text = ator;

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
            groupBox1.Text = "Registro de Filme";
            btnInserir.Text = "Inserir";
            btnCadastrar.Text = "Cadastrar";
            atualizar = false;
            btnCancelar.Visible = false;
            txtPAIS.ReadOnly = false;

            txtTITULO_FILME.Clear();
            txtDESCRICAO.Clear();
            cmbGENERO.DataSource = FilmeDom.ListarGeneros(FilmesRep.Consultar());
            txtPAIS.Clear();
            numANO.Value = 0;
            numDURACAO.Value = 0;
            numAVALIACAO.Value = 0;
            txtASSISTIDO.Checked = false;
            dgvElenco.DataSource = null;
            lstElencoFilme.Clear();
            lstElencoRegistrado.Clear();

            txtTITULO_FILME.Focus();
        }
        /////////////////FIM EVENTO: btnCancelar_Click/////////////////

        /////////////////INICIO EVENTO: tabControl1_Selected/////////////////
        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1)
            {
                dgvResultado.DataSource = FilmesRep.Consultar();

                cmbFiltroGenero.DataSource = FilmeDom.ListarGeneros(FilmesRep.Consultar());
            }
        }
        /////////////////FIM EVENTO: tabControl1_Selected/////////////////

        /////////////////INICIO EVENTO: txtFiltro_TextChanged/////////////////
        private void txtFiltro_TextChanged(object? sender, EventArgs? e)
        {
            cmbFiltroGenero.SelectedIndex = 0;
            dgvResultado.DataSource = FilmesRep.FiltrarTitulo(txtFiltro.Text);
        }
        /////////////////FIM EVENTO: txtFiltro_TextChanged/////////////////

        /////////////////INICIO EVENTO: cmbGeneros_SelectedIndexChanged/////////////////
        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroGenero.SelectedIndex > 0)
            {
                dgvResultado.DataSource = FilmesRep.FiltrarGenero(cmbFiltroGenero.Text);
            }
            else
            {
                dgvResultado.DataSource = FilmesRep.Consultar();
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
                    filmesEnt.ID_FILME = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_FILME"].Value);
                    FilmesRep.Excluir(filmesEnt);
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
            int id_filme = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_FILME"].Value);
            PreencherRegistroFilme(id_filme);

            tabControl1.SelectTab(0);
        }

        public void PreencherRegistroFilme(int id_filme)
        {
            atualizar = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "Atualizar";
            groupBox1.Text = "Atualização de Filme";
            
            filmesEnt = FilmesRep.PreecheFilme(id_filme);
            
            txtTITULO_FILME.Text = filmesEnt.TITULO_FILME;
            txtDESCRICAO.Text = filmesEnt.DESCRICAO;
            cmbGENERO.Text = filmesEnt.GENERO;
            txtPAIS.Text = filmesEnt.PAIS;
            numANO.Value = filmesEnt.ANO;
            numDURACAO.Value = filmesEnt.DURACAO;
            numAVALIACAO.Value = filmesEnt.AVALIACAO;
            txtASSISTIDO.Checked = Convert.ToBoolean(filmesEnt.ASSISTIDO);

            lstElencoFilme.Clear();
            lstElencoRegistrado.Clear();

            foreach (var elencoFilme in ElencoFilmesRep.Consultar(Convert.ToInt16(filmesEnt.ID_FILME)))
            {
                lstElencoFilme.Add(new Atores() { NOME_ATOR = elencoFilme.NOME_ATOR });
                lstElencoRegistrado.Add(elencoFilme.NOME_ATOR);
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
        ///////////////FIM EVENTO: dgvElenco_CellClick/////////////////
    }
}
