namespace UI.Desktop
{
    partial class frmUsuario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuario));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.textTelDois = new System.Windows.Forms.TextBox();
            this.textRua = new System.Windows.Forms.TextBox();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.textN = new System.Windows.Forms.TextBox();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textTelUm = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.labelRua = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.labelBairro = new System.Windows.Forms.Label();
            this.labelCidade = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gpbDados = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelSexo = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.labelTelUm = new System.Windows.Forms.Label();
            this.comboTelUm = new System.Windows.Forms.ComboBox();
            this.labelTelDois = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboTelDois = new System.Windows.Forms.ComboBox();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recortarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copiarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.salvarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.copiarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colarToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ajudaToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.lblAtencao = new System.Windows.Forms.Label();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gpbDados.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textEmail, "Favor Informe o E-mail");
            this.textEmail.Location = new System.Drawing.Point(87, 133);
            this.textEmail.Margin = new System.Windows.Forms.Padding(4);
            this.textEmail.Name = "textEmail";
            this.helpProvider1.SetShowHelp(this.textEmail, true);
            this.textEmail.Size = new System.Drawing.Size(489, 26);
            this.textEmail.TabIndex = 4;
            this.textEmail.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textNome, "Informe seu nome ");
            this.textNome.Location = new System.Drawing.Point(86, 53);
            this.textNome.Margin = new System.Windows.Forms.Padding(4);
            this.textNome.Name = "textNome";
            this.helpProvider1.SetShowHelp(this.textNome, true);
            this.textNome.Size = new System.Drawing.Size(390, 26);
            this.textNome.TabIndex = 0;
            this.textNome.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textTelDois
            // 
            this.textTelDois.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textTelDois, "Informe o Celular");
            this.textTelDois.Location = new System.Drawing.Point(385, 90);
            this.textTelDois.Margin = new System.Windows.Forms.Padding(4);
            this.textTelDois.Name = "textTelDois";
            this.helpProvider1.SetShowHelp(this.textTelDois, true);
            this.textTelDois.Size = new System.Drawing.Size(191, 26);
            this.textTelDois.TabIndex = 3;
            this.textTelDois.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textRua
            // 
            this.textRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textRua, "Informe a Rua");
            this.textRua.Location = new System.Drawing.Point(52, 41);
            this.textRua.Margin = new System.Windows.Forms.Padding(4);
            this.textRua.Name = "textRua";
            this.helpProvider1.SetShowHelp(this.textRua, true);
            this.textRua.Size = new System.Drawing.Size(395, 26);
            this.textRua.TabIndex = 0;
            this.textRua.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textComplemento
            // 
            this.textComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textComplemento, "Informe o Complemento");
            this.textComplemento.Location = new System.Drawing.Point(721, 92);
            this.textComplemento.Margin = new System.Windows.Forms.Padding(4);
            this.textComplemento.Name = "textComplemento";
            this.helpProvider1.SetShowHelp(this.textComplemento, true);
            this.textComplemento.Size = new System.Drawing.Size(171, 26);
            this.textComplemento.TabIndex = 6;
            // 
            // textCEP
            // 
            this.textCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textCEP, "Informe o CEP");
            this.textCEP.Location = new System.Drawing.Point(525, 41);
            this.textCEP.Margin = new System.Windows.Forms.Padding(4);
            this.textCEP.Name = "textCEP";
            this.helpProvider1.SetShowHelp(this.textCEP, true);
            this.textCEP.Size = new System.Drawing.Size(136, 26);
            this.textCEP.TabIndex = 1;
            this.textCEP.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textCidade
            // 
            this.textCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textCidade, "Informe a Cidade");
            this.textCidade.Location = new System.Drawing.Point(83, 96);
            this.textCidade.Margin = new System.Windows.Forms.Padding(4);
            this.textCidade.Name = "textCidade";
            this.helpProvider1.SetShowHelp(this.textCidade, true);
            this.textCidade.Size = new System.Drawing.Size(184, 26);
            this.textCidade.TabIndex = 3;
            this.textCidade.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textBairro
            // 
            this.textBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textBairro, "Informe o  Bairro");
            this.textBairro.Location = new System.Drawing.Point(739, 39);
            this.textBairro.Margin = new System.Windows.Forms.Padding(4);
            this.textBairro.Name = "textBairro";
            this.helpProvider1.SetShowHelp(this.textBairro, true);
            this.textBairro.Size = new System.Drawing.Size(153, 26);
            this.textBairro.TabIndex = 2;
            this.textBairro.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textN
            // 
            this.textN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textN, "Informe o Numero");
            this.textN.Location = new System.Drawing.Point(525, 94);
            this.textN.Margin = new System.Windows.Forms.Padding(4);
            this.textN.Name = "textN";
            this.helpProvider1.SetShowHelp(this.textN, true);
            this.textN.Size = new System.Drawing.Size(66, 26);
            this.textN.TabIndex = 5;
            this.textN.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textCPF
            // 
            this.textCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textCPF, "Informe o CFP");
            this.textCPF.Location = new System.Drawing.Point(530, 53);
            this.textCPF.Margin = new System.Windows.Forms.Padding(4);
            this.textCPF.Name = "textCPF";
            this.helpProvider1.SetShowHelp(this.textCPF, true);
            this.textCPF.Size = new System.Drawing.Size(131, 26);
            this.textCPF.TabIndex = 1;
            this.textCPF.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // textTelUm
            // 
            this.textTelUm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpProvider1.SetHelpString(this.textTelUm, "Informe o Telefone");
            this.textTelUm.Location = new System.Drawing.Point(385, 50);
            this.textTelUm.Margin = new System.Windows.Forms.Padding(4);
            this.textTelUm.Name = "textTelUm";
            this.helpProvider1.SetShowHelp(this.textTelUm, true);
            this.textTelUm.Size = new System.Drawing.Size(191, 26);
            this.textTelUm.TabIndex = 1;
            this.textTelUm.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingTextBox);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.Black;
            this.btnCadastrar.Location = new System.Drawing.Point(678, 583);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(94, 30);
            this.btnCadastrar.TabIndex = 2;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Visible = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Black;
            this.btnLimpar.Location = new System.Drawing.Point(877, 583);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(85, 30);
            this.btnLimpar.TabIndex = 4;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Visible = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRua.ForeColor = System.Drawing.Color.Black;
            this.labelRua.Location = new System.Drawing.Point(13, 44);
            this.labelRua.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(40, 18);
            this.labelRua.TabIndex = 13;
            this.labelRua.Text = "Rua:";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.ForeColor = System.Drawing.Color.Black;
            this.labelCEP.Location = new System.Drawing.Point(477, 44);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(46, 18);
            this.labelCEP.TabIndex = 17;
            this.labelCEP.Text = "CEP:";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplemento.ForeColor = System.Drawing.Color.Black;
            this.labelComplemento.Location = new System.Drawing.Point(608, 97);
            this.labelComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(110, 18);
            this.labelComplemento.TabIndex = 39;
            this.labelComplemento.Text = "Complemento:";
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.ForeColor = System.Drawing.Color.Black;
            this.labelBairro.Location = new System.Drawing.Point(681, 44);
            this.labelBairro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(55, 18);
            this.labelBairro.TabIndex = 21;
            this.labelBairro.Text = "Bairro:";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.ForeColor = System.Drawing.Color.Black;
            this.labelCidade.Location = new System.Drawing.Point(16, 101);
            this.labelCidade.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(64, 18);
            this.labelCidade.TabIndex = 23;
            this.labelCidade.Text = "Cidade:";
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.ForeColor = System.Drawing.Color.Black;
            this.labelN.Location = new System.Drawing.Point(494, 97);
            this.labelN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(29, 18);
            this.labelN.TabIndex = 15;
            this.labelN.Text = "N°:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox1.Location = new System.Drawing.Point(927, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 470);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Procurar";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Font = new System.Drawing.Font("Arial", 11F);
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(7, 83);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView1.Size = new System.Drawing.Size(288, 381);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(7, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(257, 26);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // gpbDados
            // 
            this.gpbDados.Controls.Add(this.label2);
            this.gpbDados.Controls.Add(this.comboDepartamento);
            this.gpbDados.Controls.Add(this.label1);
            this.gpbDados.Controls.Add(this.comboTipo);
            this.gpbDados.Controls.Add(this.textNome);
            this.gpbDados.Controls.Add(this.labelNome);
            this.gpbDados.Controls.Add(this.labelCPF);
            this.gpbDados.Controls.Add(this.textCPF);
            this.gpbDados.Controls.Add(this.labelDataNascimento);
            this.gpbDados.Controls.Add(this.dateTimeNascimento);
            this.gpbDados.Controls.Add(this.labelSexo);
            this.gpbDados.Controls.Add(this.comboSexo);
            this.gpbDados.Font = new System.Drawing.Font("Arial", 20.25F);
            this.gpbDados.Location = new System.Drawing.Point(12, 112);
            this.gpbDados.Name = "gpbDados";
            this.gpbDados.Size = new System.Drawing.Size(909, 156);
            this.gpbDados.TabIndex = 0;
            this.gpbDados.TabStop = false;
            this.gpbDados.Text = "Dados Pessoais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(330, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tipo Usúario:";
            // 
            // comboTipo
            // 
            this.comboTipo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.comboTipo.Location = new System.Drawing.Point(434, 103);
            this.comboTipo.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(144, 26);
            this.comboTipo.TabIndex = 4;
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.Color.Black;
            this.labelNome.Location = new System.Drawing.Point(30, 55);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(54, 18);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.ForeColor = System.Drawing.Color.Black;
            this.labelCPF.Location = new System.Drawing.Point(484, 56);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(45, 18);
            this.labelCPF.TabIndex = 4;
            this.labelCPF.Text = "CPF:";
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.labelDataNascimento.Location = new System.Drawing.Point(30, 106);
            this.labelDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(155, 18);
            this.labelDataNascimento.TabIndex = 8;
            this.labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(186, 102);
            this.dateTimeNascimento.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimeNascimento.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(117, 26);
            this.dateTimeNascimento.TabIndex = 3;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.ForeColor = System.Drawing.Color.Black;
            this.labelSexo.Location = new System.Drawing.Point(682, 55);
            this.labelSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(48, 18);
            this.labelSexo.TabIndex = 10;
            this.labelSexo.Text = "Sexo:";
            // 
            // comboSexo
            // 
            this.comboSexo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboSexo.Location = new System.Drawing.Point(734, 53);
            this.comboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(167, 26);
            this.comboSexo.TabIndex = 2;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.ForeColor = System.Drawing.Color.Black;
            this.labelUF.Location = new System.Drawing.Point(297, 101);
            this.labelUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(33, 18);
            this.labelUF.TabIndex = 25;
            this.labelUF.Text = "UF:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRua);
            this.groupBox2.Controls.Add(this.textRua);
            this.groupBox2.Controls.Add(this.textComplemento);
            this.groupBox2.Controls.Add(this.labelCEP);
            this.groupBox2.Controls.Add(this.labelComplemento);
            this.groupBox2.Controls.Add(this.textCEP);
            this.groupBox2.Controls.Add(this.labelBairro);
            this.groupBox2.Controls.Add(this.textCidade);
            this.groupBox2.Controls.Add(this.textBairro);
            this.groupBox2.Controls.Add(this.labelCidade);
            this.groupBox2.Controls.Add(this.labelN);
            this.groupBox2.Controls.Add(this.textN);
            this.groupBox2.Controls.Add(this.labelUF);
            this.groupBox2.Controls.Add(this.comboUF);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox2.Location = new System.Drawing.Point(13, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(908, 136);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // comboUF
            // 
            this.comboUF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboUF.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboUF.FormattingEnabled = true;
            this.comboUF.Items.AddRange(new object[] {
            "AC",
            "AL",
            "AM",
            "AP",
            "BA",
            "CE",
            "DF",
            "ES",
            "GO",
            "MA",
            "MG",
            "MS",
            "MT",
            "PA",
            "PB",
            "PE",
            "PI",
            "PR",
            "RJ",
            "RN",
            "RO",
            "RR",
            "RS",
            "SC",
            "SE",
            "SP",
            "TO"});
            this.comboUF.Location = new System.Drawing.Point(333, 97);
            this.comboUF.Margin = new System.Windows.Forms.Padding(4);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(130, 26);
            this.comboUF.TabIndex = 4;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.Color.Black;
            this.labelEmail.Location = new System.Drawing.Point(17, 136);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 18);
            this.labelEmail.TabIndex = 33;
            this.labelEmail.Text = "E-mail:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(780, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Alterar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelTelUm
            // 
            this.labelTelUm.AutoSize = true;
            this.labelTelUm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelUm.ForeColor = System.Drawing.Color.Black;
            this.labelTelUm.Location = new System.Drawing.Point(17, 53);
            this.labelTelUm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelUm.Name = "labelTelUm";
            this.labelTelUm.Size = new System.Drawing.Size(83, 18);
            this.labelTelUm.TabIndex = 28;
            this.labelTelUm.Text = "Telefone 1:";
            // 
            // comboTelUm
            // 
            this.comboTelUm.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTelUm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTelUm.FormattingEnabled = true;
            this.comboTelUm.Items.AddRange(new object[] {
            "Celular",
            "Fax",
            "Telefone Comercial ",
            "Telefone Fixo"});
            this.comboTelUm.Location = new System.Drawing.Point(106, 50);
            this.comboTelUm.Margin = new System.Windows.Forms.Padding(4);
            this.comboTelUm.Name = "comboTelUm";
            this.comboTelUm.Size = new System.Drawing.Size(272, 26);
            this.comboTelUm.TabIndex = 0;
            // 
            // labelTelDois
            // 
            this.labelTelDois.AutoSize = true;
            this.labelTelDois.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelDois.ForeColor = System.Drawing.Color.Black;
            this.labelTelDois.Location = new System.Drawing.Point(17, 93);
            this.labelTelDois.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelDois.Name = "labelTelDois";
            this.labelTelDois.Size = new System.Drawing.Size(83, 18);
            this.labelTelDois.TabIndex = 30;
            this.labelTelDois.Text = "Telefone 2:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelTelUm);
            this.groupBox3.Controls.Add(this.textTelUm);
            this.groupBox3.Controls.Add(this.comboTelUm);
            this.groupBox3.Controls.Add(this.labelTelDois);
            this.groupBox3.Controls.Add(this.comboTelDois);
            this.groupBox3.Controls.Add(this.textTelDois);
            this.groupBox3.Controls.Add(this.textEmail);
            this.groupBox3.Controls.Add(this.labelEmail);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox3.Location = new System.Drawing.Point(11, 424);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(612, 173);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // comboTelDois
            // 
            this.comboTelDois.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTelDois.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTelDois.FormattingEnabled = true;
            this.comboTelDois.Items.AddRange(new object[] {
            "Celular",
            "Fax",
            "Telefone Comercial ",
            "Telefone Fixo"});
            this.comboTelDois.Location = new System.Drawing.Point(106, 88);
            this.comboTelDois.Margin = new System.Windows.Forms.Padding(4);
            this.comboTelDois.Name = "comboTelDois";
            this.comboTelDois.Size = new System.Drawing.Size(272, 26);
            this.comboTelDois.TabIndex = 2;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.Black;
            this.labelTitulo.Location = new System.Drawing.Point(330, 47);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(372, 42);
            this.labelTitulo.TabIndex = 44;
            this.labelTitulo.Text = "Cadastro de Usuários";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.salvarToolStripButton1,
            this.toolStripButton2,
            this.toolStripSeparator2,
            this.recortarToolStripButton,
            this.copiarToolStripButton1,
            this.colarToolStripButton1,
            this.toolStripSeparator3,
            this.ajudaToolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.toolStrip1.Size = new System.Drawing.Size(1285, 25);
            this.toolStrip1.TabIndex = 46;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "&Salvar";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // salvarToolStripButton1
            // 
            this.salvarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton1.Image")));
            this.salvarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton1.Name = "salvarToolStripButton1";
            this.salvarToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton1.Text = "&Alterar";
            this.salvarToolStripButton1.Click += new System.EventHandler(this.salvarToolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "&Excluir";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // recortarToolStripButton
            // 
            this.recortarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.recortarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("recortarToolStripButton.Image")));
            this.recortarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.recortarToolStripButton.Name = "recortarToolStripButton";
            this.recortarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.recortarToolStripButton.Text = "Recor&tar";
            // 
            // copiarToolStripButton1
            // 
            this.copiarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton1.Image")));
            this.copiarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton1.Name = "copiarToolStripButton1";
            this.copiarToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton1.Text = "&Copiar";
            // 
            // colarToolStripButton1
            // 
            this.colarToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton1.Image")));
            this.colarToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton1.Name = "colarToolStripButton1";
            this.colarToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton1.Text = "C&olar";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton1
            // 
            this.ajudaToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton1.Image")));
            this.ajudaToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton1.Name = "ajudaToolStripButton1";
            this.ajudaToolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton1.Text = "&Ajuda";
            // 
            // salvarToolStripButton
            // 
            this.salvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.salvarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("salvarToolStripButton.Image")));
            this.salvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.salvarToolStripButton.Name = "salvarToolStripButton";
            this.salvarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.salvarToolStripButton.Text = "&Salvar";
            this.salvarToolStripButton.Click += new System.EventHandler(this.salvarToolStripButton1_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // copiarToolStripButton
            // 
            this.copiarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copiarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copiarToolStripButton.Image")));
            this.copiarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copiarToolStripButton.Name = "copiarToolStripButton";
            this.copiarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copiarToolStripButton.Text = "&Copiar";
            // 
            // colarToolStripButton
            // 
            this.colarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.colarToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("colarToolStripButton.Image")));
            this.colarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.colarToolStripButton.Name = "colarToolStripButton";
            this.colarToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.colarToolStripButton.Text = "C&olar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ajudaToolStripButton
            // 
            this.ajudaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ajudaToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ajudaToolStripButton.Image")));
            this.ajudaToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ajudaToolStripButton.Name = "ajudaToolStripButton";
            this.ajudaToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.ajudaToolStripButton.Text = "&Ajuda";
            // 
            // lblAtencao
            // 
            this.lblAtencao.AutoSize = true;
            this.lblAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencao.ForeColor = System.Drawing.Color.Red;
            this.lblAtencao.Location = new System.Drawing.Point(42, 608);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(0, 18);
            this.lblAtencao.TabIndex = 47;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(265, 51);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 26);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(608, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 14;
            this.label2.Text = "Departamentos:";
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Items.AddRange(new object[] {
            "Cliente",
            "Funcionario"});
            this.comboDepartamento.Location = new System.Drawing.Point(731, 104);
            this.comboDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(167, 26);
            this.comboDepartamento.TabIndex = 13;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1285, 635);
            this.Controls.Add(this.lblAtencao);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDados);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.labelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.helpProvider1.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Name = "frmUsuario";
            this.helpProvider1.SetShowHelp(this, true);
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gpbDados.ResumeLayout(false);
            this.gpbDados.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox gpbDados;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.TextBox textRua;
        private System.Windows.Forms.TextBox textComplemento;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelTelUm;
        private System.Windows.Forms.TextBox textTelUm;
        private System.Windows.Forms.ComboBox comboTelUm;
        private System.Windows.Forms.Label labelTelDois;
        private System.Windows.Forms.ComboBox comboTelDois;
        private System.Windows.Forms.TextBox textTelDois;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboTipo;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton;
        private System.Windows.Forms.ToolStripButton colarToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton1;
        private System.Windows.Forms.ToolStripButton colarToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton1;
        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboDepartamento;
    }
}