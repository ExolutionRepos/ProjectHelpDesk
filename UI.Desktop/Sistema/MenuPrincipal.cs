using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.Cadastros;
using UI.Desktop.Chamado;
using UI.Desktop.Sistema;

namespace UI.Desktop
{
    public partial class MenuPrincipal : Form
    {
        public string message { get; set; }

        public MenuPrincipal()
        {

            
            InitializeComponent();

            Atencao form = new Atencao();

            this.LayoutMdi(MdiLayout.Cascade);
            form.WindowState = System.Windows.Forms.FormWindowState.Normal;
            form.MdiParent = this;
            form.Location = new Point(370, 180);
            form.Show();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void AbrirForm(Form form)
        {
            foreach (Form mdiChildForm in MdiChildren)
                mdiChildForm.Close();

            form.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            form.MdiParent = this;
            form.Show();
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
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmUsuario());
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmLogin());
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Pre_Chamado());
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            AbrirForm(new frmDashBoard());
        }

        private void fonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            (new frmConfigFonte()).ShowDialog();
        }
    }
}