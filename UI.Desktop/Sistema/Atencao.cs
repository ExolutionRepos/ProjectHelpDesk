using Library.Class.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;
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


            List<Chamados> clientes = _RepositoryChamado.PesquisarChamado().ToList<Chamados>();

            Int32 itemAtual = 0;
            foreach (var cliente in clientes)
            {
                listView1.Items.Add(cliente.CodigoChamado.ToString());
                listView1.Items[itemAtual].SubItems.Add(cliente.Descricao);

                itemAtual += 1;
            }
        }
    }
}
