using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


using Listar;


namespace Crud
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            



        }

        private void button1_Click(object sender, EventArgs e)
        {

            Cadastro cad = new Cadastro();
            cad.Show();

           
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Excluir ex = new Excluir();
            ex.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Atualiza at = new Atualiza();
            at.Show();


        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }
    }
}
