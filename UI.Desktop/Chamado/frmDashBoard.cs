using Library.Class.Utils;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using UI.Business.Interfaces.Repositories.Business;
using static Library.Class.Enum.EnumChamado;
using static Library.Class.Enum.EnumStatusChamado;

namespace UI.Desktop.Chamado
{
    public partial class frmDashBoard : Form
    {
        private readonly ControlChamado _RepositoryControlChamado;

        public frmDashBoard()
        {
            InitializeComponent();
            _RepositoryControlChamado = new ControlChamado();
        }

        public MenuPrincipal menuP;
        public frmDashBoard(MenuPrincipal menu)
        {
            InitializeComponent();
            _RepositoryControlChamado = new ControlChamado();
            menuP = menu;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClick(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            menuP.AbrirForm(new frmChamado((int)btn.Tag, menuP));
        }

        private void contar(int codigo,Control controle, string nome, string codigochamado, DateTime dataabertura, string categoria, string descricao, string sla, string responsavel, ChamadoPrioridade statuschamado, bool listar = true)
        {
            var vazio = 0;
            var cheio = 0;
            var contador = 0;

            var Listar = controle.Controls.Cast<Control>();

            if (listar)
            {
                Listar = Listar
                    .Where(y => y.Name.Contains(nome))
                    .OrderBy(y => StringExtension.ToInt32(y.TabIndex.ToString()))
                    .ToList();
            }
            else
            {
                Listar = Listar
                    .OrderBy(y => StringExtension.ToInt32(y.TabIndex.ToString()))
                    .ToList();
            }

            foreach (Control item in Listar)
            {
                if (item.GetType() == typeof(TableLayoutPanel))
                {
                    contar(codigo,item, nome, codigochamado, dataabertura, categoria, descricao, sla, responsavel, statuschamado, false);
                    break;
                }

                if (item.GetType() == typeof(GroupBox))
                {
                    contar(codigo,item, nome, codigochamado, dataabertura, categoria, descricao, sla, responsavel, statuschamado);
                    break;
                }

                if (item.GetType() == typeof(Panel))
                {
                    contador++;
                    if (((Panel)item).Controls.Count == 0)
                    {

                        AddNewTextBox(codigo,item, contador, codigochamado, dataabertura, categoria, descricao, sla, responsavel, statuschamado);
                        break;
                    }
                    else
                    {
                        cheio++;
                    }
                }
            }

            vazio = vazio;
        }
        int contador = 1;

        public void AddNewTextBox(int codigo,Control controle, int contar, string codigochamado, DateTime dataabertura, string categoria, string descricao, string sla, string responsavel, ChamadoPrioridade statuschamado)
        {
            //Define posição top
            var top = contador * 5;

            Panel panel = new Panel();
            panel.Dock = DockStyle.Fill;
            panel.BorderStyle = BorderStyle.FixedSingle;
            panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);

            panel.DragDrop += new System.Windows.Forms.DragEventHandler(this.panel1_DragDrop);
            panel.DragEnter += new System.Windows.Forms.DragEventHandler(this.ControlaEfeito);

            panel.Name = contar.ToString();

            //Novo PictureBox
            PictureBox picture = new PictureBox();
            picture.Height = 3;
            picture.Dock = DockStyle.Bottom;
            picture.Name = "picture" + contador;

            switch (statuschamado)
            {
                case ChamadoPrioridade.Baixa:
                    picture.BackColor = Color.Green;
                    break;

                case ChamadoPrioridade.Media:
                    picture.BackColor = Color.Yellow;
                    break;

                case ChamadoPrioridade.Alta:
                    picture.BackColor = Color.Red;
                    break;

                default:
                    picture.BackColor = Color.Transparent;
                    break;
            }

            picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            //Adiciona no Form
            panel.Controls.Add(picture);

            Button txt = new Button();
            txt.Top = top;
            txt.Left = 10;
            txt.Width = 135;
            txt.Text = "Chamado: " + codigochamado.ToString(); // chamado
            txt.Name = "watts" + contador;
            txt.FlatStyle = FlatStyle.Flat;
            txt.Tag = codigo;
            txt.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonClick);
            panel.Controls.Add(txt);

            
            //Novo textBox Consumo
            Label lbl2 = new Label();
            lbl2.Top = top + 25;
            lbl2.Left = 10;
            lbl2.Width = 40;
            lbl2.Text = "Categoria: " + categoria.ToString();
            lbl2.Name = "categoria" + contador; // categoria
            panel.Controls.Add(lbl2);

            //Novo textBox Consumo
            Label lbl1 = new Label();
            lbl1.Top = top + 25;
            lbl1.Left = 105;
            lbl1.Width = 50;
            lbl1.Text = "Abertura: ";
            lbl1.Name = "abertura" + contador;
            panel.Controls.Add(lbl1);

            //Novo textBox Consumo
            Label lbl12 = new Label();
            lbl12.Top = top + 25;
            lbl12.Left = 160;
            lbl12.Text = dataabertura.Date.ToShortDateString().ToString(); // dataAbertura
            lbl12.Name = "aberturaData" + contador;
            panel.Controls.Add(lbl12);


            //Novo textBox Consumo
            Label lbl3 = new Label();
            lbl3.Top = top + 50;
            lbl3.Left = 10;
            lbl3.Width = 220;
            lbl3.Text = "Descrição: " + descricao.ToString();
            lbl3.Name = "descricao" + contador;
            panel.Controls.Add(lbl3);

            //Novo textBox Consumo
            Label lbl4 = new Label();
            lbl4.Top = top + 75;
            lbl4.Left = 10;
            lbl4.Width = 70;
            lbl4.Text = "SLA: " + sla.ToString() + "dias";
            lbl4.Name = "sla" + contador;
            panel.Controls.Add(lbl4);

            //Novo textBox Consumo
            Label lbl5 = new Label();
            lbl5.Top = top + 75;
            lbl5.Left = 105;
            lbl5.Width = 120;
            lbl5.Text = "Resp.: " + responsavel.ToString();
            lbl5.Name = "responsavel" + contador;
            panel.Controls.Add(lbl5);

            ////Novo textBox Consumo
            //Label lbl5 = new Label();
            //lbl5.Top = top + 70;
            //lbl5.Left = 50;
            //lbl5.Text = "Responsavel: " + "Rogerio ";
            //lbl5.Name = "Responsavel" + contador;
            //panel.Controls.Add(lbl5);

            controle.Controls.Add(panel);
            //Incrementa Contador
            //contador = contador + 1;
        }

        private void panel_MouseDown(object sender, MouseEventArgs e)
        {
            this.DoDragDrop(sender, DragDropEffects.Move);
        }

        private void tableFinalizado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmDashBoard_Load(object sender, EventArgs e)
        {


            foreach (var suit in Enum.GetValues(typeof(StatusChamado)))
            {
                StatusChamado statuschamado = (StatusChamado)Enum.Parse(typeof(StatusChamado), suit.ToString());
                var lista = _RepositoryControlChamado.PesquisarChamadoStatusChamado(statuschamado).ToList();
                foreach (var first in lista)
                {
                    contar(first.CodigoChamado, this, suit.ToString(), first.ToString(), first.DataInicio.Value, first.TipoChamado.Nome, first.Descricao, first.TipoChamado.SLA, first.Cliente.Nome,first.Prioridade);
                }
            }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ControlaEfeito(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(System.Windows.Forms.Panel)))
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.Move;
            }
        }

        private void ControlaEfeito(object sender, DragEventArgs e)
        {
            this.ControlaEfeito(e);
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            Panel panel = sender as Panel;
            panel.Controls.Add((Panel)e.Data.GetData(typeof(Panel)));
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}