using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crud
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Livro l = new Livro();

                l.Titulo = textBox1.Text;
                l.Autor = textBox2.Text;
                l.Lancamento = textBox3.Text;

                Controller cont = new Controller();
                cont.Gravar(l);

             MessageBox.Show( " Livro " +l.Titulo+ " - Cadastrado com sucesso!!");


                textBox1.Text= "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();

            ini.Show();
            Dispose();
        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
