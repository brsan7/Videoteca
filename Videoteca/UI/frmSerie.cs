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
        List<string> lstElenco = new List<string>();
        List<string> lstElencoRegistrado = new List<string>();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            serieBLL.TITULO_SERIE = txtTITULO_SERIE.Text;
            serieBLL.CAPITULO = txtCAPITULO.Text;
            serieBLL.DESCRICAO = txtDESCRICAO.Text;
            serieBLL.TEMPORADA = int.Parse(txtTEMPORADA.Text);
            serieBLL.EPISODIO = int.Parse(txtEPISODIO.Text);
            serieBLL.GENERO = cmbGENERO.Text;
            serieBLL.PAIS = txtPAIS.Text;
            serieBLL.ANO = int.Parse(txtANO.Text);
            serieBLL.DURACAO = float.Parse(txtDURACAO.Text);
            serieBLL.AVALIACAO = float.Parse(txtAVALIACAO.Text);
            serieBLL.ASSISTIDO = txtASSISTIDO.Checked;

            if (atualizar)
            {
                serieDAL.Atualizar(serieBLL);

                elencoSerieBLL.ID_SERIE = serieBLL.ID_SERIE;
                foreach (var ator in elencoSerieBLL.lstAtoresInserir(lstElencoRegistrado, lstElenco))
                {
                    elencoSerieBLL.NOME_ATOR = ator;
                    elencoSerieDAL.Cadastrar(elencoSerieBLL);
                }

                foreach (var ator in elencoSerieBLL.lstAtoresRemover(lstElencoRegistrado, lstElenco))
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
                foreach (var ator in lstElenco)
                {
                    elencoSerieBLL.NOME_ATOR = ator;
                    elencoSerieDAL.Cadastrar(elencoSerieBLL);
                }
                

                MessageBox.Show("Série Cadastrada!");
            }

            groupBox1.Text = "Registro de Serie";
            txtTITULO_SERIE.Clear();
            txtCAPITULO.Clear();
            txtDESCRICAO.Clear();
            txtTEMPORADA.Clear();
            txtEPISODIO.Clear();
            cmbGENERO.DataSource = serieDAL.listarGeneros(serieDAL.Consultar());
            txtPAIS.Clear();
            txtANO.Clear();
            txtDURACAO.Clear();
            txtAVALIACAO.Clear();
            txtASSISTIDO.Checked = false;
            txtELENCO.Clear();
            lstElenco.Clear();
            lstElencoRegistrado.Clear();

            txtTITULO_SERIE.Focus();
        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            //Fonte de dados do ComboBox(DataTable)
            AtorDAL atoresDAL = new AtorDAL();
            cmbAtores.DataSource = atoresDAL.Consultar();
            //Fonte de dados do ComboBox(Lista)
            cmbGENERO.DataSource = serieDAL.listarGeneros(serieDAL.Consultar());

            //Configurar qual coluna sera utilizada para os valores
            cmbAtores.ValueMember = "NOME_ATOR";

            //Configurar qual coluna sera utilizada para exibiçao
            cmbAtores.DisplayMember = "NOME_ATOR";

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
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
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
            int id_serie = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_SERIE"].Value.ToString());
            PreencherRegistro(id_serie);

            tabControl1.SelectTab(0);
        }

        public void PreencherRegistro(int id_serie)
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
            txtTEMPORADA.Text = serieBLL.TEMPORADA.ToString();
            txtEPISODIO.Text = serieBLL.EPISODIO.ToString();
            cmbGENERO.Text = serieBLL.GENERO;
            txtPAIS.Text = serieBLL.PAIS;
            txtANO.Text = serieBLL.ANO.ToString();
            txtDURACAO.Text = serieBLL.DURACAO.ToString();
            txtAVALIACAO.Text = serieBLL.AVALIACAO.ToString();
            txtASSISTIDO.Checked = Convert.ToBoolean(serieBLL.ASSISTIDO);

            txtELENCO.Clear();
            lstElenco.Clear();
            lstElencoRegistrado.Clear();

            foreach (var ator in elencoSerieDAL.Consultar(Convert.ToInt16(serieBLL.ID_SERIE)))
            {
                txtELENCO.Text += ator + Environment.NewLine;
                lstElenco.Add(ator);
                lstElencoRegistrado.Add(ator);
            }
            btnInserir_statusTexto(false);
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
            txtTEMPORADA.Clear();
            txtEPISODIO.Clear();
            cmbGENERO.SelectedIndex = 0;
            txtPAIS.Clear();
            txtANO.Clear();
            txtDURACAO.Clear();
            txtAVALIACAO.Clear();
            txtASSISTIDO.Checked = false;
            txtELENCO.Clear();
            lstElenco.Clear();
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

                    lstElenco.Add(cmbAtorInsert);
                    txtELENCO.Text += cmbAtorInsert + Environment.NewLine;

                    btnInserir.Text = "Remover";
                }
            }
            else
            {
                if (lstElenco.Contains(cmbAtorInsert))
                {
                    lstElenco.Remove(cmbAtores.Text);
                    txtELENCO.Clear();

                    foreach (var ator in lstElenco)
                    {
                        txtELENCO.Text += ator + Environment.NewLine;
                    }
                    btnInserir.Text = "Inserir";
                }
                else
                {
                    lstElenco.Add(cmbAtorInsert);
                    txtELENCO.Text += cmbAtorInsert + Environment.NewLine;
                    btnInserir.Text = "Remover";
                }
            }
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
                if (lstElenco.Contains(cmbAtores.Text))
                {
                    btnInserir.Text = "Remover";
                }
                else
                {
                    btnInserir.Text = "Inserir";
                }
            }
        }
    }
}
