namespace UI.Desktop.Chamado
{
    partial class frmChamado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChamado));
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
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextobs = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelChamado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonStatus1 = new System.Windows.Forms.Button();
            this.buttonStatus2 = new System.Windows.Forms.Button();
            this.buttonDepartamento = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.picturePrioridade = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataEntrega = new System.Windows.Forms.Label();
            this.DataInicio = new System.Windows.Forms.Label();
            this.labelUF = new System.Windows.Forms.Label();
            this.comboTipochamado = new System.Windows.Forms.ComboBox();
            this.comboCliente = new System.Windows.Forms.ComboBox();
            this.comboFuncionario = new System.Windows.Forms.ComboBox();
            this.richTextDescricao = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboPrioridade = new System.Windows.Forms.ComboBox();
            this.comboProduto = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.comboDepartamento = new System.Windows.Forms.ComboBox();
            this.lblAtencao = new System.Windows.Forms.Label();
            this.labelPreviData = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelDataNascimento = new System.Windows.Forms.Label();
            this.dateGarantia = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAtual = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrioridade)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
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
            this.toolStrip1.Size = new System.Drawing.Size(1286, 25);
            this.toolStrip1.TabIndex = 48;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
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
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextobs);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox1.Location = new System.Drawing.Point(12, 381);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(716, 214);
            this.groupBox1.TabIndex = 49;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Observação";
            // 
            // richTextobs
            // 
            this.richTextobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextobs.Font = new System.Drawing.Font("Arial", 10F);
            this.richTextobs.Location = new System.Drawing.Point(3, 35);
            this.richTextobs.Name = "richTextobs";
            this.richTextobs.Size = new System.Drawing.Size(710, 176);
            this.richTextobs.TabIndex = 0;
            this.richTextobs.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox2.Location = new System.Drawing.Point(777, 416);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(471, 202);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sugestão";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Font = new System.Drawing.Font("Arial", 11F);
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView2.Location = new System.Drawing.Point(3, 35);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(465, 164);
            this.dataGridView2.TabIndex = 1;
            this.dataGridView2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellClick);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnPesquisar);
            this.groupBox3.Controls.Add(this.dataGridView1);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox3.Location = new System.Drawing.Point(820, 35);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(428, 375);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pesquisa";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.BackgroundImage")));
            this.btnPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.Location = new System.Drawing.Point(389, 51);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(33, 26);
            this.btnPesquisar.TabIndex = 4;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
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
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(415, 286);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(7, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(375, 26);
            this.textBox2.TabIndex = 0;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelChamado
            // 
            this.labelChamado.AutoSize = true;
            this.labelChamado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelChamado.ForeColor = System.Drawing.Color.Black;
            this.labelChamado.Location = new System.Drawing.Point(272, 60);
            this.labelChamado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelChamado.Name = "labelChamado";
            this.labelChamado.Size = new System.Drawing.Size(81, 18);
            this.labelChamado.TabIndex = 11;
            this.labelChamado.Text = "Chamado:";
            this.labelChamado.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelChamado.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(203, 139);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 52;
            this.label1.Text = "Cliente:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(171, 167);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            // 
            // buttonStatus1
            // 
            this.buttonStatus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus1.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonStatus1.Location = new System.Drawing.Point(491, 77);
            this.buttonStatus1.Name = "buttonStatus1";
            this.buttonStatus1.Size = new System.Drawing.Size(135, 26);
            this.buttonStatus1.TabIndex = 55;
            this.buttonStatus1.UseVisualStyleBackColor = true;
            this.buttonStatus1.Click += new System.EventHandler(this.buttonStatus1_Click);
            // 
            // buttonStatus2
            // 
            this.buttonStatus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStatus2.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonStatus2.Location = new System.Drawing.Point(632, 77);
            this.buttonStatus2.Name = "buttonStatus2";
            this.buttonStatus2.Size = new System.Drawing.Size(135, 26);
            this.buttonStatus2.TabIndex = 56;
            this.buttonStatus2.Text = "Pré-Chamado";
            this.buttonStatus2.UseVisualStyleBackColor = true;
            this.buttonStatus2.Click += new System.EventHandler(this.buttonStatus2_Click);
            // 
            // buttonDepartamento
            // 
            this.buttonDepartamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDepartamento.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonDepartamento.Location = new System.Drawing.Point(218, 232);
            this.buttonDepartamento.Name = "buttonDepartamento";
            this.buttonDepartamento.Size = new System.Drawing.Size(135, 26);
            this.buttonDepartamento.TabIndex = 57;
            this.buttonDepartamento.Text = "Departamento";
            this.buttonDepartamento.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(376, 235);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 18);
            this.label2.TabIndex = 58;
            this.label2.Text = "Prioridade:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // picturePrioridade
            // 
            this.picturePrioridade.BackColor = System.Drawing.Color.Transparent;
            this.picturePrioridade.Location = new System.Drawing.Point(469, 235);
            this.picturePrioridade.Name = "picturePrioridade";
            this.picturePrioridade.Size = new System.Drawing.Size(29, 19);
            this.picturePrioridade.TabIndex = 59;
            this.picturePrioridade.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(622, 136);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 15);
            this.label3.TabIndex = 60;
            this.label3.Text = "Início:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label3.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(622, 164);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 15);
            this.label4.TabIndex = 61;
            this.label4.Text = "Entrega:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // DataEntrega
            // 
            this.DataEntrega.AutoSize = true;
            this.DataEntrega.Font = new System.Drawing.Font("Arial", 9F);
            this.DataEntrega.ForeColor = System.Drawing.Color.Black;
            this.DataEntrega.Location = new System.Drawing.Point(686, 164);
            this.DataEntrega.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataEntrega.Name = "DataEntrega";
            this.DataEntrega.Size = new System.Drawing.Size(67, 15);
            this.DataEntrega.TabIndex = 62;
            this.DataEntrega.Text = "11/11/2018";
            this.DataEntrega.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DataEntrega.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // DataInicio
            // 
            this.DataInicio.AutoSize = true;
            this.DataInicio.Font = new System.Drawing.Font("Arial", 9F);
            this.DataInicio.ForeColor = System.Drawing.Color.Black;
            this.DataInicio.Location = new System.Drawing.Point(677, 136);
            this.DataInicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DataInicio.Name = "DataInicio";
            this.DataInicio.Size = new System.Drawing.Size(67, 15);
            this.DataInicio.TabIndex = 63;
            this.DataInicio.Text = "11/11/2018";
            this.DataInicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DataInicio.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // labelUF
            // 
            this.labelUF.AutoSize = true;
            this.labelUF.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUF.ForeColor = System.Drawing.Color.Black;
            this.labelUF.Location = new System.Drawing.Point(532, 235);
            this.labelUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUF.Name = "labelUF";
            this.labelUF.Size = new System.Drawing.Size(133, 18);
            this.labelUF.TabIndex = 66;
            this.labelUF.Text = "Tipo de chamado:";
            this.labelUF.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // comboTipochamado
            // 
            this.comboTipochamado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipochamado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipochamado.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboTipochamado.FormattingEnabled = true;
            this.comboTipochamado.Location = new System.Drawing.Point(671, 232);
            this.comboTipochamado.Margin = new System.Windows.Forms.Padding(4);
            this.comboTipochamado.Name = "comboTipochamado";
            this.comboTipochamado.Size = new System.Drawing.Size(142, 26);
            this.comboTipochamado.TabIndex = 2;
            this.comboTipochamado.SelectedIndexChanged += new System.EventHandler(this.comboTipochamado_SelectedIndexChanged);
            // 
            // comboCliente
            // 
            this.comboCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboCliente.FormattingEnabled = true;
            this.comboCliente.Location = new System.Drawing.Point(272, 136);
            this.comboCliente.Margin = new System.Windows.Forms.Padding(4);
            this.comboCliente.Name = "comboCliente";
            this.comboCliente.Size = new System.Drawing.Size(180, 26);
            this.comboCliente.TabIndex = 0;
            // 
            // comboFuncionario
            // 
            this.comboFuncionario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboFuncionario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboFuncionario.FormattingEnabled = true;
            this.comboFuncionario.Location = new System.Drawing.Point(11, 255);
            this.comboFuncionario.Margin = new System.Windows.Forms.Padding(4);
            this.comboFuncionario.Name = "comboFuncionario";
            this.comboFuncionario.Size = new System.Drawing.Size(170, 26);
            this.comboFuncionario.TabIndex = 3;
            // 
            // richTextDescricao
            // 
            this.richTextDescricao.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextDescricao.Font = new System.Drawing.Font("Arial", 12F);
            this.richTextDescricao.Location = new System.Drawing.Point(3, 35);
            this.richTextDescricao.Name = "richTextDescricao";
            this.richTextDescricao.Size = new System.Drawing.Size(778, 49);
            this.richTextDescricao.TabIndex = 0;
            this.richTextDescricao.Text = "";
            this.richTextDescricao.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextDescricao);
            this.groupBox4.Font = new System.Drawing.Font("Arial", 20.25F);
            this.groupBox4.Location = new System.Drawing.Point(11, 288);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(784, 87);
            this.groupBox4.TabIndex = 71;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Descrição";
            // 
            // comboPrioridade
            // 
            this.comboPrioridade.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPrioridade.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboPrioridade.FormattingEnabled = true;
            this.comboPrioridade.Location = new System.Drawing.Point(379, 261);
            this.comboPrioridade.Margin = new System.Windows.Forms.Padding(4);
            this.comboPrioridade.Name = "comboPrioridade";
            this.comboPrioridade.Size = new System.Drawing.Size(119, 26);
            this.comboPrioridade.TabIndex = 5;
            this.comboPrioridade.SelectedIndexChanged += new System.EventHandler(this.comboPrioridade_SelectedIndexChanged);
            // 
            // comboProduto
            // 
            this.comboProduto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboProduto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboProduto.FormattingEnabled = true;
            this.comboProduto.Location = new System.Drawing.Point(272, 180);
            this.comboProduto.Margin = new System.Windows.Forms.Padding(4);
            this.comboProduto.Name = "comboProduto";
            this.comboProduto.Size = new System.Drawing.Size(280, 26);
            this.comboProduto.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(203, 183);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 18);
            this.label5.TabIndex = 73;
            this.label5.Text = "Produto:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label5.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // comboDepartamento
            // 
            this.comboDepartamento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboDepartamento.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboDepartamento.FormattingEnabled = true;
            this.comboDepartamento.Location = new System.Drawing.Point(218, 261);
            this.comboDepartamento.Margin = new System.Windows.Forms.Padding(4);
            this.comboDepartamento.Name = "comboDepartamento";
            this.comboDepartamento.Size = new System.Drawing.Size(133, 26);
            this.comboDepartamento.TabIndex = 4;
            this.comboDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboDepartamento_SelectedIndexChanged);
            // 
            // lblAtencao
            // 
            this.lblAtencao.AutoSize = true;
            this.lblAtencao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtencao.ForeColor = System.Drawing.Color.Red;
            this.lblAtencao.Location = new System.Drawing.Point(38, 608);
            this.lblAtencao.Name = "lblAtencao";
            this.lblAtencao.Size = new System.Drawing.Size(0, 18);
            this.lblAtencao.TabIndex = 76;
            // 
            // labelPreviData
            // 
            this.labelPreviData.AutoSize = true;
            this.labelPreviData.Font = new System.Drawing.Font("Arial", 9F);
            this.labelPreviData.ForeColor = System.Drawing.Color.Black;
            this.labelPreviData.Location = new System.Drawing.Point(728, 186);
            this.labelPreviData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPreviData.Name = "labelPreviData";
            this.labelPreviData.Size = new System.Drawing.Size(67, 15);
            this.labelPreviData.TabIndex = 78;
            this.labelPreviData.Text = "11/11/2018";
            this.labelPreviData.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelPreviData.Click += new System.EventHandler(this.labelPreviData_Click);
            this.labelPreviData.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F);
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(622, 186);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 77;
            this.label7.Text = "Previsão Entrega:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label7.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // labelDataNascimento
            // 
            this.labelDataNascimento.AutoSize = true;
            this.labelDataNascimento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.labelDataNascimento.Location = new System.Drawing.Point(525, 278);
            this.labelDataNascimento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDataNascimento.Name = "labelDataNascimento";
            this.labelDataNascimento.Size = new System.Drawing.Size(124, 18);
            this.labelDataNascimento.TabIndex = 80;
            this.labelDataNascimento.Text = "Data de Garatia:";
            this.labelDataNascimento.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // dateGarantia
            // 
            this.dateGarantia.CalendarFont = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGarantia.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateGarantia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateGarantia.Location = new System.Drawing.Point(650, 273);
            this.dateGarantia.Margin = new System.Windows.Forms.Padding(4);
            this.dateGarantia.MaxDate = new System.DateTime(2018, 12, 31, 0, 0, 0, 0);
            this.dateGarantia.Name = "dateGarantia";
            this.dateGarantia.Size = new System.Drawing.Size(117, 26);
            this.dateGarantia.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(52, 235);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 18);
            this.label6.TabIndex = 81;
            this.label6.Text = "Funcionario";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label6.MouseLeave += new System.EventHandler(this.LabelLeave);
            // 
            // buttonAtual
            // 
            this.buttonAtual.Enabled = false;
            this.buttonAtual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAtual.Font = new System.Drawing.Font("Arial", 10F);
            this.buttonAtual.Location = new System.Drawing.Point(559, 37);
            this.buttonAtual.Name = "buttonAtual";
            this.buttonAtual.Size = new System.Drawing.Size(135, 26);
            this.buttonAtual.TabIndex = 82;
            this.buttonAtual.UseVisualStyleBackColor = true;
            // 
            // frmChamado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 635);
            this.Controls.Add(this.buttonAtual);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelDataNascimento);
            this.Controls.Add(this.dateGarantia);
            this.Controls.Add(this.labelPreviData);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAtencao);
            this.Controls.Add(this.comboDepartamento);
            this.Controls.Add(this.comboProduto);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboPrioridade);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.comboFuncionario);
            this.Controls.Add(this.comboCliente);
            this.Controls.Add(this.labelUF);
            this.Controls.Add(this.comboTipochamado);
            this.Controls.Add(this.DataInicio);
            this.Controls.Add(this.DataEntrega);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.picturePrioridade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonDepartamento);
            this.Controls.Add(this.buttonStatus2);
            this.Controls.Add(this.buttonStatus1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelChamado);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmChamado";
            this.Text = "frmChamado";
            this.Load += new System.EventHandler(this.frmChamado_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picturePrioridade)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton salvarToolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton recortarToolStripButton;
        private System.Windows.Forms.ToolStripButton copiarToolStripButton1;
        private System.Windows.Forms.ToolStripButton colarToolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ajudaToolStripButton1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label DataInicio;
        private System.Windows.Forms.Label DataEntrega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picturePrioridade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonDepartamento;
        private System.Windows.Forms.Button buttonStatus2;
        private System.Windows.Forms.Button buttonStatus1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelChamado;
        private System.Windows.Forms.RichTextBox richTextobs;
        private System.Windows.Forms.ComboBox comboFuncionario;
        private System.Windows.Forms.ComboBox comboCliente;
        private System.Windows.Forms.Label labelUF;
        private System.Windows.Forms.ComboBox comboTipochamado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextDescricao;
        private System.Windows.Forms.ComboBox comboPrioridade;
        private System.Windows.Forms.ComboBox comboProduto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboDepartamento;
        private System.Windows.Forms.Label lblAtencao;
        private System.Windows.Forms.Label labelPreviData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelDataNascimento;
        private System.Windows.Forms.DateTimePicker dateGarantia;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button buttonAtual;
    }
}