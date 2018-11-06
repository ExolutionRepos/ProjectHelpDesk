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

namespace UI.Desktop.Cadastros
{
    public partial class frmLogin : Form
    {
        private readonly ControlUsuario _RepositoryControlUsuario;

        public frmLogin()
        {
            InitializeComponent();
            _RepositoryControlUsuario = new ControlUsuario();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
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
    }
}
