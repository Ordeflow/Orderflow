using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Order_Flow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel14.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker4_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_grafico_Click(object sender, EventArgs e)
        {

        }

        private void btn_grafico_Click_1(object sender, EventArgs e)
        {
            form_grafico graficoform = new form_grafico();
            graficoform.TopLevel = false;
            graficoform.Parent = this;
            graficoform.Location = new Point(0 ,0);
            graficoform.Show();
            graficoform.BringToFront();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            form_adicionar adicionarform = new form_adicionar();

            adicionarform.TopLevel = false;
            adicionarform.Parent = this;
            adicionarform.Location = new Point(0, 0);

            adicionarform.Show();
            adicionarform.BringToFront();
        }

        private void btn_historico_Click(object sender, EventArgs e)
        {
            form_historico historicoform = new form_historico();
            historicoform.TopLevel = false;
            historicoform.Parent = this;
            historicoform.Location = new Point(0, 0);

            historicoform.Show();
            historicoform.BringToFront();
        }

        private void btn_editar_Click(object sender, EventArgs e)
        {
            forms_editar editarform = new forms_editar();
            editarform.TopLevel = false;
            editarform.Parent = this;
            editarform.Location = new Point(0, 0);
            editarform.Show();
            editarform.BringToFront();
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            form_excluir excluirform = new form_excluir();
            excluirform.TopLevel = false;
            excluirform.Parent = this;
            excluirform.Location = new Point(0, 0);

            excluirform.Show();
            excluirform.BringToFront();
        }
    }
}
