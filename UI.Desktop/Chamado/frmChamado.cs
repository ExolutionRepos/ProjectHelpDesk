using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;
using UI.Desktop.Sistema;
using static Library.Class.Enum.EnumChamado;
using static Library.Class.Enum.EnumStatusChamado;

namespace UI.Desktop.Chamado
{
    public partial class frmChamado : Form
    {

        private readonly ControlChamado _RepositoryControlChamado;
        private readonly ControlUsuario _RepositoryControlUsuario;
        private readonly ControlTipoChamado _RepositoryControlTipoChamado;
        private readonly ControlProduto _RepositoryControlProduto;
        private readonly ControlDepartamento _RepositoryControlDepartamento;
        private readonly ControlBaseConhecimento _RepositoryControlBaseConhecimento;
        private Chamados ListChamado = null;
        private MenuPrincipal menuP = null;

        public frmChamado(MenuPrincipal menuprincipal)
        {
            InitializeComponent();

            _RepositoryControlChamado = new ControlChamado();
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlTipoChamado = new ControlTipoChamado();
            _RepositoryControlProduto = new ControlProduto();
            _RepositoryControlDepartamento = new ControlDepartamento();
            _RepositoryControlBaseConhecimento = new ControlBaseConhecimento();

            menuP = menuprincipal;
        }

        public frmChamado(int codigochamado, MenuPrincipal menuprincipal)
        {
            InitializeComponent();

            _RepositoryControlChamado = new ControlChamado();
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlTipoChamado = new ControlTipoChamado();
            _RepositoryControlProduto = new ControlProduto();
            _RepositoryControlDepartamento = new ControlDepartamento();
            _RepositoryControlBaseConhecimento = new ControlBaseConhecimento();


            ListChamado = _RepositoryControlChamado.Pesquisar(Convert.ToInt32(codigochamado));

            menuP = menuprincipal;
        }


        private void frmChamado_Load(object sender, EventArgs e)
        {

            Pesquisar(textBox2.Text);

            CarregarCombo();
            comboPrioridade.Visible = true;

            this.Limpar();

            if (ListChamado != null)
                CompletarCampo(ListChamado);
        }

        private void CarregarCombo()
        {
            comboCliente.CarregarCombo<Usuarios>(
                _RepositoryControlUsuario.PesquisarUsuario().Where(y => y.CodigoTipoUsuario == 1).ToList(),
                "CodigoUsuario", "Nome");

            comboFuncionario.CarregarCombo<Usuarios>(
                _RepositoryControlUsuario.PesquisarUsuario().Where(y => y.CodigoTipoUsuario == 2).ToList(),
                "CodigoUsuario", "Nome");

            comboTipochamado.CarregarCombo<TipoChamados>(
                _RepositoryControlTipoChamado.PesquisarTipoChamado().ToList(),
                "CodigoTipoChamado", "Nome");

            comboProduto.CarregarCombo<Produtos>(
              _RepositoryControlProduto.PesquisarProduto().ToList(),
              "CodigoProduto", "Nome");

            comboDepartamento.CarregarCombo<Departamentos>(
              _RepositoryControlDepartamento.PesquisarDepartamento().ToList(),
              "CodigoDepartamento", "Nome");

            comboPrioridade.DataSource = Enum.GetValues(typeof(ChamadoPrioridade));

        }
        private void Pesquisar(string nome)
        {
            try
            {

                dataGridView1.AutoGenerateColumns = true;

                var Data = _RepositoryControlChamado.PesquisarChamado("")
                    .Where(a => a.Descricao.Contains(nome))
                    .Select(a => new
                    {
                        ID = a.CodigoChamado,
                        //Codigo = a.ToString(),
                        Codigo = a.CodigoChamado,
                        Nome = a.Descricao
                    }
                        )
                    .ToList();

                dataGridView1.DataSource = Data;

                if (Data != null && Data.Count > 0)
                {
                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.Columns["ID"].ReadOnly = true;

                    DataGridViewColumn coluna = dataGridView1.Columns["Del"];
                    if (coluna != null)
                    {
                        dataGridView1.Columns.Remove(coluna);
                    }
                    DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
                    btnColumn.Name = "Del";
                    btnColumn.HeaderText = "Ação";
                    btnColumn.Text = "Excluir";
                    btnColumn.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnColumn);

                    DataGridViewButtonColumn btnColumnEdita = new DataGridViewButtonColumn();
                    btnColumnEdita.Name = "Edi";
                    btnColumnEdita.HeaderText = "Ação";
                    btnColumnEdita.Text = "Editar";
                    btnColumnEdita.UseColumnTextForButtonValue = true;
                    dataGridView1.Columns.Add(btnColumnEdita);
                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void PesquisarConhecimento(string nome, TipoChamados tipochamados)
        {
            try
            {

                dataGridView2.AutoGenerateColumns = true;

                var Data = _RepositoryControlBaseConhecimento.PesquisarBaseConhecimento("")
                    //.Where(a => 
                    ////(a.Descricao.Contains(nome)
                    ////|| a.PalavraChave.Contains(nome)) ||
                    // a.TipoChamado == tipochamados)
                    .Select(a => new
                    {
                        ID = a.CodigoBaseConhecimento,
                        //Codigo = a.ToString(),
                        Segestão = a.Nome,
                        Descrição = a.Descricao
                    }
                        )
                    .Take(10)
                    .ToList();

                dataGridView2.DataSource = Data;

                if (Data != null && Data.Count > 0)
                {
                    dataGridView2.Columns["ID"].Visible = false;
                    dataGridView2.Columns["ID"].ReadOnly = true;

                }

            }
            catch (Exception e)
            {
                throw;
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Limpar();
        }

        private void Limpar()
        {
            this.ClearControlAll();
            errorProvider1.Clear();

            toolStripButton1.Enabled = true;
            salvarToolStripButton1.Enabled = false;

            labelChamado.Text = "";
            labelChamado.Tag = null;

            buttonStatus1.Text = "";
            buttonStatus1.Enabled = false;
            buttonStatus2.Text = "Pre-chamado";
            buttonStatus2.Enabled = false;

            DataInicio.Text = "";
            DataEntrega.Text = "";
            labelPreviData.Text = "";

            comboPrioridade.Visible = true;
            comboPrioridade.Enabled = true;

            comboDepartamento.Visible = true;
            comboDepartamento.Enabled = true;
            buttonDepartamento.Text = "";

            picturePrioridade.BackColor = Color.Transparent;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), "PreChamado");

            ChamadoPrioridade chamadoprioridade = (ChamadoPrioridade)Enum.Parse(typeof(ChamadoPrioridade), comboPrioridade.SelectedItem.ToString());

            var retorno = _RepositoryControlChamado.CadastrarChamado(richTextDescricao.Text, richTextobs.Text,
                statuschamado, chamadoprioridade, (int)comboTipochamado.SelectedIndex,
                (int)comboProduto.SelectedIndex, (int)comboCliente.SelectedIndex,
                (int)comboFuncionario.SelectedIndex, (int)comboDepartamento.SelectedIndex, dateGarantia.Value);

            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar(textBox2.Text);
                Limpar();
            }

        }

        private void CompletarCampo(Chamados chamados)
        {
            comboCliente.SelectedIndex = (int)chamados.Cliente.CodigoUsuario;

            if (chamados.Funcionario != null)
                comboFuncionario.SelectedIndex = (int)chamados.Funcionario.CodigoUsuario;

            comboTipochamado.SelectedIndex = (int)chamados.CodigoTipoChamado;
            comboProduto.SelectedIndex = (int)chamados.CodigoProduto;
            comboDepartamento.SelectedIndex = (int)chamados.CodigoDepartamento;

            comboPrioridade.SelectedItem = chamados.Prioridade;
            comboPrioridade.Visible = false;

            buttonDepartamento.Visible = true;
            buttonDepartamento.Text = chamados.Departamento.Nome;
            comboDepartamento.Visible = false;

            richTextDescricao.Text = chamados.Descricao;
            richTextobs.Text = chamados.Observacao;

            labelChamado.Text = "Chamado: ";
            labelChamado.Text += chamados.ToString();
            labelChamado.Tag = chamados.CodigoChamado;

            switch (chamados.Prioridade)
            {
                case ChamadoPrioridade.Baixa:
                    picturePrioridade.BackColor = Color.Green;
                    break;

                case ChamadoPrioridade.Media:
                    picturePrioridade.BackColor = Color.Yellow;
                    break;

                case ChamadoPrioridade.Alta:
                    picturePrioridade.BackColor = Color.Red;
                    break;
            }

            //Carregar o status do chamado
            CarregarStatusChamado(chamados);

            DataInicio.Text = chamados.DataInicio.Value.ToShortDateString().ToString();

            if (chamados.DataFinalizacao != null)
                DataEntrega.Text = chamados.DataFinalizacao.Value.ToShortDateString().ToString();
            else
                DataEntrega.Text = "__/__/____";

            labelPreviData.Text = chamados.DataInicio.Value.AddDays(Convert.ToInt32(chamados.TipoChamado.SLA)).ToShortDateString().ToString();

            PesquisarConhecimento(richTextDescricao.Text, chamados.TipoChamado);
        }

        private void CarregarStatusChamado(Chamados chamados)
        {
            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), chamados.Status.ToString());

            buttonAtual.Text = statuschamado.ToString();

            object val = Convert.ChangeType(statuschamado, statuschamado.GetTypeCode());

            StatusChamado statuschamadoantes = (StatusChamado)val - 1;

            StatusChamado statuschamado1 = (StatusChamado)val + 1;

            object val2 = Convert.ChangeType(statuschamado1, statuschamado1.GetTypeCode());

            var contarenum = Enum.GetValues(typeof(StatusChamado)).Cast<int>();

            buttonStatus1.Text = statuschamadoantes.ToString();
            buttonStatus1.Tag = (int)val - 1;

            if ((int)val - 1 == contarenum.Min())
                buttonStatus1.Enabled = false;
            else
                buttonStatus1.Enabled = true;

            buttonStatus2.Text = statuschamado1.ToString();
            buttonStatus2.Tag = (int)val2;



            if ((int)val2 == contarenum.Max())
                buttonStatus1.Enabled = false;
            else
                buttonStatus1.Enabled = true;

            if ((int)val2 > contarenum.Max())
            {
                buttonStatus2.Enabled = false;
                buttonStatus2.Text = statuschamado.ToString();
                buttonStatus1.Enabled = false;
            }
            else
                buttonStatus2.Enabled = true;

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView1.CurrentRow.Cells["ID"].Value.ToString();

            if (e.ColumnIndex == dataGridView1.Columns["Del"].Index)
            {
                if (DialogResult.Yes == MessageBox.Show("Você deseja excluir este registro ?", "", MessageBoxButtons.YesNo))
                {
                    var retorno = _RepositoryControlUsuario.Remover(Convert.ToInt32(campo));

                    lblAtencao.Text = retorno.Propert + ": " + retorno.Message;

                    Pesquisar(textBox2.Text);
                    Limpar();
                }
            }
            else if (e.ColumnIndex == dataGridView1.Columns["Edi"].Index)
            {
                CompletarCampo(_RepositoryControlChamado.Pesquisar(Convert.ToInt32(campo)));
                comboDepartamento.Visible = true;
                comboPrioridade.Visible = true;

            }
            else
            {
                CompletarCampo(_RepositoryControlChamado.Pesquisar(Convert.ToInt32(campo)));
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

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void comboPrioridade_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboPrioridade.SelectedItem)
            {
                case ChamadoPrioridade.Baixa:
                    picturePrioridade.BackColor = Color.Green;
                    break;

                case ChamadoPrioridade.Media:
                    picturePrioridade.BackColor = Color.Yellow;
                    break;

                case ChamadoPrioridade.Alta:
                    picturePrioridade.BackColor = Color.Red;
                    break;

                default:
                    picturePrioridade.BackColor = Color.Transparent;
                    break;
            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var campo = dataGridView2.CurrentRow.Cells["ID"].Value.ToString();

            menuP.AbrirFormdialog(new frmConfiguracao(_RepositoryControlBaseConhecimento.Pesquisar(StringExtension.ToInt32(campo))));
        }

        private void comboTipochamado_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbx = sender as ComboBox;
            PesquisarConhecimento(richTextDescricao.Text, _RepositoryControlTipoChamado.Pesquisar(cbx.SelectedIndex));
        }

        private void comboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonDepartamento.Text = comboDepartamento.SelectedText.ToString();
        }

        private void buttonStatus2_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), button.Text);
            _RepositoryControlChamado.AlterarStatus((int)labelChamado.Tag, statuschamado);

            CompletarCampo(_RepositoryControlChamado.Pesquisar((int)labelChamado.Tag));
        }

        private void buttonStatus1_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), button.Text);
            _RepositoryControlChamado.AlterarStatus((int)labelChamado.Tag, statuschamado);

            CompletarCampo(_RepositoryControlChamado.Pesquisar((int)labelChamado.Tag));
        }

        private void labelPreviData_Click(object sender, EventArgs e)
        {

        }

        private void salvarToolStripButton1_Click(object sender, EventArgs e)
        {
            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), "PreChamado");

            ChamadoPrioridade chamadoprioridade = (ChamadoPrioridade)Enum.Parse(typeof(ChamadoPrioridade), comboPrioridade.SelectedItem.ToString());

            var retorno = _RepositoryControlChamado.AlterarChamado((int)labelChamado.Tag, richTextDescricao.Text, richTextobs.Text,
                statuschamado, chamadoprioridade, (int)comboTipochamado.SelectedIndex,
                (int)comboProduto.SelectedIndex, (int)comboCliente.SelectedIndex,
                (int)comboFuncionario.SelectedIndex, (int)comboDepartamento.SelectedIndex, dateGarantia.Value);

            lblAtencao.Text = "• " + retorno.Propert + ": " + retorno.Message;

            if (retorno.Status)
            {
                Pesquisar(textBox2.Text);
                Limpar();
            }
        }
    }
}
