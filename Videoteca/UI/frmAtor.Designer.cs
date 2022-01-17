namespace Videoteca.UI
{
    partial class frmAtor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbpCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numIDADE = new System.Windows.Forms.NumericUpDown();
            this.ckbAPOSENTADO = new System.Windows.Forms.CheckBox();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblAtivo = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.txtPAIS = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtNOME_ATOR = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvAtorSeries = new System.Windows.Forms.DataGridView();
            this.dgvAtorFilmes = new System.Windows.Forms.DataGridView();
            this.tbpConsulta = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tbpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIDADE)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtorSeries)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtorFilmes)).BeginInit();
            this.tbpConsulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbpCadastro);
            this.tabControl1.Controls.Add(this.tbpConsulta);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(895, 341);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tbpCadastro
            // 
            this.tbpCadastro.Controls.Add(this.groupBox1);
            this.tbpCadastro.Location = new System.Drawing.Point(4, 24);
            this.tbpCadastro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpCadastro.Name = "tbpCadastro";
            this.tbpCadastro.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpCadastro.Size = new System.Drawing.Size(887, 313);
            this.tbpCadastro.TabIndex = 0;
            this.tbpCadastro.Text = "Cadastro";
            this.tbpCadastro.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.numIDADE);
            this.groupBox1.Controls.Add(this.ckbAPOSENTADO);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.lblAtivo);
            this.groupBox1.Controls.Add(this.lblIdade);
            this.groupBox1.Controls.Add(this.txtPAIS);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtNOME_ATOR);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(881, 307);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro Ator";
            // 
            // numIDADE
            // 
            this.numIDADE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numIDADE.Location = new System.Drawing.Point(137, 98);
            this.numIDADE.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numIDADE.Name = "numIDADE";
            this.numIDADE.Size = new System.Drawing.Size(54, 29);
            this.numIDADE.TabIndex = 2;
            // 
            // ckbAPOSENTADO
            // 
            this.ckbAPOSENTADO.AutoSize = true;
            this.ckbAPOSENTADO.Location = new System.Drawing.Point(137, 184);
            this.ckbAPOSENTADO.Name = "ckbAPOSENTADO";
            this.ckbAPOSENTADO.Size = new System.Drawing.Size(15, 14);
            this.ckbAPOSENTADO.TabIndex = 4;
            this.ckbAPOSENTADO.UseVisualStyleBackColor = true;
            // 
            // lblPais
            // 
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.DarkGray;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPais.Location = new System.Drawing.Point(27, 140);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(41, 21);
            this.lblPais.TabIndex = 3;
            this.lblPais.Text = "País";
            // 
            // lblAtivo
            // 
            this.lblAtivo.AutoSize = true;
            this.lblAtivo.BackColor = System.Drawing.Color.DarkGray;
            this.lblAtivo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAtivo.Location = new System.Drawing.Point(27, 180);
            this.lblAtivo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAtivo.Name = "lblAtivo";
            this.lblAtivo.Size = new System.Drawing.Size(102, 21);
            this.lblAtivo.TabIndex = 2;
            this.lblAtivo.Text = "Aposentado";
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.BackColor = System.Drawing.Color.DarkGray;
            this.lblIdade.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIdade.Location = new System.Drawing.Point(27, 100);
            this.lblIdade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(53, 21);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade";
            // 
            // txtPAIS
            // 
            this.txtPAIS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPAIS.Location = new System.Drawing.Point(137, 137);
            this.txtPAIS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPAIS.Name = "txtPAIS";
            this.txtPAIS.Size = new System.Drawing.Size(157, 29);
            this.txtPAIS.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.Color.DarkGray;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNome.Location = new System.Drawing.Point(27, 60);
            this.lblNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(57, 21);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(146, 246);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(107, 37);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCadastrar.Location = new System.Drawing.Point(27, 246);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(107, 37);
            this.btnCadastrar.TabIndex = 5;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtNOME_ATOR
            // 
            this.txtNOME_ATOR.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNOME_ATOR.Location = new System.Drawing.Point(137, 57);
            this.txtNOME_ATOR.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNOME_ATOR.Name = "txtNOME_ATOR";
            this.txtNOME_ATOR.Size = new System.Drawing.Size(331, 29);
            this.txtNOME_ATOR.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dgvAtorSeries);
            this.groupBox2.Controls.Add(this.dgvAtorFilmes);
            this.groupBox2.Location = new System.Drawing.Point(475, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(400, 261);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Atuações";
            // 
            // dgvAtorSeries
            // 
            this.dgvAtorSeries.AllowUserToAddRows = false;
            this.dgvAtorSeries.AllowUserToDeleteRows = false;
            this.dgvAtorSeries.AllowUserToOrderColumns = true;
            this.dgvAtorSeries.AllowUserToResizeRows = false;
            this.dgvAtorSeries.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtorSeries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtorSeries.Location = new System.Drawing.Point(6, 148);
            this.dgvAtorSeries.Name = "dgvAtorSeries";
            this.dgvAtorSeries.ReadOnly = true;
            this.dgvAtorSeries.RowHeadersVisible = false;
            this.dgvAtorSeries.RowTemplate.Height = 25;
            this.dgvAtorSeries.Size = new System.Drawing.Size(388, 107);
            this.dgvAtorSeries.TabIndex = 1;
            this.dgvAtorSeries.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtorSeries_CellDoubleClick);
            // 
            // dgvAtorFilmes
            // 
            this.dgvAtorFilmes.AllowUserToAddRows = false;
            this.dgvAtorFilmes.AllowUserToDeleteRows = false;
            this.dgvAtorFilmes.AllowUserToOrderColumns = true;
            this.dgvAtorFilmes.AllowUserToResizeRows = false;
            this.dgvAtorFilmes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAtorFilmes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAtorFilmes.Location = new System.Drawing.Point(6, 38);
            this.dgvAtorFilmes.Name = "dgvAtorFilmes";
            this.dgvAtorFilmes.ReadOnly = true;
            this.dgvAtorFilmes.RowHeadersVisible = false;
            this.dgvAtorFilmes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvAtorFilmes.RowTemplate.Height = 25;
            this.dgvAtorFilmes.Size = new System.Drawing.Size(388, 107);
            this.dgvAtorFilmes.TabIndex = 0;
            this.dgvAtorFilmes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAtorFilmes_CellDoubleClick);
            // 
            // tbpConsulta
            // 
            this.tbpConsulta.Controls.Add(this.btnExcluir);
            this.tbpConsulta.Controls.Add(this.lblFiltro);
            this.tbpConsulta.Controls.Add(this.txtFiltro);
            this.tbpConsulta.Controls.Add(this.dgvResultado);
            this.tbpConsulta.Location = new System.Drawing.Point(4, 24);
            this.tbpConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpConsulta.Name = "tbpConsulta";
            this.tbpConsulta.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbpConsulta.Size = new System.Drawing.Size(887, 313);
            this.tbpConsulta.TabIndex = 1;
            this.tbpConsulta.Text = "Consulta";
            this.tbpConsulta.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(794, 32);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(84, 33);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(5, 16);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(94, 15);
            this.lblFiltro.TabIndex = 2;
            this.lblFiltro.Text = "Filtrar por Nome";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(9, 38);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(777, 23);
            this.txtFiltro.TabIndex = 1;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.Location = new System.Drawing.Point(9, 67);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(869, 238);
            this.dgvResultado.TabIndex = 0;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // frmAtor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 341);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAtor";
            this.Text = "Ator";
            this.Load += new System.EventHandler(this.frmAtor_Load);
            this.tabControl1.ResumeLayout(false);
            this.tbpCadastro.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIDADE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtorSeries)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAtorFilmes)).EndInit();
            this.tbpConsulta.ResumeLayout(false);
            this.tbpConsulta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbpCadastro;
        private System.Windows.Forms.TabPage tbpConsulta;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtPAIS;
        private System.Windows.Forms.TextBox txtNOME_ATOR;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblAtivo;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private GroupBox groupBox1;
        private CheckBox ckbAPOSENTADO;
        private GroupBox groupBox2;
        private DataGridView dgvAtorFilmes;
        private DataGridView dgvAtorSeries;
        private NumericUpDown numIDADE;
    }
}