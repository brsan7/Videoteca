namespace Videoteca.UI
{
    partial class FrmFilme
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
            this.numAVALIACAO = new System.Windows.Forms.NumericUpDown();
            this.numDURACAO = new System.Windows.Forms.NumericUpDown();
            this.numANO = new System.Windows.Forms.NumericUpDown();
            this.cmbGENERO = new System.Windows.Forms.ComboBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtASSISTIDO = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
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
            this.txtTITULO_FILME = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvElenco = new System.Windows.Forms.DataGridView();
            this.btnInserir = new System.Windows.Forms.Button();
            this.cmbAtores = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbFiltroGenero = new System.Windows.Forms.ComboBox();
            this.lblFiltroGenero = new System.Windows.Forms.Label();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblFiltroTitulo = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.dgvResultado = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAVALIACAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDURACAO)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numANO)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).BeginInit();
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
            this.tabControl1.Size = new System.Drawing.Size(954, 561);
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
            this.tabPage.Size = new System.Drawing.Size(946, 533);
            this.tabPage.TabIndex = 0;
            this.tabPage.Text = "Registro";
            this.tabPage.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.numAVALIACAO);
            this.groupBox1.Controls.Add(this.numDURACAO);
            this.groupBox1.Controls.Add(this.numANO);
            this.groupBox1.Controls.Add(this.cmbGENERO);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtASSISTIDO);
            this.groupBox1.Controls.Add(this.btnCadastrar);
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
            this.groupBox1.Controls.Add(this.txtTITULO_FILME);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 525);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Filme";
            // 
            // numAVALIACAO
            // 
            this.numAVALIACAO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numAVALIACAO.Location = new System.Drawing.Point(131, 465);
            this.numAVALIACAO.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAVALIACAO.Name = "numAVALIACAO";
            this.numAVALIACAO.Size = new System.Drawing.Size(69, 29);
            this.numAVALIACAO.TabIndex = 40;
            // 
            // numDURACAO
            // 
            this.numDURACAO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numDURACAO.Location = new System.Drawing.Point(422, 419);
            this.numDURACAO.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numDURACAO.Name = "numDURACAO";
            this.numDURACAO.Size = new System.Drawing.Size(69, 29);
            this.numDURACAO.TabIndex = 39;
            // 
            // numANO
            // 
            this.numANO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.numANO.Location = new System.Drawing.Point(422, 375);
            this.numANO.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numANO.Name = "numANO";
            this.numANO.Size = new System.Drawing.Size(69, 29);
            this.numANO.TabIndex = 38;
            // 
            // cmbGENERO
            // 
            this.cmbGENERO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGENERO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGENERO.FormattingEnabled = true;
            this.cmbGENERO.Location = new System.Drawing.Point(131, 375);
            this.cmbGENERO.Name = "cmbGENERO";
            this.cmbGENERO.Size = new System.Drawing.Size(202, 29);
            this.cmbGENERO.TabIndex = 37;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(669, 462);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 31);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtASSISTIDO
            // 
            this.txtASSISTIDO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtASSISTIDO.AutoSize = true;
            this.txtASSISTIDO.Location = new System.Drawing.Point(422, 474);
            this.txtASSISTIDO.Name = "txtASSISTIDO";
            this.txtASSISTIDO.Size = new System.Drawing.Size(15, 14);
            this.txtASSISTIDO.TabIndex = 8;
            this.txtASSISTIDO.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(790, 462);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 31);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnRegistro_Click);
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.BackColor = System.Drawing.Color.DarkGray;
            this.lblAvaliacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvaliacao.Location = new System.Drawing.Point(39, 467);
            this.lblAvaliacao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAvaliacao.Name = "lblAvaliacao";
            this.lblAvaliacao.Size = new System.Drawing.Size(85, 21);
            this.lblAvaliacao.TabIndex = 31;
            this.lblAvaliacao.Text = "Avaliação";
            // 
            // txtDESCRICAO
            // 
            this.txtDESCRICAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDESCRICAO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDESCRICAO.Location = new System.Drawing.Point(131, 93);
            this.txtDESCRICAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDESCRICAO.Multiline = true;
            this.txtDESCRICAO.Name = "txtDESCRICAO";
            this.txtDESCRICAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESCRICAO.Size = new System.Drawing.Size(401, 255);
            this.txtDESCRICAO.TabIndex = 2;
            // 
            // lblAssistido
            // 
            this.lblAssistido.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAssistido.AutoSize = true;
            this.lblAssistido.BackColor = System.Drawing.Color.DarkGray;
            this.lblAssistido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAssistido.Location = new System.Drawing.Point(340, 467);
            this.lblAssistido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAssistido.Name = "lblAssistido";
            this.lblAssistido.Size = new System.Drawing.Size(78, 21);
            this.lblAssistido.TabIndex = 29;
            this.lblAssistido.Text = "Assistido";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.DarkGray;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(39, 51);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(55, 21);
            this.lblTitulo.TabIndex = 15;
            this.lblTitulo.Text = "Título";
            // 
            // lblDuracao
            // 
            this.lblDuracao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDuracao.AutoSize = true;
            this.lblDuracao.BackColor = System.Drawing.Color.DarkGray;
            this.lblDuracao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDuracao.Location = new System.Drawing.Point(340, 422);
            this.lblDuracao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDuracao.Name = "lblDuracao";
            this.lblDuracao.Size = new System.Drawing.Size(74, 21);
            this.lblDuracao.TabIndex = 27;
            this.lblDuracao.Text = "Duração";
            // 
            // lblDescricao
            // 
            this.lblDescricao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.BackColor = System.Drawing.Color.DarkGray;
            this.lblDescricao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDescricao.Location = new System.Drawing.Point(39, 97);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(84, 21);
            this.lblDescricao.TabIndex = 17;
            this.lblDescricao.Text = "Descrição";
            // 
            // lblAno
            // 
            this.lblAno.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAno.AutoSize = true;
            this.lblAno.BackColor = System.Drawing.Color.DarkGray;
            this.lblAno.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAno.Location = new System.Drawing.Point(340, 377);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(41, 21);
            this.lblAno.TabIndex = 25;
            this.lblAno.Text = "Ano";
            // 
            // lblPais
            // 
            this.lblPais.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPais.AutoSize = true;
            this.lblPais.BackColor = System.Drawing.Color.DarkGray;
            this.lblPais.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPais.Location = new System.Drawing.Point(39, 421);
            this.lblPais.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPais.Name = "lblPais";
            this.lblPais.Size = new System.Drawing.Size(41, 21);
            this.lblPais.TabIndex = 19;
            this.lblPais.Text = "País";
            // 
            // lblGenero
            // 
            this.lblGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGenero.AutoSize = true;
            this.lblGenero.BackColor = System.Drawing.Color.DarkGray;
            this.lblGenero.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.Location = new System.Drawing.Point(38, 377);
            this.lblGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(65, 21);
            this.lblGenero.TabIndex = 21;
            this.lblGenero.Text = "Gênero";
            // 
            // txtPAIS
            // 
            this.txtPAIS.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtPAIS.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtPAIS.Location = new System.Drawing.Point(131, 419);
            this.txtPAIS.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtPAIS.Name = "txtPAIS";
            this.txtPAIS.Size = new System.Drawing.Size(157, 29);
            this.txtPAIS.TabIndex = 5;
            // 
            // txtTITULO_FILME
            // 
            this.txtTITULO_FILME.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTITULO_FILME.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTITULO_FILME.Location = new System.Drawing.Point(131, 48);
            this.txtTITULO_FILME.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTITULO_FILME.Name = "txtTITULO_FILME";
            this.txtTITULO_FILME.Size = new System.Drawing.Size(401, 29);
            this.txtTITULO_FILME.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.dgvElenco);
            this.groupBox2.Controls.Add(this.btnInserir);
            this.groupBox2.Controls.Add(this.cmbAtores);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox2.Location = new System.Drawing.Point(553, 48);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(367, 408);
            this.groupBox2.TabIndex = 36;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Elenco";
            // 
            // dgvElenco
            // 
            this.dgvElenco.AllowUserToAddRows = false;
            this.dgvElenco.AllowUserToDeleteRows = false;
            this.dgvElenco.AllowUserToOrderColumns = true;
            this.dgvElenco.AllowUserToResizeColumns = false;
            this.dgvElenco.AllowUserToResizeRows = false;
            this.dgvElenco.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvElenco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvElenco.ColumnHeadersVisible = false;
            this.dgvElenco.Location = new System.Drawing.Point(6, 28);
            this.dgvElenco.MultiSelect = false;
            this.dgvElenco.Name = "dgvElenco";
            this.dgvElenco.ReadOnly = true;
            this.dgvElenco.RowHeadersVisible = false;
            this.dgvElenco.RowTemplate.Height = 25;
            this.dgvElenco.Size = new System.Drawing.Size(355, 328);
            this.dgvElenco.TabIndex = 11;
            this.dgvElenco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElenco_CellClick);
            this.dgvElenco.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvElenco_CellDoubleClick);
            // 
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserir.Location = new System.Drawing.Point(237, 368);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 31);
            this.btnInserir.TabIndex = 10;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserirAtorElenco_Click);
            // 
            // cmbAtores
            // 
            this.cmbAtores.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbAtores.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbAtores.FormattingEnabled = true;
            this.cmbAtores.Location = new System.Drawing.Point(20, 370);
            this.cmbAtores.Name = "cmbAtores";
            this.cmbAtores.Size = new System.Drawing.Size(212, 29);
            this.cmbAtores.TabIndex = 9;
            this.cmbAtores.SelectedIndexChanged += new System.EventHandler(this.cmbAtores_SelectedIndexChanged);
            this.cmbAtores.TextChanged += new System.EventHandler(this.cmbAtores_TextChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbFiltroGenero);
            this.tabPage2.Controls.Add(this.lblFiltroGenero);
            this.tabPage2.Controls.Add(this.btnExcluir);
            this.tabPage2.Controls.Add(this.lblFiltroTitulo);
            this.tabPage2.Controls.Add(this.txtFiltro);
            this.tabPage2.Controls.Add(this.dgvResultado);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(946, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbFiltroGenero
            // 
            this.cmbFiltroGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltroGenero.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbFiltroGenero.FormattingEnabled = true;
            this.cmbFiltroGenero.Location = new System.Drawing.Point(600, 33);
            this.cmbFiltroGenero.Name = "cmbFiltroGenero";
            this.cmbFiltroGenero.Size = new System.Drawing.Size(228, 23);
            this.cmbFiltroGenero.TabIndex = 2;
            this.cmbFiltroGenero.SelectedIndexChanged += new System.EventHandler(this.cmbGeneros_SelectedIndexChanged);
            // 
            // lblFiltroGenero
            // 
            this.lblFiltroGenero.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFiltroGenero.AutoSize = true;
            this.lblFiltroGenero.Location = new System.Drawing.Point(600, 15);
            this.lblFiltroGenero.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroGenero.Name = "lblFiltroGenero";
            this.lblFiltroGenero.Size = new System.Drawing.Size(99, 15);
            this.lblFiltroGenero.TabIndex = 7;
            this.lblFiltroGenero.Text = "Filtrar por Gênero";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Location = new System.Drawing.Point(849, 26);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(88, 35);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblFiltroTitulo
            // 
            this.lblFiltroTitulo.AutoSize = true;
            this.lblFiltroTitulo.Location = new System.Drawing.Point(10, 15);
            this.lblFiltroTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroTitulo.Name = "lblFiltroTitulo";
            this.lblFiltroTitulo.Size = new System.Drawing.Size(91, 15);
            this.lblFiltroTitulo.TabIndex = 5;
            this.lblFiltroTitulo.Text = "Filtrar por Título";
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
            this.txtFiltro.Size = new System.Drawing.Size(565, 23);
            this.txtFiltro.TabIndex = 1;
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
            this.dgvResultado.Size = new System.Drawing.Size(927, 450);
            this.dgvResultado.TabIndex = 4;
            this.dgvResultado.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultado_CellDoubleClick);
            // 
            // FrmFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FrmFilme";
            this.Text = "Filme";
            this.Load += new System.EventHandler(this.frmFilme_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAVALIACAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDURACAO)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numANO)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvElenco)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox txtDESCRICAO;
        private System.Windows.Forms.TextBox txtTITULO_FILME;
        private System.Windows.Forms.TextBox txtPAIS;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblPais;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lblFiltroTitulo;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.DataGridView dgvResultado;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private Label lblAvaliacao;
        private Label lblAssistido;
        private Label lblDuracao;
        private Label lblAno;
        private CheckBox txtASSISTIDO;
        private GroupBox groupBox1;
        private ComboBox cmbAtores;
        private Button btnInserir;
        private GroupBox groupBox2;
        private Label lblFiltroGenero;
        private ComboBox cmbFiltroGenero;
        private ComboBox cmbGENERO;
        private DataGridView dgvElenco;
        private NumericUpDown numAVALIACAO;
        private NumericUpDown numDURACAO;
        private NumericUpDown numANO;
    }
}