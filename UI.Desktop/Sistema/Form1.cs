using Library.Class.Models;
using Library.Class.Utils;
using System;
using System.Windows.Forms;
using UI.Business.Interfaces.Services;
using static Library.Class.Enum.EnumPerfil;
using static Library.Class.Enum.EnumSexo;
using static Library.Class.Enum.EnumTipoUsuario;

namespace UI.Desktop
{
    public partial class Form1 : Form
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
    }
}
