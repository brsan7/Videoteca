﻿using System;
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
    public partial class frmFilme : Form
    {
        public frmFilme()
        {
            InitializeComponent();
        }

        FilmeBLL filmeBLL = new FilmeBLL();
        FilmeDAL filmeDAL = new FilmeDAL();
        AtorBLL atorBLL = new AtorBLL();
        AtorDAL atorDAL = new AtorDAL();
        ElencoFilmeBLL elencoFilmeBLL = new ElencoFilmeBLL();
        ElencoFilmeDAL elencoFilmeDAL = new ElencoFilmeDAL();
        List<string> lstElenco = new List<string>();
        List<string> lstElencoRegistrado = new List<string>();

        bool atualizar;

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            filmeBLL.TITULO_FILME = txtTITULO_FILME.Text;
            filmeBLL.DESCRICAO = txtDESCRICAO.Text;
            filmeBLL.GENERO = cmbGENERO.Text;
            filmeBLL.PAIS = txtPAIS.Text;
            filmeBLL.ANO = int.Parse(txtANO.Text);
            filmeBLL.DURACAO = float.Parse(txtDURACAO.Text);
            filmeBLL.AVALIACAO = float.Parse(txtAVALIACAO.Text);
            filmeBLL.ASSISTIDO = txtASSISTIDO.Checked;

            if (atualizar)
            {
                filmeDAL.Atualizar(filmeBLL);

                elencoFilmeBLL.ID_FILME = filmeBLL.ID_FILME;
                foreach (var ator in elencoFilmeBLL.lstAtoresInserir(lstElencoRegistrado, lstElenco))
                {
                    elencoFilmeBLL.NOME_ATOR = ator;
                    elencoFilmeDAL.Cadastrar(elencoFilmeBLL);
                }

                foreach (var ator in elencoFilmeBLL.lstAtoresRemover(lstElencoRegistrado, lstElenco))
                {
                    elencoFilmeBLL.NOME_ATOR = ator;
                    elencoFilmeDAL.Excluir(elencoFilmeBLL);
                }

                MessageBox.Show("Filme Atualizado!");
                btnCadastrar.Text = "Cadastrar";
                atualizar = false;
                txtPAIS.ReadOnly = false;
                btnCancelar.Visible = false;
            }

            else
            {
                filmeDAL.Cadastrar(filmeBLL);

                elencoFilmeBLL.ID_FILME = filmeDAL.BuscarUltimoRegistro(filmeBLL).ID_FILME;
                foreach (var ator in lstElenco)
                {
                    elencoFilmeBLL.NOME_ATOR = ator;
                    elencoFilmeDAL.Cadastrar(elencoFilmeBLL);
                }
                

                MessageBox.Show("Filme Cadastrado!");
            }

            txtTITULO_FILME.Clear();
            txtDESCRICAO.Clear();
            cmbGENERO.DataSource = filmeDAL.listarGeneros(filmeDAL.Consultar());
            txtPAIS.Clear();
            txtANO.Clear();
            txtDURACAO.Clear();
            txtAVALIACAO.Clear();
            txtASSISTIDO.Checked = false;
            txtELENCO.Clear();
            lstElenco.Clear();
            lstElencoRegistrado.Clear();

            txtTITULO_FILME.Focus();
        }

        private void frmFilme_Load(object sender, EventArgs e)
        {
            //Fonte de dados do ComboBox
            AtorDAL atoresDAL = new AtorDAL();
            cmbAtores.DataSource = atoresDAL.Consultar();
            //Fonte de dados do ComboBox(Lista)
            cmbGENERO.DataSource = filmeDAL.listarGeneros(filmeDAL.Consultar());

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
            filmeBLL.TITULO_FILME = txtFiltro.Text;
            dgvResultado.DataSource = filmeDAL.Consultar(filmeBLL);
        }

        private void cmbGeneros_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFiltroGenero.SelectedIndex > 0)
            {
                dgvResultado.DataSource = filmeDAL.Consultar(cmbFiltroGenero.Text);
            }
            else
            {
                dgvResultado.DataSource = filmeDAL.Consultar();
            }
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 1) 
            {
                DataTable fonte = new DataTable();
                fonte = filmeDAL.Consultar();

                dgvResultado.DataSource = fonte;

                cmbFiltroGenero.DataSource = cmbGENERO.DataSource = filmeDAL.listarGeneros(filmeDAL.Consultar());
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
                    filmeBLL.ID_FILME = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_FILME"].Value);
                    elencoFilmeDAL.Excluir(filmeBLL.ID_FILME);
                    filmeDAL.Excluir(filmeBLL);
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

            filmeBLL.ID_FILME = Convert.ToInt16(dgvResultado.SelectedRows[0].Cells["ID_FILME"].Value.ToString());

            filmeBLL = filmeDAL.PreecheFilme(filmeBLL);

            groupBox1.Text = "Atualização de Filme";
            txtTITULO_FILME.Text = filmeBLL.TITULO_FILME;
            txtDESCRICAO.Text = filmeBLL.DESCRICAO;
            cmbGENERO.Text = filmeBLL.GENERO;
            txtPAIS.Text = filmeBLL.PAIS;
            txtANO.Text = filmeBLL.ANO.ToString();
            txtDURACAO.Text = filmeBLL.DURACAO.ToString();
            txtAVALIACAO.Text = filmeBLL.AVALIACAO.ToString();
            txtASSISTIDO.Checked = Convert.ToBoolean(filmeBLL.ASSISTIDO);
            txtELENCO.Clear();
            lstElenco.Clear();
            lstElencoRegistrado.Clear();

            foreach (var ator in elencoFilmeDAL.Consultar(Convert.ToInt16(filmeBLL.ID_FILME)))
            {
                txtELENCO.Text += ator +Environment.NewLine;
                lstElenco.Add(ator);
                lstElencoRegistrado.Add(ator);
            }
            btnInserir_statusTexto(false);
            tabControl1.SelectTab(0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnCadastrar.Text = "Cadastrar";
            atualizar = false;
            btnCancelar.Visible = false;
            txtPAIS.ReadOnly = false;

            groupBox1.Text = "Registro de Filme";
            txtTITULO_FILME.Clear();
            txtDESCRICAO.Clear();
            cmbGENERO.SelectedIndex = 0;
            txtPAIS.Clear();
            txtANO.Clear();
            txtDURACAO.Clear();
            txtAVALIACAO.Clear();
            txtASSISTIDO.Checked = false;
            txtELENCO.Clear();
            lstElenco.Clear();
            lstElencoRegistrado.Clear();

            txtTITULO_FILME.Focus();
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
