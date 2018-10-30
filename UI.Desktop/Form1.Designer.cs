namespace UI.Desktop
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelDadosPessoais = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelRG = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.textRG = new System.Windows.Forms.TextBox();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.labelSexo = new System.Windows.Forms.Label();
            this.comboSexo = new System.Windows.Forms.ComboBox();
            this.labelEndereço = new System.Windows.Forms.Label();
            this.labelRua = new System.Windows.Forms.Label();
            this.textRua = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.textN = new System.Windows.Forms.TextBox();
            this.labelCEP = new System.Windows.Forms.Label();
            this.textCEP = new System.Windows.Forms.TextBox();
            this.labelComplemento = new System.Windows.Forms.Label();
            this.textComplemento = new System.Windows.Forms.TextBox();
            this.labelBairro = new System.Windows.Forms.Label();
            this.textBairro = new System.Windows.Forms.TextBox();
            this.labelCidade = new System.Windows.Forms.Label();
            this.textTelUm = new System.Windows.Forms.TextBox();
            this.labelUF = new System.Windows.Forms.Label();
            this.comboUF = new System.Windows.Forms.ComboBox();
            this.labelContato = new System.Windows.Forms.Label();
            this.labelTelUm = new System.Windows.Forms.Label();
            this.comboTelUm = new System.Windows.Forms.ComboBox();
            this.labelTelDois = new System.Windows.Forms.Label();
            this.comboTelDois = new System.Windows.Forms.ComboBox();
            this.textTelDois = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textEmail = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.textCidade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTitulo.Location = new System.Drawing.Point(483, 64);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(372, 42);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Cadastro de Usuários";
            // 
            // labelDadosPessoais
            // 
            this.labelDadosPessoais.AutoSize = true;
            this.labelDadosPessoais.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDadosPessoais.Location = new System.Drawing.Point(36, 101);
            this.labelDadosPessoais.Name = "labelDadosPessoais";
            this.labelDadosPessoais.Size = new System.Drawing.Size(220, 32);
            this.labelDadosPessoais.TabIndex = 1;
            this.labelDadosPessoais.Text = "Dados Pessoais:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.ForeColor = System.Drawing.SystemColors.Control;
            this.labelNome.Location = new System.Drawing.Point(37, 147);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(70, 24);
            this.labelNome.TabIndex = 2;
            this.labelNome.Text = "Nome:";
            // 
            // textNome
            // 
            this.textNome.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textNome.Location = new System.Drawing.Point(107, 144);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(575, 32);
            this.textNome.TabIndex = 3;
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCPF.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCPF.Location = new System.Drawing.Point(701, 147);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(58, 24);
            this.labelCPF.TabIndex = 4;
            this.labelCPF.Text = "CPF:";
            // 
            // labelRG
            // 
            this.labelRG.AutoSize = true;
            this.labelRG.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRG.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRG.Location = new System.Drawing.Point(995, 149);
            this.labelRG.Name = "labelRG";
            this.labelRG.Size = new System.Drawing.Size(47, 24);
            this.labelRG.TabIndex = 5;
            this.labelRG.Text = "RG:";
            // 
            // textCPF
            // 
            this.textCPF.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCPF.Location = new System.Drawing.Point(760, 144);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(217, 32);
            this.textCPF.TabIndex = 6;
            // 
            // textRG
            // 
            this.textRG.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRG.Location = new System.Drawing.Point(1043, 144);
            this.textRG.Name = "textRG";
            this.textRG.Size = new System.Drawing.Size(217, 32);
            this.textRG.TabIndex = 7;
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.ForeColor = System.Drawing.SystemColors.Control;
            this.labelDataNascimento.Location = new System.Drawing.Point(37, 203);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(206, 24);
            this.labelDataNascimento.TabIndex = 8;
            this.labelDataNascimento.Text = "Data de Nascimento:";
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNascimento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimeNascimento.Location = new System.Drawing.Point(247, 197);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(511, 32);
            this.dateTimeNascimento.TabIndex = 9;
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelSexo.Location = new System.Drawing.Point(779, 203);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(64, 24);
            this.labelSexo.TabIndex = 10;
            this.labelSexo.Text = "Sexo:";
            // 
            // comboSexo
            // 
            this.comboSexo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboSexo.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboSexo.FormattingEnabled = true;
            this.comboSexo.Items.AddRange(new object[] {
            "Feminino",
            "Masculino"});
            this.comboSexo.Location = new System.Drawing.Point(844, 200);
            this.comboSexo.Name = "comboSexo";
            this.comboSexo.Size = new System.Drawing.Size(259, 32);
            this.comboSexo.TabIndex = 11;
            // 
            // labelEndereço
            // 
            this.labelEndereço.AutoSize = true;
            this.labelEndereço.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEndereço.Location = new System.Drawing.Point(36, 255);
            this.labelEndereço.Name = "labelEndereço";
            this.labelEndereço.Size = new System.Drawing.Size(139, 32);
            this.labelEndereço.TabIndex = 12;
            this.labelEndereço.Text = "Endereço:";
            // 
            // labelRua
            // 
            this.labelRua.AutoSize = true;
            this.labelRua.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRua.ForeColor = System.Drawing.SystemColors.Control;
            this.labelRua.Location = new System.Drawing.Point(37, 300);
            this.labelRua.Name = "labelRua";
            this.labelRua.Size = new System.Drawing.Size(54, 24);
            this.labelRua.TabIndex = 13;
            this.labelRua.Text = "Rua:";
            // 
            // textRua
            // 
            this.textRua.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRua.Location = new System.Drawing.Point(92, 295);
            this.textRua.Name = "textRua";
            this.textRua.Size = new System.Drawing.Size(396, 32);
            this.textRua.TabIndex = 14;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelN.ForeColor = System.Drawing.SystemColors.Control;
            this.labelN.Location = new System.Drawing.Point(531, 300);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(32, 24);
            this.labelN.TabIndex = 15;
            this.labelN.Text = "N°";
            // 
            // textN
            // 
            this.textN.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textN.Location = new System.Drawing.Point(561, 295);
            this.textN.Name = "textN";
            this.textN.Size = new System.Drawing.Size(67, 32);
            this.textN.TabIndex = 16;
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCEP.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCEP.Location = new System.Drawing.Point(664, 300);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(59, 24);
            this.labelCEP.TabIndex = 17;
            this.labelCEP.Text = "CEP:";
            // 
            // textCEP
            // 
            this.textCEP.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCEP.Location = new System.Drawing.Point(723, 295);
            this.textCEP.Name = "textCEP";
            this.textCEP.Size = new System.Drawing.Size(183, 32);
            this.textCEP.TabIndex = 18;
            this.textCEP.Text = "\r\n";
            // 
            // labelComplemento
            // 
            this.labelComplemento.AutoSize = true;
            this.labelComplemento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplemento.ForeColor = System.Drawing.SystemColors.Control;
            this.labelComplemento.Location = new System.Drawing.Point(37, 351);
            this.labelComplemento.Name = "labelComplemento";
            this.labelComplemento.Size = new System.Drawing.Size(143, 24);
            this.labelComplemento.TabIndex = 19;
            this.labelComplemento.Text = "Complemento:";
            // 
            // textComplemento
            // 
            this.textComplemento.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textComplemento.Location = new System.Drawing.Point(182, 346);
            this.textComplemento.Name = "textComplemento";
            this.textComplemento.Size = new System.Drawing.Size(307, 32);
            this.textComplemento.TabIndex = 20;
            // 
            // labelBairro
            // 
            this.labelBairro.AutoSize = true;
            this.labelBairro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBairro.ForeColor = System.Drawing.SystemColors.Control;
            this.labelBairro.Location = new System.Drawing.Point(935, 300);
            this.labelBairro.Name = "labelBairro";
            this.labelBairro.Size = new System.Drawing.Size(73, 24);
            this.labelBairro.TabIndex = 21;
            this.labelBairro.Text = "Bairro:";
            // 
            // textBairro
            // 
            this.textBairro.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBairro.Location = new System.Drawing.Point(1008, 295);
            this.textBairro.Name = "textBairro";
            this.textBairro.Size = new System.Drawing.Size(257, 32);
            this.textBairro.TabIndex = 22;
            this.textBairro.Text = "\r\n";
            // 
            // labelCidade
            // 
            this.labelCidade.AutoSize = true;
            this.labelCidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCidade.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCidade.Location = new System.Drawing.Point(531, 351);
            this.labelCidade.Name = "labelCidade";
            this.labelCidade.Size = new System.Drawing.Size(82, 24);
            this.labelCidade.TabIndex = 23;
            this.labelCidade.Text = "Cidade:";
            // 
            // textTelUm
            // 
            this.textTelUm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelUm.Location = new System.Drawing.Point(431, 439);
            this.textTelUm.Name = "textTelUm";
            this.textTelUm.Size = new System.Drawing.Size(191, 32);
            this.textTelUm.TabIndex = 24;
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.ForeColor = System.Drawing.SystemColors.Control;
            this.labelUF.Location = new System.Drawing.Point(829, 351);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(43, 24);
            this.labelUF.TabIndex = 25;
            this.labelUF.Text = "UF:";
            // 
            // comboUF
            // 
            this.comboUF.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.comboUF.Location = new System.Drawing.Point(872, 346);
            this.comboUF.Name = "comboUF";
            this.comboUF.Size = new System.Drawing.Size(259, 32);
            this.comboUF.TabIndex = 26;
            // 
            // labelContato
            // 
            this.labelContato.AutoSize = true;
            this.labelContato.ForeColor = System.Drawing.SystemColors.Control;
            this.labelContato.Location = new System.Drawing.Point(36, 397);
            this.labelContato.Name = "labelContato";
            this.labelContato.Size = new System.Drawing.Size(119, 32);
            this.labelContato.TabIndex = 27;
            this.labelContato.Text = "Contato:";
            // 
            // labelTelUm
            // 
            this.labelTelUm.AutoSize = true;
            this.labelTelUm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelUm.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTelUm.Location = new System.Drawing.Point(37, 445);
            this.labelTelUm.Name = "labelTelUm";
            this.labelTelUm.Size = new System.Drawing.Size(113, 24);
            this.labelTelUm.TabIndex = 28;
            this.labelTelUm.Text = "Telefone 1:";
            // 
            // comboTelUm
            // 
            this.comboTelUm.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTelUm.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTelUm.FormattingEnabled = true;
            this.comboTelUm.Items.AddRange(new object[] {
            "Celular",
            "Fax",
            "Telefone Comercial ",
            "Telefone Fixo"});
            this.comboTelUm.Location = new System.Drawing.Point(153, 439);
            this.comboTelUm.Name = "comboTelUm";
            this.comboTelUm.Size = new System.Drawing.Size(272, 32);
            this.comboTelUm.TabIndex = 29;
            // 
            // labelTelDois
            // 
            this.labelTelDois.AutoSize = true;
            this.labelTelDois.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelDois.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTelDois.Location = new System.Drawing.Point(37, 491);
            this.labelTelDois.Name = "labelTelDois";
            this.labelTelDois.Size = new System.Drawing.Size(113, 24);
            this.labelTelDois.TabIndex = 30;
            this.labelTelDois.Text = "Telefone 2:";
            // 
            // comboTelDois
            // 
            this.comboTelDois.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTelDois.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTelDois.FormattingEnabled = true;
            this.comboTelDois.Items.AddRange(new object[] {
            "Celular",
            "Fax",
            "Telefone Comercial ",
            "Telefone Fixo"});
            this.comboTelDois.Location = new System.Drawing.Point(153, 485);
            this.comboTelDois.Name = "comboTelDois";
            this.comboTelDois.Size = new System.Drawing.Size(272, 32);
            this.comboTelDois.TabIndex = 31;
            // 
            // textTelDois
            // 
            this.textTelDois.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textTelDois.Location = new System.Drawing.Point(431, 487);
            this.textTelDois.Name = "textTelDois";
            this.textTelDois.Size = new System.Drawing.Size(191, 32);
            this.textTelDois.TabIndex = 32;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEmail.Location = new System.Drawing.Point(37, 549);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(74, 24);
            this.labelEmail.TabIndex = 33;
            this.labelEmail.Text = "E-mail:";
            // 
            // textEmail
            // 
            this.textEmail.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textEmail.Location = new System.Drawing.Point(111, 543);
            this.textEmail.Name = "textEmail";
            this.textEmail.Size = new System.Drawing.Size(511, 32);
            this.textEmail.TabIndex = 34;
            // 
            // btnLimpar
            // 
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLimpar.Location = new System.Drawing.Point(877, 539);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(117, 43);
            this.btnLimpar.TabIndex = 35;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCadastrar.Location = new System.Drawing.Point(1020, 537);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(140, 43);
            this.btnCadastrar.TabIndex = 36;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // textCidade
            // 
            this.textCidade.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCidade.Location = new System.Drawing.Point(613, 345);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(183, 32);
            this.textCidade.TabIndex = 37;
            this.textCidade.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 625);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 32);
            this.label1.TabIndex = 38;
            this.label1.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1303, 665);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.textEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textTelDois);
            this.Controls.Add(this.comboTelDois);
            this.Controls.Add(this.labelTelDois);
            this.Controls.Add(this.comboTelUm);
            this.Controls.Add(this.labelTelUm);
            this.Controls.Add(this.labelContato);
            this.Controls.Add(this.comboUF);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.textTelUm);
            this.Controls.Add(this.labelCidade);
            this.Controls.Add(this.textBairro);
            this.Controls.Add(this.labelBairro);
            this.Controls.Add(this.textComplemento);
            this.Controls.Add(this.labelComplemento);
            this.Controls.Add(this.textCEP);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.textN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.textRua);
            this.Controls.Add(this.labelRua);
            this.Controls.Add(this.labelEndereço);
            this.Controls.Add(this.comboSexo);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.dateTimeNascimento);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.textRG);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.labelRG);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.labelDadosPessoais);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelDadosPessoais;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelRG;
        private System.Windows.Forms.TextBox textCPF;
        private System.Windows.Forms.TextBox textRG;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.ComboBox comboSexo;
        private System.Windows.Forms.Label labelEndereço;
        private System.Windows.Forms.Label labelRua;
        private System.Windows.Forms.TextBox textRua;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textN;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.TextBox textCEP;
        private System.Windows.Forms.Label labelComplemento;
        private System.Windows.Forms.TextBox textComplemento;
        private System.Windows.Forms.Label labelBairro;
        private System.Windows.Forms.TextBox textBairro;
        private System.Windows.Forms.Label labelCidade;
        private System.Windows.Forms.TextBox textTelUm;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.ComboBox comboUF;
        private System.Windows.Forms.Label labelContato;
        private System.Windows.Forms.Label labelTelUm;
        private System.Windows.Forms.ComboBox comboTelUm;
        private System.Windows.Forms.Label labelTelDois;
        private System.Windows.Forms.ComboBox comboTelDois;
        private System.Windows.Forms.TextBox textTelDois;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textEmail;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.TextBox textCidade;
        private System.Windows.Forms.Label label1;
    }
}

