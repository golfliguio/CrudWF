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
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)//voltar
        {           
            Op op = new Op();
            op.Show();        
            

        }

        private void button1_Click(object sender, EventArgs e)//gravar
        {
            try
            {
                Hospede hospede = new Hospede();

                hospede.Codigo = Convert.ToInt32(textBox1.Text);
                hospede.Nome = textBox2.Text;
                hospede.Telefone = Convert.ToInt32(textBox3.Text);
                hospede.Endereco = textBox4.Text;
                hospede.Dias = Convert.ToInt32(textBox5.Text);

                Controller.Controller controller = new Controller.Controller();
                controller.Gravar(hospede);


            
                
                MessageBox.Show("Hospede " + hospede.Nome + " gravado com sucesso!!");

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = " ";
                textBox5.Text = " ";
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
