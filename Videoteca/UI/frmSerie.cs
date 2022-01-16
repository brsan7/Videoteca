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
    public partial class frmSerie : Form
    {
        public frmSerie()
        {
            InitializeComponent();
        }

        SerieBLL serieBLL = new SerieBLL();
        SerieDAL serieDAL = new SerieDAL();
        AtorBLL atorBLL = new AtorBLL();
        AtorDAL atorDAL = new AtorDAL();
        ElencoSerieBLL elencoSerieBLL = new ElencoSerieBLL();
        ElencoSerieDAL elencoSerieDAL = new ElencoSerieDAL();
        List<AtorBLL> lstElencoSerie = new List<AtorBLL>();
        List<string> lstElencoRegistrado = new List<string>();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            serieBLL.TITULO_SERIE = txtTITULO_SERIE.Text;
            serieBLL.CAPITULO = txtCAPITULO.Text;
            serieBLL.DESCRICAO = txtDESCRICAO.Text;
            serieBLL.TEMPORADA = Convert.ToInt32(numTEMPORADA.Value);
            serieBLL.EPISODIO = Convert.ToInt32(numEPISODIO.Value);
            serieBLL.GENERO = cmbGENERO.Text;
            serieBLL.PAIS = txtPAIS.Text;
            serieBLL.ANO = Convert.ToInt32(numANO.Value);
            serieBLL.DURACAO = Convert.ToInt32(numDURACAO.Value);
            serieBLL.AVALIACAO = Convert.ToInt32(numAVALIACAO.Value);
            serieBLL.ASSISTIDO = txtASSISTIDO.Checked;

            if (atualizar)
            {
                serieDAL.Atualizar(serieBLL);

                elencoSerieBLL.ID_SERIE = serieBLL.ID_SERIE;
                foreach (var ator in elencoSerieBLL.lstAtoresInserir(lstElencoRegistrado, lstElencoSerie))
                {
                    elencoSerieBLL.NOME_ATOR = ator;
                    elencoSerieDAL.Cadastrar(elencoSerieBLL);
                }

                foreach (var ator in elencoSerieBLL.lstAtoresRemover(lstElencoRegistrado, lstElencoSerie))
                {
                    elencoSerieBLL.NOME_ATOR = ator;
                    elencoSerieDAL.Excluir(elencoSerieBLL);
                }

                MessageBox.Show("Serie Atualizada!");
                btnCadastrar.Text = "Cadastrar";
                atualizar = false;
                txtPAIS.ReadOnly = false;
                btnCancelar.Visible = false;
            }

            else
            {
                serieDAL.Cadastrar(serieBLL);

                elencoSerieBLL.ID_SERIE = serieDAL.BuscarUltimoRegistro(serieBLL).ID_SERIE;
                foreach (var item in lstElencoSerie)
                {
                    elencoSerieBLL.NOME_ATOR = item.NOME_ATOR;
                    elencoSerieDAL.Cadastrar(elencoSerieBLL);
                }
                

                MessageBox.Show("Série Cadastrada!");
            }

            groupBox1.Text = "Registro de Serie";
            txtTITULO_SERIE.Clear();
            txtCAPITULO.Clear();
            txtDESCRICAO.Clear();
            numTEMPORADA.Value = 0;
            numEPISODIO.Value = 0;
            cmbGENERO.DataSource = serieDAL.listarGeneros(serieDAL.Consultar());
            txtPAIS.Clear();
            numANO.Value = 0;
            numDURACAO.Value = 0;
            numAVALIACAO.Value = 0;
            txtASSISTIDO.Checked = false;
            lstElencoSerie.Clear();
            lstElencoRegistrado.Clear();
            dgvElenco.DataSource = null;

            txtTITULO_SERIE.Focus();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            //Fonte de dados do ComboBox(DataTable)
            setup_cmbAtores();

            //Fonte de dados do ComboBox(Lista)
            cmbGENERO.DataSource = serieDAL.listarGeneros(serieDAL.Consultar());

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

        private void txtFiltro_TextChanged(object? sender, EventArgs? e)
        {
            cmbFiltroGenero.SelectedIndex = 0;
            serieBLL.TITULO_SERIE = txtFiltro.Text;
            dgvResultado.DataSource = serieDAL.Consultar(serieBLL);
        }

        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroGenero.SelectedIndex > 0)
            {
                dgvResultado.DataSource = serieDAL.Consultar(cmbFiltroGenero.Text);
            }
            else
            {
                dgvResultado.DataSource = serieDAL.Consultar();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) 
            {
                DataTable fonte = new DataTable();
                fonte = serieDAL.Consultar();

                dgvResultado.DataSource = fonte;

                cmbFiltroGenero.DataSource = serieDAL.listarGeneros(fonte);
            }
        }

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
                    serieBLL.ID_SERIE = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_SERIE"].Value);
                    elencoSerieDAL.Excluir(serieBLL.ID_SERIE);
                    serieDAL.Excluir(serieBLL);
                    txtFiltro_TextChanged(null, null);
                }
            }
            else
            {
                MessageBox.Show("Selecione um registro");
            }
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id_serie = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_SERIE"].Value);
            preencherRegistroSerie(id_serie);

            tabControl1.SelectTab(0);
        }

        public void preencherRegistroSerie(int id_serie)
        {
            groupBox1.Text = "Atualização de Série";
            atualizar = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "Atualizar";
            
            serieBLL.ID_SERIE = id_serie;
            serieBLL = serieDAL.PreecheSerie(serieBLL);
            
            txtTITULO_SERIE.Text = serieBLL.TITULO_SERIE;
            txtCAPITULO.Text = serieBLL.CAPITULO;
            txtDESCRICAO.Text = serieBLL.DESCRICAO;
            numTEMPORADA.Value = serieBLL.TEMPORADA;
            numEPISODIO.Value = serieBLL.EPISODIO;
            cmbGENERO.Text = serieBLL.GENERO;
            txtPAIS.Text = serieBLL.PAIS;
            numANO.Value = serieBLL.ANO;
            numDURACAO.Value = serieBLL.DURACAO;
            numAVALIACAO.Value = serieBLL.AVALIACAO;
            txtASSISTIDO.Checked = Convert.ToBoolean(serieBLL.ASSISTIDO);

            lstElencoSerie.Clear();
            lstElencoRegistrado.Clear();

            foreach (var ator in elencoSerieDAL.Consultar(Convert.ToInt16(serieBLL.ID_SERIE)))
            {
                lstElencoSerie.Add(new AtorBLL() { NOME_ATOR = ator });
                lstElencoRegistrado.Add(ator);
            }
            setup_dgvElenco();
            btnInserir_statusTexto(false);
        }

        private void dgvElenco_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string ator = dgvElenco.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString() ?? "";
            frmAtor visualizacao = new frmAtor();
            visualizacao.MdiParent = frmMenu.ActiveForm;
            visualizacao.Show();
            visualizacao.preencherRegistroAtor(ator);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            atualizar = false;
            btnCancelar.Visible = false;
            txtPAIS.ReadOnly = false;

            groupBox1.Text = "Registro de Série";
            txtTITULO_SERIE.Clear();
            txtCAPITULO.Clear();
            txtDESCRICAO.Clear();
            numTEMPORADA.Value = 0;
            numEPISODIO.Value = 0;
            cmbGENERO.SelectedIndex = 0;
            txtPAIS.Clear();
            numANO.Value = 0;
            numDURACAO.Value = 0;
            numAVALIACAO.Value = 0;
            txtASSISTIDO.Checked = false;
            dgvElenco.DataSource = null;
            lstElencoSerie.Clear();
            lstElencoRegistrado.Clear();
            btnInserir_statusTexto(false);

            txtTITULO_SERIE.Focus();
        }

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
                    atorBLL.NOME_ATOR = cmbAtorInsert;
                    atorDAL.Cadastrar(atorBLL);
                    MessageBox.Show("Ator Cadastrado!");

                    lstElencoSerie.Add(new AtorBLL() { NOME_ATOR = cmbAtorInsert });
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
                    lstElencoSerie.Add(new AtorBLL() { NOME_ATOR = cmbAtorInsert });
                    btnInserir.Text = "Remover";
                }
            }
            setup_dgvElenco();
        }

        private void cmbAtores_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInserir_statusTexto(false);
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

            btnInserir_statusTexto(registrar);

            txtASSISTIDO.Checked = registrar;
        }

        private void btnInserir_statusTexto(bool registrar)
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

        private void setup_cmbAtores()
        {
            AtorDAL atoresDAL = new AtorDAL();

            //Fonte de dados do ComboBox(DataTable)
            cmbAtores.DataSource = atoresDAL.Consultar();
            //Configurar qual coluna sera utilizada para os valores
            cmbAtores.ValueMember = "NOME_ATOR";
            //Configurar qual coluna sera utilizada para exibiçao
            cmbAtores.DisplayMember = "NOME_ATOR";
        }

        private void setup_dgvElenco()
        {
            dgvElenco.DataSource = null;
            dgvElenco.DataSource = lstElencoSerie;
            dgvElenco.Columns["IDADE"].Visible = false;
            dgvElenco.Columns["PAIS"].Visible = false;
            dgvElenco.Columns["APOSENTADO"].Visible = false;
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

        private bool verificarAtorInserido(string ator)
        {
            bool contido = false;
            foreach (AtorBLL item in lstElencoSerie)
            {
                if (item.NOME_ATOR.Equals(ator))
                {
                    contido = true;
                    break;
                }
            }
            return contido;
        }
    }
}
