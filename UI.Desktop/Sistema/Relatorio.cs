using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories;
using UI.Business.Interfaces.Repositories.Business;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumChamado;
using static Library.Class.Enum.EnumMarca;
using static Library.Class.Enum.EnumModelo;
using static Library.Class.Enum.EnumPerfil;
using static Library.Class.Enum.EnumSexo;
using static Library.Class.Enum.EnumStatusChamado;
using static Library.Class.Enum.EnumTipoUsuario;

namespace UI.Desktop
{
    public partial class Form1 : Form, ISpeech
    {
        private readonly ControlUsuario _RepositoryControlUsuario;
        private readonly ControlChamado _RepositoryControlChamado;
        private readonly ControlProduto _RepositoryControlProduto;

        public Form1()
        {
            InitializeComponent();
            _RepositoryControlUsuario = new ControlUsuario();
            _RepositoryControlChamado = new ControlChamado();
            _RepositoryControlProduto = new ControlProduto();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.ClearControlAll();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
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

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var result = _RepositoryControlUsuario.PesquisarUsuario();

            if (txtNome.Text != null)
                result = result.Where(y => y.Nome.Contains(txtNome.Text));

            if (txtCPF.Text != null)
                result = result.Where(y => y.CPF.Contains(txtCPF.Text));

            if (cmbSexo.SelectedItem != null)
                result = result.Where(y => y.Sexo.Equals(cmbSexo.SelectedItem));

            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = result;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            this.ClearControlAll();
            dataGridView1.DataSource = null;
            dataGridView2.DataSource = null;
            dataGridView3.DataSource = null;
        }

        private void toolStripButton12_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void toolStripButton19_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            var result = _RepositoryControlChamado.PesquisarChamado();

            if (txtDescricao.Text != null)
                result = result.Where(y => y.Descricao.Contains(txtDescricao.Text));

            if (txtNumero.Text != null)
                result = result.Where(y => y.ToString().Equals(txtNumero.Text));

            if (cmbStatus.SelectedItem != null)
                result = result.Where(y => y.Status.Equals(cmbStatus.SelectedItem));

            if (cmbPrioridade.SelectedItem != null)
                result = result.Where(y => y.Prioridade.Equals(cmbPrioridade.SelectedItem));

            result = result.Where(y => y.DataInicio >= dtInicio.Value && y.DataFinalizacao >= dtFim.Value);

            dataGridView2.AutoGenerateColumns = true;
            dataGridView2.DataSource = result;
        }

        private void tabPage2_Enter(object sender, EventArgs e)
        {
            cmbStatus.DataSource = Enum.GetValues(typeof(StatusChamado));
            cmbPrioridade.DataSource = Enum.GetValues(typeof(ChamadoPrioridade));
        }

        private void tabPage1_Enter(object sender, EventArgs e)
        {
            cmbSexo.DataSource = Enum.GetValues(typeof(Sexo));
        }

        private void tabPage3_Enter(object sender, EventArgs e)
        {
            cmbMarca.DataSource = Enum.GetValues(typeof(Marcas));
            cmbModelo.DataSource = Enum.GetValues(typeof(Modelos));
        }

        private void toolStripButton10_Click(object sender, EventArgs e)
        {
            var result = _RepositoryControlProduto.PesquisarProduto();

            if (txtDesc.Text != null)
                result = result.Where(y => y.Descricao.Contains(txtDesc.Text));
            
            if (cmbMarca.SelectedItem != null)
                result = result.Where(y => y.Marca.Equals(cmbMarca.SelectedItem));

            if (cmbModelo.SelectedItem != null)
                result = result.Where(y => y.Modelo.Equals(cmbModelo.SelectedItem));
            
            dataGridView3.AutoGenerateColumns = true;
            dataGridView3.DataSource = result;
        }
    }
}
