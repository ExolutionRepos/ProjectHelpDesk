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

        public frmChamado()
        {
            InitializeComponent();

            _RepositoryControlChamado = new ControlChamado();
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlTipoChamado = new ControlTipoChamado();
            _RepositoryControlProduto = new ControlProduto();
            _RepositoryControlDepartamento = new ControlDepartamento();
        }

        private void frmChamado_Load(object sender, EventArgs e)
        {

            Pesquisar(textBox2.Text);

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

            comboPrioridade.Visible = true;
            //comboDepartamento.Visible = true;

            this.Limpar();
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
                    .Take(10)
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
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), "PreChamado");

            ChamadoPrioridade chamadoprioridade = (ChamadoPrioridade)Enum.Parse(typeof(ChamadoPrioridade), comboPrioridade.SelectedItem.ToString());

            var retorno = _RepositoryControlChamado.CadastrarChamado(richTextDescricao.Text, richTextobs.Text,
                statuschamado, chamadoprioridade, (int)comboTipochamado.SelectedIndex,
                (int)comboProduto.SelectedIndex, (int)comboCliente.SelectedIndex,
                (int)comboFuncionario.SelectedIndex, null);

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
            comboFuncionario.SelectedIndex = (int)chamados.Funcionario.CodigoUsuario;
            comboTipochamado.SelectedIndex = (int)chamados.CodigoTipoChamado;

            richTextDescricao.Text = chamados.Descricao;
            richTextobs.Text = chamados.Observacao;

            labelChamado.Text = "Chamado: ";
            labelChamado.Text += chamados.ToString();

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

            StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), chamados.Status.ToString());

            object val = Convert.ChangeType(statuschamado, statuschamado.GetTypeCode());

            StatusChamado statuschamado1 = (StatusChamado)val + 1;
            
            buttonStatus1.Text = statuschamado.ToString();
            buttonStatus2.Text = statuschamado1.ToString();


            DataInicio.Text = chamados.DataInicio.Value.ToShortDateString();
            DataEntrega.Text = chamados.DataFinalizacao.Value.ToShortDateString();
            labelPreviData.Text = chamados.DataInicio.Value.AddDays(Convert.ToInt32(chamados.TipoChamado.SLA)).ToShortDateString();
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
                //comboDepartamento.Visible = true;
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
    }
}
