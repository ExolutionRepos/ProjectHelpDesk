namespace UI.Desktop.Chamado
{
    partial class frmDashBoard
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
            this.groupAberto = new System.Windows.Forms.GroupBox();
            this.tableAberto = new System.Windows.Forms.TableLayoutPanel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupAndamento = new System.Windows.Forms.GroupBox();
            this.tableAndamento = new System.Windows.Forms.TableLayoutPanel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.groupPendente = new System.Windows.Forms.GroupBox();
            this.tablePendente = new System.Windows.Forms.TableLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.groupFinalizado = new System.Windows.Forms.GroupBox();
            this.tableFinalizado = new System.Windows.Forms.TableLayoutPanel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupAberto.SuspendLayout();
            this.tableAberto.SuspendLayout();
            this.groupAndamento.SuspendLayout();
            this.tableAndamento.SuspendLayout();
            this.groupPendente.SuspendLayout();
            this.tablePendente.SuspendLayout();
            this.groupFinalizado.SuspendLayout();
            this.tableFinalizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupAberto
            // 
            this.groupAberto.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupAberto.Controls.Add(this.tableAberto);
            this.groupAberto.Location = new System.Drawing.Point(26, 75);
            this.groupAberto.Name = "groupAberto";
            this.groupAberto.Size = new System.Drawing.Size(252, 557);
            this.groupAberto.TabIndex = 0;
            this.groupAberto.TabStop = false;
            // 
            // tableAberto
            // 
            this.tableAberto.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableAberto.ColumnCount = 1;
            this.tableAberto.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAberto.Controls.Add(this.panel11, 0, 4);
            this.tableAberto.Controls.Add(this.panel3, 0, 2);
            this.tableAberto.Controls.Add(this.panel2, 0, 1);
            this.tableAberto.Controls.Add(this.panel1, 0, 0);
            this.tableAberto.Controls.Add(this.flowLayoutPanel1, 0, 3);
            this.tableAberto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAberto.Location = new System.Drawing.Point(3, 16);
            this.tableAberto.Name = "tableAberto";
            this.tableAberto.RowCount = 5;
            this.tableAberto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAberto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAberto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAberto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAberto.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAberto.Size = new System.Drawing.Size(246, 538);
            this.tableAberto.TabIndex = 0;
            // 
            // panel11
            // 
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(6, 498);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(234, 114);
            this.panel11.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(6, 252);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(234, 114);
            this.panel3.TabIndex = 2;
            this.panel3.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel3.DragEnter += new System.Windows.Forms.DragEventHandler(this.ControlaEfeito);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(6, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(234, 114);
            this.panel2.TabIndex = 1;
            this.panel2.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel2.DragEnter += new System.Windows.Forms.DragEventHandler(this.ControlaEfeito);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 114);
            this.panel1.TabIndex = 0;
            this.panel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            this.panel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.ControlaEfeito);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 375);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(234, 114);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // groupAndamento
            // 
            this.groupAndamento.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupAndamento.Controls.Add(this.tableAndamento);
            this.groupAndamento.Location = new System.Drawing.Point(290, 75);
            this.groupAndamento.Name = "groupAndamento";
            this.groupAndamento.Size = new System.Drawing.Size(252, 557);
            this.groupAndamento.TabIndex = 1;
            this.groupAndamento.TabStop = false;
            this.groupAndamento.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // tableAndamento
            // 
            this.tableAndamento.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableAndamento.ColumnCount = 1;
            this.tableAndamento.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableAndamento.Controls.Add(this.panel10, 0, 4);
            this.tableAndamento.Controls.Add(this.panel9, 0, 3);
            this.tableAndamento.Controls.Add(this.panel8, 0, 2);
            this.tableAndamento.Controls.Add(this.panel6, 0, 1);
            this.tableAndamento.Controls.Add(this.panel4, 0, 0);
            this.tableAndamento.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableAndamento.Location = new System.Drawing.Point(3, 16);
            this.tableAndamento.Name = "tableAndamento";
            this.tableAndamento.RowCount = 5;
            this.tableAndamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAndamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAndamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAndamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAndamento.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableAndamento.Size = new System.Drawing.Size(246, 538);
            this.tableAndamento.TabIndex = 1;
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(6, 498);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(234, 114);
            this.panel10.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel9.Location = new System.Drawing.Point(6, 375);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(234, 114);
            this.panel9.TabIndex = 4;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(6, 252);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(234, 114);
            this.panel8.TabIndex = 3;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(6, 129);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(234, 114);
            this.panel6.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(6, 6);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(234, 114);
            this.panel4.TabIndex = 1;
            this.panel4.Tag = "0";
            // 
            // groupPendente
            // 
            this.groupPendente.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupPendente.Controls.Add(this.tablePendente);
            this.groupPendente.Location = new System.Drawing.Point(557, 75);
            this.groupPendente.Name = "groupPendente";
            this.groupPendente.Size = new System.Drawing.Size(252, 557);
            this.groupPendente.TabIndex = 2;
            this.groupPendente.TabStop = false;
            // 
            // tablePendente
            // 
            this.tablePendente.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tablePendente.ColumnCount = 1;
            this.tablePendente.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePendente.Controls.Add(this.panel5, 0, 4);
            this.tablePendente.Controls.Add(this.panel7, 0, 3);
            this.tablePendente.Controls.Add(this.panel12, 0, 2);
            this.tablePendente.Controls.Add(this.panel13, 0, 1);
            this.tablePendente.Controls.Add(this.panel14, 0, 0);
            this.tablePendente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePendente.Location = new System.Drawing.Point(3, 16);
            this.tablePendente.Name = "tablePendente";
            this.tablePendente.RowCount = 5;
            this.tablePendente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePendente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePendente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePendente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePendente.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tablePendente.Size = new System.Drawing.Size(246, 538);
            this.tablePendente.TabIndex = 2;
            this.tablePendente.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(6, 498);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(234, 114);
            this.panel5.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(6, 375);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(234, 114);
            this.panel7.TabIndex = 4;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel12.Location = new System.Drawing.Point(6, 252);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(234, 114);
            this.panel12.TabIndex = 3;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(6, 129);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(234, 114);
            this.panel13.TabIndex = 2;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel14.Location = new System.Drawing.Point(6, 6);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(234, 114);
            this.panel14.TabIndex = 1;
            // 
            // groupFinalizado
            // 
            this.groupFinalizado.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupFinalizado.Controls.Add(this.tableFinalizado);
            this.groupFinalizado.Location = new System.Drawing.Point(828, 75);
            this.groupFinalizado.Name = "groupFinalizado";
            this.groupFinalizado.Size = new System.Drawing.Size(252, 557);
            this.groupFinalizado.TabIndex = 4;
            this.groupFinalizado.TabStop = false;
            // 
            // tableFinalizado
            // 
            this.tableFinalizado.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.tableFinalizado.ColumnCount = 1;
            this.tableFinalizado.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableFinalizado.Controls.Add(this.panel15, 0, 4);
            this.tableFinalizado.Controls.Add(this.panel16, 0, 3);
            this.tableFinalizado.Controls.Add(this.panel17, 0, 2);
            this.tableFinalizado.Controls.Add(this.panel18, 0, 1);
            this.tableFinalizado.Controls.Add(this.panel19, 0, 0);
            this.tableFinalizado.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableFinalizado.Location = new System.Drawing.Point(3, 16);
            this.tableFinalizado.Name = "tableFinalizado";
            this.tableFinalizado.RowCount = 5;
            this.tableFinalizado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableFinalizado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableFinalizado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableFinalizado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableFinalizado.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableFinalizado.Size = new System.Drawing.Size(246, 538);
            this.tableFinalizado.TabIndex = 2;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(6, 498);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(234, 114);
            this.panel15.TabIndex = 5;
            // 
            // panel16
            // 
            this.panel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel16.Location = new System.Drawing.Point(6, 375);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(234, 114);
            this.panel16.TabIndex = 4;
            // 
            // panel17
            // 
            this.panel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel17.Location = new System.Drawing.Point(6, 252);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(234, 114);
            this.panel17.TabIndex = 3;
            // 
            // panel18
            // 
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(6, 129);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(234, 114);
            this.panel18.TabIndex = 2;
            // 
            // panel19
            // 
            this.panel19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel19.Location = new System.Drawing.Point(6, 6);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(234, 114);
            this.panel19.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 31);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aberto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(296, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(125, 31);
            this.label2.TabIndex = 6;
            this.label2.Text = "Andamento";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(574, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 31);
            this.label3.TabIndex = 7;
            this.label3.Text = "Pendente";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Narrow", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(849, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 31);
            this.label4.TabIndex = 8;
            this.label4.Text = "Finalizado";
            // 
            // frmDashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 635);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupFinalizado);
            this.Controls.Add(this.groupPendente);
            this.Controls.Add(this.groupAndamento);
            this.Controls.Add(this.groupAberto);
            this.Name = "frmDashBoard";
            this.Tag = "0";
            this.Text = "frmDashBoard";
            this.Load += new System.EventHandler(this.frmDashBoard_Load);
            this.groupAberto.ResumeLayout(false);
            this.tableAberto.ResumeLayout(false);
            this.groupAndamento.ResumeLayout(false);
            this.tableAndamento.ResumeLayout(false);
            this.groupPendente.ResumeLayout(false);
            this.tablePendente.ResumeLayout(false);
            this.groupFinalizado.ResumeLayout(false);
            this.tableFinalizado.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupAberto;
        private System.Windows.Forms.GroupBox groupAndamento;
        private System.Windows.Forms.GroupBox groupPendente;
        private System.Windows.Forms.GroupBox groupFinalizado;
        private System.Windows.Forms.TableLayoutPanel tableAberto;
        private System.Windows.Forms.TableLayoutPanel tableAndamento;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TableLayoutPanel tablePendente;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.TableLayoutPanel tableFinalizado;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}