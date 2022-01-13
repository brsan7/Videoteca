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
            this.cmbGENERO = new System.Windows.Forms.ComboBox();
            this.lblEpisodio = new System.Windows.Forms.Label();
            this.lblTemporada = new System.Windows.Forms.Label();
            this.txtEPISODIO = new System.Windows.Forms.TextBox();
            this.txtTEMPORADA = new System.Windows.Forms.TextBox();
            this.lblCapitulo = new System.Windows.Forms.Label();
            this.txtCAPITULO = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtASSISTIDO = new System.Windows.Forms.CheckBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtAVALIACAO = new System.Windows.Forms.TextBox();
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
            this.txtTITULO_SERIE = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.Color.DarkGray;
            this.groupBox1.Controls.Add(this.cmbGENERO);
            this.groupBox1.Controls.Add(this.lblEpisodio);
            this.groupBox1.Controls.Add(this.lblTemporada);
            this.groupBox1.Controls.Add(this.txtEPISODIO);
            this.groupBox1.Controls.Add(this.txtTEMPORADA);
            this.groupBox1.Controls.Add(this.lblCapitulo);
            this.groupBox1.Controls.Add(this.txtCAPITULO);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.txtASSISTIDO);
            this.groupBox1.Controls.Add(this.btnCadastrar);
            this.groupBox1.Controls.Add(this.txtAVALIACAO);
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
            this.groupBox1.Controls.Add(this.txtTITULO_SERIE);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(945, 525);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro de Série";
            // 
            // cmbGENERO
            // 
            this.cmbGENERO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbGENERO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbGENERO.FormattingEnabled = true;
            this.cmbGENERO.Location = new System.Drawing.Point(131, 374);
            this.cmbGENERO.Name = "cmbGENERO";
            this.cmbGENERO.Size = new System.Drawing.Size(202, 29);
            this.cmbGENERO.TabIndex = 6;
            // 
            // lblEpisodio
            // 
            this.lblEpisodio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEpisodio.AutoSize = true;
            this.lblEpisodio.BackColor = System.Drawing.Color.DarkGray;
            this.lblEpisodio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEpisodio.Location = new System.Drawing.Point(340, 330);
            this.lblEpisodio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEpisodio.Name = "lblEpisodio";
            this.lblEpisodio.Size = new System.Drawing.Size(76, 21);
            this.lblEpisodio.TabIndex = 42;
            this.lblEpisodio.Text = "Episódio";
            // 
            // lblTemporada
            // 
            this.lblTemporada.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTemporada.AutoSize = true;
            this.lblTemporada.BackColor = System.Drawing.Color.DarkGray;
            this.lblTemporada.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTemporada.Location = new System.Drawing.Point(33, 330);
            this.lblTemporada.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTemporada.Name = "lblTemporada";
            this.lblTemporada.Size = new System.Drawing.Size(96, 21);
            this.lblTemporada.TabIndex = 41;
            this.lblTemporada.Text = "Temporada";
            // 
            // txtEPISODIO
            // 
            this.txtEPISODIO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEPISODIO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtEPISODIO.Location = new System.Drawing.Point(422, 327);
            this.txtEPISODIO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEPISODIO.Name = "txtEPISODIO";
            this.txtEPISODIO.Size = new System.Drawing.Size(57, 29);
            this.txtEPISODIO.TabIndex = 5;
            // 
            // txtTEMPORADA
            // 
            this.txtTEMPORADA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTEMPORADA.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTEMPORADA.Location = new System.Drawing.Point(131, 327);
            this.txtTEMPORADA.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTEMPORADA.Name = "txtTEMPORADA";
            this.txtTEMPORADA.Size = new System.Drawing.Size(57, 29);
            this.txtTEMPORADA.TabIndex = 4;
            // 
            // lblCapitulo
            // 
            this.lblCapitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCapitulo.AutoSize = true;
            this.lblCapitulo.BackColor = System.Drawing.Color.DarkGray;
            this.lblCapitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCapitulo.Location = new System.Drawing.Point(32, 100);
            this.lblCapitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCapitulo.Name = "lblCapitulo";
            this.lblCapitulo.Size = new System.Drawing.Size(75, 21);
            this.lblCapitulo.TabIndex = 38;
            this.lblCapitulo.Text = "Capítulo";
            // 
            // txtCAPITULO
            // 
            this.txtCAPITULO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCAPITULO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCAPITULO.Location = new System.Drawing.Point(131, 97);
            this.txtCAPITULO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCAPITULO.Name = "txtCAPITULO";
            this.txtCAPITULO.Size = new System.Drawing.Size(401, 29);
            this.txtCAPITULO.TabIndex = 2;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCancelar.Location = new System.Drawing.Point(669, 462);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 31);
            this.btnCancelar.TabIndex = 15;
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
            this.txtASSISTIDO.TabIndex = 11;
            this.txtASSISTIDO.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCadastrar.Location = new System.Drawing.Point(790, 462);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(111, 31);
            this.btnCadastrar.TabIndex = 14;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // txtAVALIACAO
            // 
            this.txtAVALIACAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAVALIACAO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtAVALIACAO.Location = new System.Drawing.Point(131, 464);
            this.txtAVALIACAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtAVALIACAO.Name = "txtAVALIACAO";
            this.txtAVALIACAO.Size = new System.Drawing.Size(57, 29);
            this.txtAVALIACAO.TabIndex = 10;
            // 
            // txtDURACAO
            // 
            this.txtDURACAO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDURACAO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDURACAO.Location = new System.Drawing.Point(422, 419);
            this.txtDURACAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDURACAO.Name = "txtDURACAO";
            this.txtDURACAO.Size = new System.Drawing.Size(57, 29);
            this.txtDURACAO.TabIndex = 9;
            // 
            // txtELENCO
            // 
            this.txtELENCO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtELENCO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtELENCO.Location = new System.Drawing.Point(573, 70);
            this.txtELENCO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtELENCO.Multiline = true;
            this.txtELENCO.Name = "txtELENCO";
            this.txtELENCO.ReadOnly = true;
            this.txtELENCO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtELENCO.Size = new System.Drawing.Size(327, 333);
            this.txtELENCO.TabIndex = 33;
            // 
            // txtANO
            // 
            this.txtANO.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtANO.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtANO.Location = new System.Drawing.Point(422, 375);
            this.txtANO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtANO.Name = "txtANO";
            this.txtANO.Size = new System.Drawing.Size(57, 29);
            this.txtANO.TabIndex = 7;
            // 
            // lblAvaliacao
            // 
            this.lblAvaliacao.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAvaliacao.AutoSize = true;
            this.lblAvaliacao.BackColor = System.Drawing.Color.DarkGray;
            this.lblAvaliacao.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAvaliacao.Location = new System.Drawing.Point(33, 467);
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
            this.txtDESCRICAO.Location = new System.Drawing.Point(131, 150);
            this.txtDESCRICAO.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDESCRICAO.Multiline = true;
            this.txtDESCRICAO.Name = "txtDESCRICAO";
            this.txtDESCRICAO.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDESCRICAO.Size = new System.Drawing.Size(401, 158);
            this.txtDESCRICAO.TabIndex = 3;
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
            this.lblTitulo.Location = new System.Drawing.Point(33, 51);
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
            this.lblDescricao.Location = new System.Drawing.Point(32, 153);
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
            this.lblPais.Location = new System.Drawing.Point(33, 421);
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
            this.lblGenero.Location = new System.Drawing.Point(32, 377);
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
            this.txtPAIS.TabIndex = 8;
            // 
            // txtTITULO_SERIE
            // 
            this.txtTITULO_SERIE.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTITULO_SERIE.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTITULO_SERIE.Location = new System.Drawing.Point(131, 48);
            this.txtTITULO_SERIE.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTITULO_SERIE.Name = "txtTITULO_SERIE";
            this.txtTITULO_SERIE.Size = new System.Drawing.Size(401, 29);
            this.txtTITULO_SERIE.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
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
            // btnInserir
            // 
            this.btnInserir.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnInserir.Location = new System.Drawing.Point(237, 368);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(111, 31);
            this.btnInserir.TabIndex = 13;
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
            this.cmbAtores.TabIndex = 12;
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
            this.cmbFiltroGenero.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            // frmSerie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmSerie";
            this.Text = "Serie";
            this.Load += new System.EventHandler(this.frmSerie_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
        private System.Windows.Forms.TextBox txtTITULO_SERIE;
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
        private Label lblFiltroGenero;
        private ComboBox cmbFiltroGenero;
        private Label lblEpisodio;
        private Label lblTemporada;
        private TextBox txtEPISODIO;
        private TextBox txtTEMPORADA;
        private Label lblCapitulo;
        private TextBox txtCAPITULO;
        private ComboBox cmbGENERO;
    }
}