using System;
using System.Windows.Forms;
using UI.Business.Arguments.Usuario;
using UI.Business.Repositories;
using System.Collections.Generic;
using System.Text;

namespace UI.Desktop
{
    public partial class Form1 : Form
    {
        private readonly RepositoryUsuario _RepositoryUsuario;
        
        public Form1()
        {
            InitializeComponent();
            _RepositoryUsuario = new RepositoryUsuario();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Colzultar();
        }

        private void Colzultar()
        {
            var me = _RepositoryUsuario.ConsultarUsuario((new RequestUsuarioCon() { CodigoUsuario = 1 }));
            MessageBox.Show(me.Nome.ToString());
        }

        private void Cadastro()
        {
            
            StringBuilder mensagem = new StringBuilder();
            string titulo = "Cadastro";

            var me = _RepositoryUsuario.AdicionarUsuario((new RequestUsuarioAdi() { nome = "Fabio" }));

            mensagem.AppendLine(me.Nome);

            MessageBox.Show(null, mensagem.ToString(), titulo.ToString());
        }

        private void Remove()
        {

            StringBuilder mensagem = new StringBuilder();
            string titulo = "Remover";

            var me = _RepositoryUsuario.DeletarUsuario((new RequestUsuarioDel() { CodigoUsuario = 4 }));

            if (me.ResponseBaseDictionary == null)
            {
                mensagem.AppendLine(me.Message);
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in me.ResponseBaseDictionary)
                {
                    mensagem.AppendLine(pair.Value);
                }
            }

            MessageBox.Show(null, mensagem.ToString(), titulo.ToString());
        }

        private void Alterar()
        {
            StringBuilder mensagem = new StringBuilder();
            string titulo = "Alterar";

            var me = _RepositoryUsuario.AlterarUsuario((new RequestUsuarioAlt() { CodigoUsuario = 1, Nome = "Fabio" }));

            if (me.ResponseBaseDictionary == null)
            {
                mensagem.AppendLine(me.Message);
            }
            else
            {
                foreach (KeyValuePair<string, string> pair in me.ResponseBaseDictionary)
                {
                    mensagem.AppendLine(pair.Value);
                }
            }

            MessageBox.Show(null, mensagem.ToString(), titulo.ToString());
        }

    }
}
