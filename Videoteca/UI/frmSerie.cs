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
        ElencoSerieBLL elencoSerieBLL = new ElencoSerieBLL();
        ElencoSerieDAL elencoSerieDAL = new ElencoSerieDAL();
        List<string> lstElenco = new List<string>();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            serieBLL.TITULO_SERIE = txtTITULO_SERIE.Text;
            serieBLL.DESCRICAO = txtDESCRICAO.Text;
            serieBLL.GENERO = txtGENERO.Text;
            serieBLL.PAIS = txtPAIS.Text;
            serieBLL.ANO = int.Parse(txtANO.Text);
            serieBLL.DURACAO = float.Parse(txtDURACAO.Text);
            serieBLL.AVALIACAO = float.Parse(txtAVALIACAO.Text);
            serieBLL.ASSISTIDO = txtASSISTIDO.Checked;

            if (atualizar)
            {
                serieDAL.Atualizar(serieBLL);
                /////////////////ATUALIZAR ELENCO
                MessageBox.Show("Serie cadastrado!");
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
                

                MessageBox.Show("Série cadastrado!");
            }

            txtTITULO_SERIE.Clear();
            txtDESCRICAO.Clear();
            txtGENERO.Clear();
            txtPAIS.Clear();
            txtANO.Clear();
            txtDURACAO.Clear();
            txtAVALIACAO.Clear();
            txtASSISTIDO.Checked = false;
            txtELENCO.Clear();


            txtTITULO_SERIE.Focus();

        }

        private void frmSerie_Load(object sender, EventArgs e)
        {
            //Fonte de dados do ComboBox
            AtoresDAL atoresDAL = new AtoresDAL();
            cmbAtores.DataSource = atoresDAL.Consultar();

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
            serieBLL.TITULO_SERIE = txtFiltro.Text;
            dgvResultado.DataSource = serieDAL.Consultar(serieBLL);
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) 
            {

                dgvResultado.DataSource = serieDAL.Consultar();
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
            atualizar = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "Atualizar";

            serieBLL.ID_SERIE = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_SERIE"].Value.ToString());

            serieBLL = serieDAL.PreecheSerie(serieBLL);

            txtTITULO_SERIE.Text = serieBLL.TITULO_SERIE;
            txtDESCRICAO.Text = serieBLL.DESCRICAO;
            txtGENERO.Text = serieBLL.GENERO;
            txtPAIS.Text = serieBLL.PAIS;
            txtANO.Text = serieBLL.ANO.ToString();
            txtDURACAO.Text = serieBLL.DURACAO.ToString();
            txtAVALIACAO.Text = serieBLL.AVALIACAO.ToString();
            txtASSISTIDO.Checked = Convert.ToBoolean(serieBLL.ASSISTIDO);

            foreach (var ator in elencoSerieDAL.Consultar(Convert.ToInt16(serieBLL.ID_SERIE)))
            {
                txtELENCO.Text += ator +Environment.NewLine;
            }

            tabControl1.SelectTab(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            atualizar = false;
            btnCancelar.Visible = false;
            txtPAIS.ReadOnly = false;

            txtTITULO_SERIE.Clear();
            txtDESCRICAO.Clear();
            txtGENERO.Clear();
            txtPAIS.Clear();
            txtANO.Clear();
            txtDURACAO.Clear();
            txtAVALIACAO.Clear();
            txtASSISTIDO.Checked = false;

            txtTITULO_SERIE.Focus();
        }

        private void btnInserirAtorElenco_Click(object sender, EventArgs e)
        {
            DialogResult resposta;
            string cmbAtorInsert = cmbAtores.Text;
            
            if (btnInserir.Text.Equals("Remover") && verificarAtor(cmbAtorInsert))
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
                if (!lstElenco.Contains(cmbAtorInsert) && verificarAtor(cmbAtorInsert))
                {
                    lstElenco.Add(cmbAtorInsert);
                    txtELENCO.Text += cmbAtorInsert + Environment.NewLine;
                    btnInserir.Text = "Remover";
                }
                else
                {
                    if (!verificarAtor(cmbAtorInsert))
                    {
                        resposta = MessageBox.Show("Ator não registrado, Deseja registrar?",
                                            "Confirmação",
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question,
                                            MessageBoxDefaultButton.Button2);
                        if (resposta == DialogResult.Yes)
                        {
                            lstElenco.Add(cmbAtorInsert);
                            txtELENCO.Text += cmbAtorInsert + Environment.NewLine;
                            btnInserir.Text = "Remover";
                        }
                    }
                }
            }
        }

        private void cmbAtores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstElenco.Count > 0)
            {
                btnInserir.Text = "Inserir";
                foreach (var ator in lstElenco)
                {
                    if (cmbAtores.Text.Equals(ator))
                    {
                        btnInserir.Text = "Remover";
                        break;
                    }
                }
            }

        }

        private bool verificarAtor(string ator)
        {
            foreach (var cmbItem in cmbAtores.Items)
            {
                if (ator.Equals(cmbAtores.GetItemText(cmbItem)))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
