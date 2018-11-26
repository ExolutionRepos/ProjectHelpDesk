using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Sistema
{
    public partial class frmConfigFonte : Form
    {
        private FontFamily[] Families { get; }

        public frmConfigFonte()
        {
            InitializeComponent();
        }

        private void frmConfigFonte_Load(object sender, EventArgs e)
        {
            CarregarCombo();
        }

        private void CarregarCombo()
        {
            foreach (FontFamily oneFontFamily in FontFamily.Families)
            {
                comboBox1.Items.Add(oneFontFamily.Name);
            }

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
