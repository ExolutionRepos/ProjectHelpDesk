using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;
using UI.Desktop.Cadastros;
using UI.Desktop.Chamado;
using UI.Desktop.Sistema;
using static Library.Class.Enum.EnumStatusChamado;

namespace UI.Desktop
{
    public partial class MenuPrincipal : Form
    {
        public string message { get; set; }

        private readonly ControlChamado _RepositoryChamado;

        public MenuPrincipal(Perfis perfil)
        {
            InitializeComponent();
            _RepositoryChamado = new ControlChamado();

            Atencao form = new Atencao(this);

            this.LayoutMdi(MdiLayout.Cascade);
            form.WindowState = System.Windows.Forms.FormWindowState.Normal;
            form.MdiParent = this;
            form.Location = new Point(370, 180);
            form.Show();


            if (perfil != null)
                Perfil(perfil);


        }

        public MenuPrincipal(int codigochamado)
        {
            InitializeComponent();

            frmChamado form = new frmChamado(codigochamado, this);

            this.LayoutMdi(MdiLayout.Cascade);
            form.WindowState = System.Windows.Forms.FormWindowState.Normal;
            form.MdiParent = this;
            form.Location = new Point(370, 180);
            form.Show();
        }

        private void Perfil(Perfis perfil)
        {
            switch (perfil.TipoPerfil)
            {
                case Library.Class.Enum.EnumPerfil.TipoPerfils.Chamado:
                    this.toolStripChamado.Enabled = true;
                    this.toolStripChamadoDashBoard.Enabled = true;
                    this.toolStripUsuario.Enabled = false;
                    this.toolStripLogin.Enabled = false;
                    this.configurarToolStripMenuItem.Enabled = false;
                    this.toolStripRelatorio.Enabled = false;
                    break;

                case Library.Class.Enum.EnumPerfil.TipoPerfils.Usuario:
                    this.toolStripChamado.Enabled = true;
                    this.toolStripChamadoDashBoard.Enabled = true;
                    this.toolStripUsuario.Enabled = true;
                    this.toolStripLogin.Enabled = false;
                    this.configurarToolStripMenuItem.Enabled = false;
                    this.toolStripRelatorio.Enabled = false;
                    break;

                case Library.Class.Enum.EnumPerfil.TipoPerfils.Login:
                    this.toolStripChamado.Enabled = true;
                    this.toolStripChamadoDashBoard.Enabled = true;
                    this.toolStripUsuario.Enabled = true;
                    this.toolStripLogin.Enabled = true;
                    this.configurarToolStripMenuItem.Enabled = false;
                    this.toolStripRelatorio.Enabled = false;
                    break;

                case Library.Class.Enum.EnumPerfil.TipoPerfils.Configuracao:
                    this.toolStripChamado.Enabled = true;
                    this.toolStripChamadoDashBoard.Enabled = true;
                    this.toolStripUsuario.Enabled = true;
                    this.toolStripLogin.Enabled = true;
                    this.configurarToolStripMenuItem.Enabled = true;
                    this.toolStripRelatorio.Enabled = false;
                    break;

                case Library.Class.Enum.EnumPerfil.TipoPerfils.Relatorio:
                    this.toolStripChamado.Enabled = true;
                    this.toolStripChamadoDashBoard.Enabled = true;
                    this.toolStripUsuario.Enabled = true;
                    this.toolStripLogin.Enabled = true;
                    this.configurarToolStripMenuItem.Enabled = true;
                    this.toolStripRelatorio.Enabled = true;
                    break;

            }


        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            AbrirForm(new Form1());
        }

        public void AbrirForm(Form form)
        {
            foreach (Form mdiChildForm in MdiChildren)
                mdiChildForm.Close();

            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
        }

        public void AbrirFormdialog(Form form)
        {
            form.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            toolStripStatusLabel2.Text = timer1.ToString();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Tick += new EventHandler(TimerOnTick);
            timer.Interval = 1000;
            timer.Start();


        }

        private void TimerOnTick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;

            toolStripStatusLabel1.Text = dt.ToLongDateString();
            toolStripStatusLabel2.Text = dt.ToLongTimeString();

            var clientes = _RepositoryChamado.PesquisarChamado()
                 .Where(y => y.Status == StatusChamado.PreChamado)
                .FirstOrDefault();

            if (clientes != null)
            {
                prechamado.Visible = true;
                prechamado.Tag = clientes.CodigoChamado;
            }
            else
            {
                prechamado.Visible = false;
            }

        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario(this));
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmLogin());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmChamado(this));
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmDashBoard(this));
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmConfigFonte(Library.Class.Utils.StringExtension.ToInt32(this.toolStripMenuItem2.Tag.ToString()))).ShowDialog();
        }

        private void configurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmConfiguracao()).ShowDialog();
        }

        private void alertaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form mdiChildForm in MdiChildren)
                mdiChildForm.Close();

            Atencao form = new Atencao(this);
            form.WindowState = System.Windows.Forms.FormWindowState.Normal;
            form.MdiParent = this;
            form.Location = new Point(370, 180);
            form.Show();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario(Convert.ToInt32(toolStripMenuItem2.Tag)));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void prechamado_ButtonClick(object sender, EventArgs e)
        {
            AbrirForm(new frmChamado(Library.Class.Utils.StringExtension.ToInt32(prechamado.Tag), this));
        }

        private void manualDoUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string FileName = @"C:\Users\rogerio.silva\Documents\Manual do Usuário.docx";

            System.Diagnostics.Process.Start(FileName);
        }
    }
}