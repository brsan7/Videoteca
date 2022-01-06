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

        AtorBLL ator = new AtorBLL();
        AtoresDAL atorDAL = new AtoresDAL();
        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            //Preencher o objeto da BLL com o conteudo da UI.
            ator.NOME_ATOR = txtNOME_ATOR.Text;
            ator.IDADE = Convert.ToInt16(txtIDADE.Text);
            ator.PAIS = txtPAIS.Text;
            ator.ATIVO = Convert.ToInt16(txtATIVO.Text);

            if (atualizar)
            {
                atorDAL.Atualizar(ator);
                MessageBox.Show("Ator cadastrado!");
                btnCadastrar.Text = "Cadastrar";
                atualizar = false;
                txtNOME_ATOR.ReadOnly = false;
                btnCancelar.Visible = false;
            }

            else
            {
                //Enviar para o Cadastrar da camada DAL
                atorDAL.Cadastrar(ator);
                MessageBox.Show("Ator cadastrado!");

            }

            
            txtNOME_ATOR.Clear();
            txtIDADE.Clear();
            txtPAIS.Clear();
            txtATIVO.Clear();
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

            atualizar = false;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            ator.NOME_ATOR = txtFiltro.Text;
            dgvResultado.DataSource = atorDAL.Consultar(ator);
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
                    ator.NOME_ATOR = dgvResultado.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString();
                    atorDAL.Excluir(ator);
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
            btnCadastrar.Text = "Cadastrar"; 
            atualizar = false;
            btnCancelar.Visible = false;
            txtNOME_ATOR.ReadOnly = false;

            txtNOME_ATOR.Clear();
            txtIDADE.Clear();
            txtATIVO.Clear();
            txtPAIS.Clear();

            txtNOME_ATOR.Focus();
        }

        private void dgvResultado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            atualizar = true;
            txtNOME_ATOR.ReadOnly = true;
            btnCancelar.Visible = true;
            btnCadastrar.Text = "atualizar";

            ator.NOME_ATOR = dgvResultado.SelectedRows[0].Cells["NOME_ATOR"].Value.ToString();

            ator = atorDAL.PreecheAtor(ator);

            txtNOME_ATOR.Text = ator.NOME_ATOR;
            txtIDADE.Text = ator.IDADE.ToString();
            txtPAIS.Text = ator.PAIS;
            txtATIVO.Text = ator.ATIVO.ToString();

            tabControl1.SelectTab(0); //Seleciona a aba Cadastrar

        }
    }
}
