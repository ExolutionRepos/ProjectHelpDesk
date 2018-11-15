using Library.Class.Models;
using Library.Class.Utils;
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
    public partial class frmConfiguracao : Form
    {
        private readonly ControlTipoUsuario _RepositoryControlUsuario;


        public frmConfiguracao()
        {
            InitializeComponent();
            _RepositoryControlUsuario = new ControlTipoUsuario();
        }
        
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            Limpar();
            Pesquisar(textBox2.Text);
        }

        private void Pesquisar(string nome)
        {
            dataGridView1.AutoGenerateColumns = true;

            var Data = _RepositoryControlUsuario.PesquisarTipoUsuario("")
                .Where(a => a.Nome.Contains(nome))
                .Select(a => new
                {
                    Codigo = a.CodigoTipoUsuario,
                    Tipo = a.Nome
                }
                    )                
                .ToList();

            dataGridView1.DataSource = Data;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            var DadosUsuario = _RepositoryControlUsuario.Pesquisar(Convert.ToInt32(campo));
            CompletarCampos(DadosUsuario);
        }

        private void CompletarCampos(TipoUsuarios tipousuarios)
        {
            textTipo.Text = tipousuarios.Nome;
            textDescricao.Text = tipousuarios.Descricao;

            toolStripButton17.Enabled = false;
            toolStripButton18.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Pesquisar(textBox2.Text);
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            var retorno = _RepositoryControlUsuario.CadastrarTipoUsuario(textTipo.Text, textDescricao.Text);


            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar(textBox2.Text);
                Limpar();
            }
        }

        private void Limpar()
        {
            this.ClearControlAll();
            //errorProvider1.Clear();

            toolStripButton17.Enabled = true;
            toolStripButton18.Enabled = false;

        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            var retorno = _RepositoryControlUsuario.AlterarTipoUsuario(Convert.ToInt16(campo), textTipo.Text, textDescricao.Text);
            
            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar(textBox2.Text);
                Limpar();
            }
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            Limpar();
        }
    }
}
