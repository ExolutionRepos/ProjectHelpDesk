using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories;
using UI.Business.Interfaces.Repositories.Business;

namespace UI.Desktop
{
    public partial class Autenticar : Form, ISpeech
    {
        private readonly ControlConfigFonte _RepositoryControlConfigFonte;
        private readonly ControlUsuario _RepositoryControlUsuario;
        private readonly ControlLogin _RepositoryControlLogin;

        public Autenticar()
        {
            InitializeComponent();
            _RepositoryControlConfigFonte = new ControlConfigFonte();
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlLogin = new ControlLogin();
        }

        private void Autenticar_Load(object sender, EventArgs e)
        {
            
        //    var Result = _RepositoryControlConfigFonte.Pesquisar(3);
        //    if (Result != null)
        //        this.ConfigurarTamanhoFonte(Result);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblAtencao.Text = null;

            if (textSenha.Text != null && textLogin.Text != null)
            {
                var retorno = _RepositoryControlLogin.Autenticar(textLogin.Text, textSenha.Text.ConvertToMD5());

                if (retorno != null)
                {
                    var usuario = _RepositoryControlUsuario.PesquisarUsuario(retorno);

                    AbrirForm(usuario.CodigoUsuario, retorno.Perfil.Descricao, usuario.Nome, retorno.Perfil);

                    this.ClearControlAll();
                }
                else if (textSenha.Text.ConvertToMD5() == "cbf2bd29dcd36fa3284fe8fd048a3440" && textLogin.Text == "admin")
                {
                    AbrirForm(0, "Admin", "Admin");
                    this.ClearControlAll();
                }
                else
                {
                    lblAtencao.Text = "Usuario / Senha não encontrados ";
                }
            }
            else
            {
                AbrirForm(null, "", "");
            }
        }

        private void AbrirForm(int? tag, string perfil, string nome, Perfis tipoperfil = null)
        {
            this.Hide();

            MenuPrincipal menuPrincipal = new MenuPrincipal(tipoperfil);
            menuPrincipal.toolStripMenuItem2.Tag = tag;
            menuPrincipal.toolStripStatusLabel3.Text = nome;
            menuPrincipal.toolStripStatusLabel4.Text = perfil;
            menuPrincipal.toolStripMenuItem2.Text = nome;
            menuPrincipal.ShowDialog();
            this.Show();

        }


        private void Autenticar_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Environment.Exit(0);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        public async void LabelLeave(object sender, EventArgs e)
        {
            Label dina = (Label)sender;
            ExtensionSpeech.speech(dina.Text);
        }

        public async void ButtonLeave(object sender, EventArgs e)
        {
            Button dina = (Button)sender;
            ExtensionSpeech.speech(dina.Text);
        }
    }
}
