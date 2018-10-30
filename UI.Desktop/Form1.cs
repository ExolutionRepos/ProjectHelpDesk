using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Windows.Forms;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumSexo;

namespace UI.Desktop
{
    public partial class Form1 : Form

    {
        //private readonly ValUsuarios _ValUsuarios;
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<Enderecos> _RepositoryEndereco;


        public Form1()
        {
            InitializeComponent();
            //_ValUsuarios = new ValUsuarios();
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryEndereco = new BaseService<Enderecos>();
        }
        
        //private void Cadastrar(Usuarios usuarios)
        //{
        //    _RepositoryUsuario.Add(usuarios);
        //}

        //private void Alterar()
        //{
        //    var Endereco = new Enderecos(1, "Test");
        //    _RepositoryUsuario.Edit((new Usuarios(1,"Luiz",Endereco)));
        //}

        //private void Excluir()
        //{
        //    var Endereco = new Enderecos(1, "Test");
        //    _RepositoryUsuario.Remove(_RepositoryUsuario.Find(1));
        //}

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.ClearControlAll();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Sexo DadosSexo = (Sexo)Enum.Parse(typeof(Sexo), comboSexo.SelectedItem.ToString());

            //var DadosUsuarios = _ValUsuarios.Cadastrar(textNome.Text, dateTimeNascimento.Value, textEmail.Text, textCPF.Text, DadosSexo, textTelUm.Text, textTelUm.Text, textRua.Text);
            var DadosEndereco = new Enderecos("Test");

            MessageBox.Show("Novo Usuario cadastrado");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
