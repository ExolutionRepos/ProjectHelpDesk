using Library.Class.Enum;
using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;
using static Library.Class.Enum.EnumMarca;
using static Library.Class.Enum.EnumModelo;
using static Library.Class.Enum.EnumSexo;

namespace UI.Desktop.Sistema
{
    public partial class frmConfiguracao : Form
    {
        private readonly ControlTipoUsuario _RepositoryControlUsuario;
        private readonly ControlDepartamento _RepositoryControlDepartamento;
        private readonly ControlPerfil _RepositoryControlPerfil;
        private readonly ControlTipoChamado _RepositoryControlTipoChamado;
        private readonly ControlProduto _RepositoryControlProduto;


        public frmConfiguracao()
        {
            InitializeComponent();
            _RepositoryControlUsuario = new ControlTipoUsuario();
            _RepositoryControlPerfil = new ControlPerfil();
            _RepositoryControlDepartamento = new ControlDepartamento();
            _RepositoryControlTipoChamado = new ControlTipoChamado();
            _RepositoryControlProduto = new ControlProduto();
        }
        
        private void tabPage1_Enter(object sender, EventArgs e)
        {
            LimparTipoUsuario();
            PesquisarTipoUsuario(textBox2.Text);
        }

        private void PesquisarTipoUsuario(string nome)
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
            PesquisarTipoUsuario(textBox2.Text);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();

            var DadosUsuario = _RepositoryControlUsuario.Pesquisar(Convert.ToInt32(campo));
            CompletarCamposTipoUsuario(DadosUsuario);
        }

        private void CompletarCamposTipoUsuario(TipoUsuarios tipousuarios)
        {
            textTipo.Text = tipousuarios.Nome;
            textDescricao.Text = tipousuarios.Descricao;

            toolStripButton17.Enabled = false;
            toolStripButton18.Enabled = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            PesquisarTipoUsuario(textBox2.Text);
        }

        private void toolStripButton17_Click(object sender, EventArgs e)
        {
            var retorno = _RepositoryControlUsuario.CadastrarTipoUsuario(textTipo.Text, textDescricao.Text);


            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarTipoUsuario(textBox2.Text);
                LimparTipoUsuario();
            }
        }

        private void LimparTipoUsuario()
        {
            this.ClearControlAll();
            //errorProvider1.Clear();

            toolStripButton17.Enabled = true;
            toolStripButton18.Enabled = false;

        }

        private void toolStripButton18_Click(object sender, EventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["CODIGO"].Value.ToString();

            var retorno = _RepositoryControlUsuario.AlterarTipoUsuario(Convert.ToInt16(campo), textTipo.Text, textDescricao.Text);
            
            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarTipoUsuario(textBox2.Text);
                LimparTipoUsuario();
            }
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            LimparTipoUsuario();
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            LimparDepartamento();
            PesquisarDepartamentos(textBox4.Text);
        }

        private void PesquisarDepartamentos(string nome)
        {
            dataGridView2.AutoGenerateColumns = true;

            var Data = _RepositoryControlDepartamento.PesquisarDepartamento("")
                .Where(a => a.Nome.Contains(nome))
                .Select(a => new
                {
                    Codigo = a.CodigoDepartamento,
                    Tipo = a.Nome
                }
                    )
                .ToList();

            dataGridView2.DataSource = Data;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            PesquisarDepartamentos(textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PesquisarDepartamentos(textBox4.Text);
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();

            var DadosDepartamento = _RepositoryControlDepartamento.Pesquisar(Convert.ToInt32(campo));
            CompletarCamposDepartamento(DadosDepartamento);
        }

        private void CompletarCamposDepartamento(Departamentos departamento)
        {
            textDepartamento.Text = departamento.Nome;
            textDecricaoDepartamento.Text = departamento.Descricao;

            toolStripButton10.Enabled = false;
            toolStripButton11.Enabled = true;
        }

        private void LimparDepartamento()
        {
            this.ClearControlAll();
            //errorProvider1.Clear();

            toolStripButton10.Enabled = true;
            toolStripButton11.Enabled = false;

        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            var retorno = _RepositoryControlDepartamento.CadastrarDepartamento(textDepartamento.Text, textDecricaoDepartamento.Text);

            label5.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarDepartamentos(textBox2.Text);
                LimparDepartamento();
            }
        }

        private void toolStripButton11_Click(object sender, EventArgs e)
        {
            var campo = dataGridView2.CurrentRow.Cells["CODIGO"].Value.ToString();

            var retorno = _RepositoryControlDepartamento.AlterarDepartamento(Convert.ToInt16(campo), textDepartamento.Text, textDecricaoDepartamento.Text);

            label5.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarDepartamentos(textBox2.Text);
                LimparDepartamento();
            }
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            LimparDepartamento();
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            LimparPerfil();
            PesquisarPerfil(textBox5.Text);
        }

        private void PesquisarPerfil(string nome)
        {
            dataGridView3.AutoGenerateColumns = true;

            var Data = _RepositoryControlPerfil.PesquisarPerfil("")
                .Where(a => a.Nome.Contains(nome))
                .Select(a => new
                {
                    Codigo = a.CodigoPerfil,
                    Tipo = a.Nome
                }
                    )
                .ToList();

            dataGridView3.DataSource = Data;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PesquisarPerfil(textBox5.Text);
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            PesquisarPerfil(textBox5.Text);
        }

        private void dataGridView3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView3.CurrentRow.Cells["CODIGO"].Value.ToString();

            var DadosPerfil = _RepositoryControlPerfil.Pesquisar(Convert.ToInt32(campo));
            CompletarCamposPerfil(DadosPerfil);
        }

        private void CompletarCamposPerfil(Perfis perfil)
        {
            textPerfil.Text = perfil.Nome;
            textDescricaoPerfil.Text = perfil.Descricao;

            toolStripButton1.Enabled = false;
            salvarToolStripButton1.Enabled = true;
        }

        private void LimparPerfil()
        {
            this.ClearControlAll();
            //errorProvider1.Clear();

            toolStripButton1.Enabled = true;
            salvarToolStripButton1.Enabled = false;

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var retorno = _RepositoryControlPerfil.CadastrarPerfil(textPerfil.Text, textDescricaoPerfil.Text);

            label6.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarPerfil(textBox5.Text);
                LimparPerfil();
            }
        }

        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            var campo = dataGridView3.CurrentRow.Cells["CODIGO"].Value.ToString();

            var retorno = _RepositoryControlPerfil.AlterarPerfil(Convert.ToInt16(campo), textPerfil.Text, textDescricaoPerfil.Text);

            label6.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarPerfil(textBox5.Text);
                LimparPerfil();
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            LimparPerfil();
        }

        private void tabPage4_Enter(object sender, EventArgs e)
        {
            LimparTipoChamado();
            PesquisarTipoChamado(textBox6.Text);
        }
        
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var retorno = _RepositoryControlTipoChamado.CadastrarTipoChamado(textTipoChamado.Text, textDescricaoTipoChamdo.Text, numericTipoChamado.Value.ToString());

            label11.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarTipoChamado(textBox6.Text);
                LimparTipoChamado();
            }
        }

        private void LimparTipoChamado()
        {
            this.ClearControlAll();
            //errorProvider1.Clear();

            toolStripButton3.Enabled = true;
            toolStripButton4.Enabled = false;

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            LimparTipoChamado();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            PesquisarTipoChamado(textBox6.Text);
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            PesquisarTipoChamado(textBox6.Text);
        }

        private void PesquisarTipoChamado(string nome)
        {
            dataGridView4.AutoGenerateColumns = true;

            var Data = _RepositoryControlTipoChamado.PesquisarTipoChamado("")
                .Where(a => a.Nome.Contains(nome))
                .Select(a => new
                {
                    Codigo = a.CodigoTipoChamado,
                    Tipo = a.Nome
                }
                    )
                .ToList();

            dataGridView4.DataSource = Data;

        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView4.CurrentRow.Cells["CODIGO"].Value.ToString();

            var DadosTipoChamado = _RepositoryControlTipoChamado.Pesquisar(Convert.ToInt32(campo));
            CompletarCamposTipoChamado(DadosTipoChamado);
        }

        private void CompletarCamposTipoChamado(TipoChamados tipochamados)
        {
            textTipoChamado.Text = tipochamados.Nome;
            textDescricaoTipoChamdo.Text = tipochamados.Descricao;

            numericTipoChamado.Value = Convert.ToInt32(tipochamados.SLA);

            toolStripButton3.Enabled = false;
            toolStripButton4.Enabled = true;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            var campo = dataGridView4.CurrentRow.Cells["CODIGO"].Value.ToString();

            var retorno = _RepositoryControlTipoChamado.AlterarPerfil(Convert.ToInt16(campo), textTipoChamado.Text, textDescricaoTipoChamdo.Text, numericTipoChamado.Value.ToString());

            label11.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarTipoChamado(textBox6.Text);
                LimparTipoChamado();
            }
        }

        private void tabPage5_Enter(object sender, EventArgs e)
        {
            //comboEnum
            comboMarca.DataSource = Enum.GetValues(typeof(EnumMarca.Marcas));

            //comboEnum
            comboModelo.DataSource = Enum.GetValues(typeof(EnumModelo.Modelos));

            PesquisarProduto(textBox9.Text);
            LimparProduto();
        }

        private void PesquisarProduto(string nome)
        {
            dataGridView5.AutoGenerateColumns = true;

            var Data = _RepositoryControlProduto.PesquisarProduto("")
                .Where(a => a.Nome.Contains(nome))
                .Select(a => new
                {
                    Codigo = a.CodigoProduto,
                    Tipo = a.Nome
                }
                    )
                .ToList();

            dataGridView5.DataSource = Data;

        }

        private void CompletarCamposProduto(Produtos produtos)
        {
            textProduto.Text = produtos.Nome;
            textProdutoDecricao.Text = produtos.Descricao;

            comboMarca.SelectedItem = produtos.Marca;
            comboModelo.SelectedItem = produtos.Modelo;
            
            toolStripButton24.Enabled = false;
            toolStripButton25.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            PesquisarProduto(textBox9.Text);
        }

        private void dataGridView5_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView5.CurrentRow.Cells["CODIGO"].Value.ToString();

            var DadosProduto = _RepositoryControlProduto.Pesquisar(Convert.ToInt32(campo));
            CompletarCamposProduto(DadosProduto);
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            PesquisarProduto(textBox9.Text);
        }

        private void toolStripButton26_Click(object sender, EventArgs e)
        {
            LimparProduto();
        }

        private void LimparProduto()
        {
            this.ClearControlAll();
            //errorProvider1.Clear();

            toolStripButton24.Enabled = true;
            toolStripButton25.Enabled = false;

        }

        private void toolStripButton25_Click(object sender, EventArgs e)
        {
            Marcas DadosMarcas = (Marcas)Enum.Parse(typeof(Marcas), comboMarca.SelectedItem.ToString());
            Modelos DadosModelos = (Modelos)Enum.Parse(typeof(Modelos), comboModelo.SelectedItem.ToString());

            var campo = dataGridView5.CurrentRow.Cells["CODIGO"].Value.ToString();

            var retorno = _RepositoryControlProduto.AlterarProduto(Convert.ToInt16(campo), textProduto.Text,textProdutoDecricao.Text, DadosMarcas,DadosModelos);

            label17.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarProduto(textBox9.Text);
                LimparProduto();
            }
        }

        private void toolStripButton24_Click(object sender, EventArgs e)
        {
            Marcas DadosMarcas = (Marcas)Enum.Parse(typeof(Marcas), comboMarca.SelectedItem.ToString());
            Modelos DadosModelos = (Modelos)Enum.Parse(typeof(Modelos), comboModelo.SelectedItem.ToString());

            var retorno = _RepositoryControlProduto.CadastrarProduto(textProduto.Text, textProdutoDecricao.Text, DadosMarcas, DadosModelos);

            label17.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                PesquisarProduto(textBox9.Text);
                LimparProduto();
            }
        }
    }
}
