using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hotel.Model;
using Hotel.Controller;

namespace Hotel.View
{
    public partial class Excluir : Form
    {
        public Excluir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//voltar
        {
            Op op = new Op();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)//Excluir
        {
            try
            {
                int CPF = Convert.ToInt32(textBox1.Text);//pega o cpf no label
                Hospede hospede = new Hospede();
                hospede.Codigo = CPF;

                Controller.Controller controller = new Controller.Controller();
                controller.Excluir(hospede.Codigo);//excluir o hospede com cpf indicado

                MessageBox.Show(hospede.Nome+ " Excluido com sucesso!!");

                textBox1.Text = " ";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
