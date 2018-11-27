namespace UI.Desktop
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.fonteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripUsuario = new System.Windows.Forms.ToolStripButton();
            this.toolStripChamado = new System.Windows.Forms.ToolStripButton();
            this.toolStripChamadoDashBoard = new System.Windows.Forms.ToolStripButton();
            this.toolStripLogin = new System.Windows.Forms.ToolStripButton();
            this.toolStripRelatorio = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.prechamado = new System.Windows.Forms.ToolStripSplitButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.alertaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem1});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip2.ShowItemToolTips = true;
            this.menuStrip2.Size = new System.Drawing.Size(1362, 24);
            this.menuStrip2.TabIndex = 2;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fonteToolStripMenuItem,
            this.toolStripSeparator1,
            this.configurarToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem3.Text = "Config";
            // 
            // fonteToolStripMenuItem
            // 
            this.fonteToolStripMenuItem.Name = "fonteToolStripMenuItem";
            this.fonteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fonteToolStripMenuItem.Text = "&Fonte";
            this.fonteToolStripMenuItem.Click += new System.EventHandler(this.fonteToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // configurarToolStripMenuItem
            // 
            this.configurarToolStripMenuItem.Name = "configurarToolStripMenuItem";
            this.configurarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.configurarToolStripMenuItem.Text = "Configurar&";
            this.configurarToolStripMenuItem.Click += new System.EventHandler(this.configurarToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckOnClick = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2});
            this.toolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem1.Image")));
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(28, 20);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.AutoSize = false;
            this.toolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem2.Image")));
            this.toolStripMenuItem2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.toolStripMenuItem2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItem2.MergeAction = System.Windows.Forms.MergeAction.Insert;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Always;
            this.toolStripMenuItem2.Size = new System.Drawing.Size(269, 112);
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripUsuario,
            this.toolStripChamado,
            this.toolStripChamadoDashBoard,
            this.toolStripLogin,
            this.toolStripRelatorio});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(110, 668);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripUsuario
            // 
            this.toolStripUsuario.Image = ((System.Drawing.Image)(resources.GetObject("toolStripUsuario.Image")));
            this.toolStripUsuario.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripUsuario.Name = "toolStripUsuario";
            this.toolStripUsuario.Size = new System.Drawing.Size(107, 124);
            this.toolStripUsuario.Text = "Usuarios";
            this.toolStripUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripUsuario.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripChamado
            // 
            this.toolStripChamado.Image = ((System.Drawing.Image)(resources.GetObject("toolStripChamado.Image")));
            this.toolStripChamado.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripChamado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChamado.Name = "toolStripChamado";
            this.toolStripChamado.Size = new System.Drawing.Size(107, 124);
            this.toolStripChamado.Text = "Chamados";
            this.toolStripChamado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripChamado.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripChamadoDashBoard
            // 
            this.toolStripChamadoDashBoard.Image = ((System.Drawing.Image)(resources.GetObject("toolStripChamadoDashBoard.Image")));
            this.toolStripChamadoDashBoard.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripChamadoDashBoard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripChamadoDashBoard.Name = "toolStripChamadoDashBoard";
            this.toolStripChamadoDashBoard.Size = new System.Drawing.Size(107, 124);
            this.toolStripChamadoDashBoard.Text = "DashBoard";
            this.toolStripChamadoDashBoard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripChamadoDashBoard.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripLogin
            // 
            this.toolStripLogin.Image = ((System.Drawing.Image)(resources.GetObject("toolStripLogin.Image")));
            this.toolStripLogin.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripLogin.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripLogin.Name = "toolStripLogin";
            this.toolStripLogin.Size = new System.Drawing.Size(107, 124);
            this.toolStripLogin.Text = "Login";
            this.toolStripLogin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripLogin.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripRelatorio
            // 
            this.toolStripRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("toolStripRelatorio.Image")));
            this.toolStripRelatorio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripRelatorio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripRelatorio.Name = "toolStripRelatorio";
            this.toolStripRelatorio.Size = new System.Drawing.Size(107, 124);
            this.toolStripRelatorio.Text = "Relatorio";
            this.toolStripRelatorio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripRelatorio.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel5,
            this.prechamado});
            this.statusStrip1.Location = new System.Drawing.Point(110, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1252, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel2.Text = "toolStripStatusLabel2";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel3.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel4.Text = "toolStripStatusLabel3";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(805, 15);
            this.toolStripStatusLabel5.Text = resources.GetString("toolStripStatusLabel5.Text");
            // 
            // prechamado
            // 
            this.prechamado.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.prechamado.Image = ((System.Drawing.Image)(resources.GetObject("prechamado.Image")));
            this.prechamado.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.prechamado.Name = "prechamado";
            this.prechamado.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.prechamado.Size = new System.Drawing.Size(32, 20);
            this.prechamado.Text = "toolStripSplitButton1";
            this.prechamado.ButtonClick += new System.EventHandler(this.prechamado_ButtonClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // alertaToolStripMenuItem
            // 
            this.alertaToolStripMenuItem.Name = "alertaToolStripMenuItem";
            this.alertaToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.alertaToolStripMenuItem.Text = "Alerta";
            this.alertaToolStripMenuItem.Click += new System.EventHandler(this.alertaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alertaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.ShowCheckMargin = true;
            this.contextMenuStrip1.Size = new System.Drawing.Size(128, 26);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1362, 692);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "MenuPrincipal";
            this.ShowIcon = false;
            this.Text = "MenuPrincipal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripRelatorio;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripButton toolStripChamadoDashBoard;
        private System.Windows.Forms.ToolStripButton toolStripUsuario;
        private System.Windows.Forms.ToolStripButton toolStripLogin;
        private System.Windows.Forms.ToolStripButton toolStripChamado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem fonteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configurarToolStripMenuItem;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.HelpProvider helpProvider1;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alertaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSplitButton prechamado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
    }
}