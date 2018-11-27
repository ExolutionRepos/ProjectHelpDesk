using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;
using UI.Desktop.Chamado;
using static Library.Class.Enum.EnumSexo;
using static Library.Class.Enum.EnumStatusChamado;

namespace UI.Desktop
{
    public partial class Atencao : Form
    {
        private readonly ControlChamado _RepositoryChamado;

        public Atencao()
        {
            InitializeComponent();
            _RepositoryChamado = new ControlChamado();
        }

        public Atencao(MenuPrincipal menu)
        {
            InitializeComponent();
            _RepositoryChamado = new ControlChamado();
            menuP = menu;
        }

        

        private void Atencao_Load(object sender, EventArgs e)
        {
            List();

        }
        private void List()
        {
            listView1.Items.Clear();
            listView1.Columns.Clear();
            listView1.Columns.Add("Codigo");
            //listView1.Columns[0].AutoResize(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.Columns.Add("Descrição");
            listView1.View = View.Details;
            listView1.FullRowSelect = true;


            List<Chamados> clientes = _RepositoryChamado.PesquisarChamado()
                .Where(y => y.Status == StatusChamado.PreChamado)
                .ToList<Chamados>();

            Int32 itemAtual = 0;
            foreach (var cliente in clientes)
            {
                listView1.Items.Add(cliente.CodigoChamado.ToString());
                listView1.Items[itemAtual].SubItems.Add(cliente.Descricao);

                itemAtual += 1;
            }
        }
        public MenuPrincipal menuP;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count == 0)
                return;
            
            menuP.AbrirForm(new frmChamado(Library.Class.Utils.StringExtension.ToInt32(listView1.SelectedItems[0].Text.ToString()), menuP));
        }
    }
}
