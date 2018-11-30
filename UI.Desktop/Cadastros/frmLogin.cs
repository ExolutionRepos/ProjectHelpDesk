using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories;
using UI.Business.Interfaces.Repositories.Business;
using static Library.Class.Enum.EnumStatusLogin;

namespace UI.Desktop.Cadastros
{
    public partial class frmLogin : Form, ISpeech
    {
        private readonly ControlUsuario _RepositoryControlUsuario;
        private readonly ControlLogin _RepositoryControlLogin;
        private readonly ControlPerfil _RepositoryControlPerfil;

        public frmLogin()
        {
            InitializeComponent();
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlLogin = new ControlLogin();
            _RepositoryControlPerfil = new ControlPerfil();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
            Limpar();
            
            comboPerfil.CarregarCombo<Perfis>(
              _RepositoryControlPerfil.PesquisarPerfil().ToList(),
              "CodigoPerfil", "Nome");
            
            //comboEnum
            comboStatus.DataSource = Enum.GetValues(typeof(StatusLogin));
        }

        private void Pesquisar(string nome)
        {
            dataGridView1.AutoGenerateColumns = true;

            var Data = _RepositoryControlUsuario.PesquisarUsuario("")
                .Where(a => a.Nome.Contains(nome))
                .Select(a => new
                {
                    ID = a.CodigoUsuario,
                    Nome = a.Nome,
                    CPF = a.CPF,
                    Email = a.Email,
                    Departamento = a.Departamento.Descricao
                }
                    )
                .Take(10)
                .ToList();

            dataGridView1.DataSource = Data;

            if (Data != null)
            {
                dataGridView1.Columns["ID"].Visible = false;
                dataGridView1.Columns["ID"].ReadOnly = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            var DadosUsuario = _RepositoryControlUsuario.Pesquisar(Convert.ToInt32(campo));
            CompletarCampos(DadosUsuario, _RepositoryControlLogin.Pesquisar(StringExtension.ToInt32(DadosUsuario.CodigoLogin)));
        }

        private void CompletarCampos(Usuarios usuarios, Logins logins)
        {
            if (usuarios != null)
            {
                textNome.Text = usuarios.Nome;
                textCPF.Text = usuarios.CPF;
                textEmail.Text = usuarios.Email;
            }

            if (logins != null)
            {
                toolStripButton1.Enabled = false;
                salvarToolStripButton1.Enabled = true;

                textLogin.Text = logins.Login.ToString();
                textSenha.Text = logins.Senha;
                comboPerfil.SelectedIndex = (int)logins.Perfil.CodigoPerfil;

                comboStatus.SelectedItem = logins.Status.ToString();
            }
            else
            {
                toolStripButton1.Enabled = true;
                salvarToolStripButton1.Enabled = false;
            }
        }

        private void Limpar()
        {
            this.ClearControlAll();
            errorProvider1.Clear();

            toolStripButton1.Enabled = false;
            salvarToolStripButton1.Enabled = false;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Limpar();
        }


        private void ValidatingTextBox(object sender, System.ComponentModel.CancelEventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox.Text == null || textBox.Text == "" || textBox.Text == "0")
            {
                errorProvider1.SetError(textBox, helpProvider1.GetHelpString(textBox));
            }
            else
            {

            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            var retorno = _RepositoryControlLogin.CadastrarLogin(StringExtension.ToInt32(campo), textLogin.Text, textSenha.Text, 
                textSenha.Text,
                (int)comboPerfil.SelectedIndex);

            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar(textBox2.Text);
                Limpar();
            }
        }

        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            var retorno = _RepositoryControlLogin.AlterarLogin(StringExtension.ToInt32(campo), textLogin.Text, textSenha.Text,
                (int)comboPerfil.SelectedIndex);

            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar(textBox2.Text);
                Limpar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        public void LabelLeave(object sender, EventArgs e)
        {
            Label dina = (Label)sender;
            ExtensionSpeech.speech(dina.Text);
        }

        public void ButtonLeave(object sender, EventArgs e)
        {
            Button dina = (Button)sender;
            ExtensionSpeech.speech(dina.Text);
        }
    }
}
