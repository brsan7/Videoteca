namespace Videoteca.UI
{
    partial class frmSerie
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
            this.tabPage = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtASSISTIDO = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtAVALIACAO = new System.Windows.Forms.TextBox();
            this.cmbAtores = new System.Windows.Forms.ComboBox();
            this.txtDURACAO = new System.Windows.Forms.TextBox();
            this.txtELENCO = new System.Windows.Forms.TextBox();
            this.txtANO = new System.Windows.Forms.TextBox();
            this.lblAvaliacao = new System.Windows.Forms.Label();
            this.txtDESCRICAO = new System.Windows.Forms.TextBox();
            this.lblAssistido = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblDuracao = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.lblPais = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.txtPAIS = new System.Windows.Forms.TextBox();
            this.txtGENERO = new System.Windows.Forms.TextBox();
            this.txtTITULO_SERIE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 361);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage
            // 
            this.tabPage.Controls.Add(this.groupBox1);
            this.tabPage.Location = new System.Drawing.Point(4, 24);
            this.tabPage.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage.Name = "tabPage";
            this.tabPage.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage.Size = new System.Drawing.Size(776, 333);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Registro";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtASSISTIDO);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtAVALIACAO);
            this.groupBox1.Controls.Add(this.cmbAtores);
            this.groupBox1.Controls.Add(this.txtDURACAO);
            this.groupBox1.Controls.Add(this.txtELENCO);
            this.groupBox1.Controls.Add(this.txtANO);
            this.groupBox1.Controls.Add(this.lblAvaliacao);
            this.groupBox1.Controls.Add(this.txtDESCRICAO);
            this.groupBox1.Controls.Add(this.lblAssistido);
            this.groupBox1.Controls.Add(this.lblTitulo);
            this.groupBox1.Controls.Add(this.lblDuracao);
            this.groupBox1.Controls.Add(this.lblDescricao);
            this.groupBox1.Controls.Add(this.lblAno);
            this.groupBox1.Controls.Add(this.lblPais);
            this.groupBox1.Controls.Add(this.lblGenero);
            this.groupBox1.Controls.Add(this.txtPAIS);
            this.groupBox1.Controls.Add(this.txtGENERO);
            this.groupBox1.Controls.Add(this.txtTITULO_SERIE);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(775, 335);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Serie";
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserir.Location = new System.Drawing.Point(653, 250);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(103, 31);
            this.btnInserir.TabIndex = 35;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserirAtorElenco_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(531, 295);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(103, 31);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtASSISTIDO
            // 
            this.txtASSISTIDO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtASSISTIDO.AutoSize = true;
            this.txtASSISTIDO.Location = new System.Drawing.Point(353, 304);
            this.txtASSISTIDO.Name = "txtASSISTIDO";
            this.txtASSISTIDO.Size = new System.Drawing.Size(15, 14);
            this.txtASSISTIDO.TabIndex = 8;
            this.txtASSISTIDO.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(652, 295);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(104, 31);
            this.btnCadastrar.TabIndex = 22;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtAVALIACAO
            // 
            this.txtAVALIACAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAVALIACAO.Location = new System.Drawing.Point(82, 300);
            this.txtAVALIACAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAVALIACAO.Name = "txtAVALIACAO";
            this.txtAVALIACAO.Size = new System.Drawing.Size(50, 23);
            this.txtAVALIACAO.TabIndex = 5;
            // 
            // cmbAtores
            // 
            this.cmbAtores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAtores.FormattingEnabled = true;
            this.cmbAtores.Location = new System.Drawing.Point(436, 254);
            this.cmbAtores.Name = "cmbAtores";
            this.cmbAtores.Size = new System.Drawing.Size(198, 23);
            this.cmbAtores.TabIndex = 34;
            this.cmbAtores.SelectedIndexChanged += new System.EventHandler(this.cmbAtores_SelectedIndexChanged);
            this.cmbAtores.TextChanged += new System.EventHandler(this.cmbAtores_TextChanged);
            // 
            // txtDURACAO
            // 
            this.txtDURACAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDURACAO.Location = new System.Drawing.Point(352, 254);
            this.txtDURACAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDURACAO.Name = "txtDURACAO";
            this.txtDURACAO.Size = new System.Drawing.Size(50, 23);
            this.txtDURACAO.TabIndex = 7;
            // 
            // txtELENCO
            // 
            this.txtELENCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtELENCO.Location = new System.Drawing.Point(436, 50);
            this.txtELENCO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtELENCO.Multiline = true;
            this.txtELENCO.Name = "txtELENCO";
            this.txtELENCO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtELENCO.Size = new System.Drawing.Size(320, 183);
            this.txtELENCO.TabIndex = 33;
            // 
            // txtANO
            // 
            this.txtANO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtANO.Location = new System.Drawing.Point(352, 210);
            this.txtANO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtANO.Name = "txtANO";
            this.txtANO.Size = new System.Drawing.Size(50, 23);
            this.txtANO.TabIndex = 6;
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.BackColor = System.Drawing.Color.DarkGray;
            this.lblAvaliacao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvaliacao.Location = new System.Drawing.Point(16, 303);
            this.lblAvaliacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(59, 15);
            this.lblAvaliacao.TabIndex = 31;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // txtDESCRICAO
            // 
            this.txtDESCRICAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDESCRICAO.Location = new System.Drawing.Point(82, 73);
            this.txtDESCRICAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDESCRICAO.Multiline = true;
            this.txtDESCRICAO.Name = "txtDESCRICAO";
            this.txtDESCRICAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESCRICAO.Size = new System.Drawing.Size(320, 115);
            this.txtDESCRICAO.TabIndex = 2;
            // 
            // lblAssistido
            // 
            this.lblAssistido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssistido.AutoSize = true;
            this.lblAssistido.BackColor = System.Drawing.Color.DarkGray;
            this.lblAssistido.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssistido.Location = new System.Drawing.Point(291, 303);
            this.lblAssistido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssistido.Name = "lblAssistido";
            this.lblAssistido.Size = new System.Drawing.Size(55, 15);
            this.lblAssistido.TabIndex = 29;
            this.lblAssistido.Text = "Assistido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(16, 31);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(39, 15);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Título";
            // 
            // lblDuracao
            // 
            this.lblDuracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.BackColor = System.Drawing.Color.DarkGray;
            this.lblDuracao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuracao.Location = new System.Drawing.Point(291, 258);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(53, 15);
            this.lblDuracao.TabIndex = 27;
            this.lblDuracao.Text = "Duração";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.DarkGray;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(16, 77);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(61, 15);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblAno
            // 
            this.lblAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.DarkGray;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAno.Location = new System.Drawing.Point(291, 213);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(29, 15);
            this.lblAno.TabIndex = 25;
            this.lblAno.Text = "Ano";
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.DarkGray;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPais.Location = new System.Drawing.Point(16, 257);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(28, 15);
            this.lblPais.TabIndex = 19;
            this.lblPais.Text = "País";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.DarkGray;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(15, 213);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(49, 15);
            this.lblGenero.TabIndex = 21;
            this.lblGenero.Text = "Gênero";
            // 
            // txtPAIS
            // 
            this.txtPAIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPAIS.Location = new System.Drawing.Point(82, 255);
            this.txtPAIS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPAIS.Name = "txtPAIS";
            this.txtPAIS.Size = new System.Drawing.Size(150, 23);
            this.txtPAIS.TabIndex = 4;
            // 
            // txtGENERO
            // 
            this.txtGENERO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtGENERO.Location = new System.Drawing.Point(82, 210);
            this.txtGENERO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtGENERO.Name = "txtGENERO";
            this.txtGENERO.Size = new System.Drawing.Size(150, 23);
            this.txtGENERO.TabIndex = 3;
            // 
            // txtTITULO_SERIE
            // 
            this.txtTITULO_SERIE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTITULO_SERIE.Location = new System.Drawing.Point(82, 28);
            this.txtTITULO_SERIE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTITULO_SERIE.Name = "txtTITULO_SERIE";
            this.txtTITULO_SERIE.Size = new System.Drawing.Size(320, 23);
            this.txtTITULO_SERIE.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(416, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(346, 261);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elenco";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.lblFiltro);
            this.tabPage2.Controls.Add(this.txtFiltro);
            this.tabPage2.Controls.Add(this.dgvResultado);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(776, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(679, 26);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 35);
            this.btnExcluir.TabIndex = 6;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(7, 3);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(91, 15);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Filtrar por Título";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(10, 33);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.PlaceholderText = "Digite o título que procura e(ou) com um clique duplo no registro você poderá vis" +
    "ualizá-lo integralmente";
            this.txtFiltro.Size = new System.Drawing.Size(661, 23);
            this.txtFiltro.TabIndex = 4;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // dgvResultado
            // 
            this.dgvResultado.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultado.Location = new System.Drawing.Point(10, 75);
            this.dgvResultado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvResultado.Name = "dgvResultado";
            this.dgvResultado.Size = new System.Drawing.Size(758, 247);
            this.dgvResultado.TabIndex = 3;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // frmSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSerie";
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.frmSerie_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtGENERO;
        private System.Windows.Forms.TextBox txtDESCRICAO;
        private System.Windows.Forms.TextBox txtTITULO_SERIE;
        private System.Windows.Forms.TextBox txtPAIS;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private TextBox txtAVALIACAO;
        private TextBox txtDURACAO;
        private TextBox txtANO;
        private Label lblAvaliacao;
        private Label lblAssistido;
        private Label lblDuracao;
        private Label lblAno;
        private CheckBox txtASSISTIDO;
        private GroupBox groupBox1;
        private ComboBox cmbAtores;
        private TextBox txtELENCO;
        private Button btnInserir;
        private GroupBox groupBox2;
    }
}