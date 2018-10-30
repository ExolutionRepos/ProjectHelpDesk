using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Windows.Forms;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumSexo;
using static Library.Class.Enum.EnumTipoUsuario;

namespace UI.Desktop
{
    public partial class Form1 : Form

    {
        //private readonly ValUsuarios _ValUsuarios;
        private readonly BaseService<Usuarios> _RepositoryUsuario;
        private readonly BaseService<Enderecos> _RepositoryEndereco;
        private readonly BaseService<TipoUsuarios> _RepositoryTipoPerfil;
        private readonly BaseService<Logins> _RepositoryLogin;


        public Form1()
        {
            InitializeComponent();
            //_ValUsuarios = new ValUsuarios();
            _RepositoryUsuario = new BaseService<Usuarios>();
            _RepositoryEndereco = new BaseService<Enderecos>();
            _RepositoryTipoPerfil = new BaseService<TipoUsuarios>();
            _RepositoryLogin = new BaseService<Logins>();

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

            Usuarios DadosUsuarios1 = new Usuarios("rogerio", dateTimeNascimento.Value, "rogerio.silva@tivit.com", "46282434840", DadosSexo, "1141938361", "964273148");
            Usuarios DadosUsuarios2 = new Usuarios("fabio", dateTimeNascimento.Value, "rogerio.silva@tivit.com", "46282434840", DadosSexo, "1141938361", "964273148");


            //cadastro tipo de usuario
            TipoUsuarios Funcionario = new TipoUsuarios(TipoUsuario.Funcionario, "Acesso para resolução e apoio aos chamados", "Funcionarios");
            TipoUsuarios Cliente = new TipoUsuarios(TipoUsuario.Cliente, "Acesso somente de pesquisa e abertura/acompanhamento de chamados", "Clientes");
            Funcionario.Usuario.Add(DadosUsuarios1);
            Cliente.Usuario.Add(DadosUsuarios2);

            //Não salvar, somente adicionar
            _RepositoryTipoPerfil.AddNotSave(Funcionario);
            _RepositoryTipoPerfil.AddNotSave(Cliente);

            // Cadastro de endereço
            Enderecos Endereco = new Enderecos("Rua abelardo");
            Endereco.Usuario.Add(DadosUsuarios1);
            Endereco.Usuario.Add(DadosUsuarios2);

            //Salvar 
            _RepositoryEndereco.AddNotSave(Endereco);


            Logins login = new Logins("Rogerio.junior", "3148", "3148rogerio",DadosUsuarios1);
            _RepositoryLogin.Add(login);
            

            MessageBox.Show("Novo Usuario cadastrado");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
