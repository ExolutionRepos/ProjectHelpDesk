﻿using Library.Class.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop.Chamado
{
    public partial class frmDashBoard : Form
    {
        public frmDashBoard()
        {
            InitializeComponent();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void contar(Control controle)
        {
            var vazio = 0;
            var cheio = 0;
            var contador = 0;

            var Lista = from n in controle.Controls.Cast<Control>()
                                   orderby int.Parse(n.Tag.ToString())
                                   select n;

            var Listar = controle.Controls.Cast<Control>()
                .OrderBy(y => StringExtension.ToInt32(y.TabIndex.ToString()))
                .ToList();
            

            foreach (Control item in Listar)
            {
                if (item.GetType() == typeof(TableLayoutPanel))
                {
                    contar(item);
                    break;
                }

                if (item.GetType() == typeof(GroupBox))
                {
                    contar(item);
                    break;
                }

                if (item.GetType() == typeof(Panel))
                {
                    contador++;
                    if (((Panel)item).Controls.Count == 0)
                    {
                        AddNewTextBox(item, contador);
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

        public void AddNewTextBox(Control controle, int contar)
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
            picture.BackColor = Color.Red;
            picture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_MouseDown);
            //Adiciona no Form
            panel.Controls.Add(picture);

            Button txt = new Button();
            txt.Top = top;
            txt.Left = 10;
            txt.Text = "Chamado: " + this.contador.ToString();
            txt.Name = "watts" + contador;
            txt.FlatStyle = FlatStyle.Flat;
            panel.Controls.Add(txt);

            //Novo textBox Consumo
            Label lbl1 = new Label();
            lbl1.Top = top + 25;
            lbl1.Left = 10;
            lbl1.Text = "Abertura: " + DateTime.Now.Date.ToShortDateString();
            lbl1.Name = "abertura" + contador;
            panel.Controls.Add(lbl1);

            //Novo textBox Consumo
            Label lbl2 = new Label();
            lbl2.Top = top + 50;
            lbl2.Left = 10;
            lbl2.Text = "Categoria: " + "teste";
            lbl2.Name = "categoria" + contador;
            panel.Controls.Add(lbl2);

            //Novo textBox Consumo
            Label lbl3 = new Label();
            lbl3.Top = top + 55;
            lbl3.Left = 10;
            lbl3.Text = "Descrição: " + "Vamos testar neh" + "/n kkkk testa";
            lbl3.Name = "descricao" + contador;
            panel.Controls.Add(lbl3);

            //Novo textBox Consumo
            Label lbl4 = new Label();
            lbl4.Top = top + 70;
            lbl4.Left = 10;
            lbl4.Text = "SLA: " + "2 dias";
            lbl4.Name = "sla" + contador;
            panel.Controls.Add(lbl4);

            //Novo textBox Consumo
            Label lbl5 = new Label();
            lbl5.Top = top + 70;
            lbl5.Left = 50;
            lbl5.Text = "Responsavel: " + "Rogerio ";
            lbl5.Name = "Responsavel" + contador;
            panel.Controls.Add(lbl5);

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
            contar(this);
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
    }
}
