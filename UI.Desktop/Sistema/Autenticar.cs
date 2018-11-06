using Library.Class.Utils;
using System;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;

namespace UI.Desktop
{
    public partial class Autenticar : Form
    {
        private readonly ControlConfigFonte _RepositoryControlConfigFonte;
        private readonly ControlUsuario _RepositoryControlUsuario;

        public Autenticar()
        {
            InitializeComponent();
            _RepositoryControlConfigFonte = new ControlConfigFonte();
            _RepositoryControlUsuario = new ControlUsuario();
        }

        private void Autenticar_Load(object sender, EventArgs e)
        {
            var Result = _RepositoryControlConfigFonte.Pesquisar(3);
            if (Result != null)
                this.ConfigurarTamanhoFonte(Result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            (new MenuPrincipal()).ShowDialog();
            this.Show();
        }

        private void Autenticar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(0);
        }
    }
}
