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

namespace UI.Desktop.Sistema
{
    public partial class frmConfigFonte : Form
    {
        private FontFamily[] Families { get; }
        private readonly ControlConfigFonte _RepositoryControlConfigFonte;
        private int codigo;
        public frmConfigFonte(int codigoUsuario)
        {
            InitializeComponent();
            _RepositoryControlConfigFonte = new ControlConfigFonte();
            codigo = codigoUsuario;
        }

        private void frmConfigFonte_Load(object sender, EventArgs e)
        {
            CarregarCombo();
            Pesquisar((int)codigo);
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
            var retorno = _RepositoryControlConfigFonte.Cadastrar((int)codigo, comboBox1.SelectedText, (float)numericUpDown1.Value);

            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar((int)codigo);
            }
        }
        private void Pesquisar(int usuario)
        {
            var Data = _RepositoryControlConfigFonte.Pesquisar(usuario);

            if (Data == null)
                return;

            comboBox1.SelectedItem = Data.Fonte;
            numericUpDown1.Value = Convert.ToInt32(Data.Tamanho);
        }
    }
}

