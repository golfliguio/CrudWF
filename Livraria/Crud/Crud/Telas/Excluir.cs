using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crud
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(textBox1.Text);
                //pega texto do label
                Livro l = new Livro();
                l.Codigo = Codigo;

                Controller cont = new Controller();

                cont.Excluir(l.Codigo);

                MessageBox.Show(" Livro " + l.Titulo+ " - excluido com sucesso!!");


                textBox1.Text = "";
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();

            Dispose();
        }
    }
}
