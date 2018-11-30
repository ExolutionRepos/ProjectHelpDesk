using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumPerfil;
using static Library.Class.Enum.EnumSexo;
using static Library.Class.Enum.EnumTipoUsuario;

namespace UI.Desktop
{
    public partial class Form1 : Form, ISpeech
    {
        public Form1()
        {
            InitializeComponent();

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
    }
}
