using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hotel.Controller;
using Hotel.Model;

namespace Hotel.View
{
    public partial class Atualiza : Form
    {
        public Atualiza()
        {
            InitializeComponent();
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                int CPF = Convert.ToInt32(textBox1.Text);

                Controller.Controller controller = new Controller.Controller();

                Hospede hospede = (controller.PesquisarPorCodigo(CPF));

                if (hospede != null)
                {
                    textBox2.Text = hospede.Nome;
                    textBox3.Text = Convert.ToString(hospede.Telefone);
                    textBox4.Text = hospede.Endereco;
                    textBox5.Text = Convert.ToString(hospede.Dias);
                }

                //se existir hopede cadastrado de acordo com o cpf
                //retorna dados mo textbox
                else
                {
                    MessageBox.Show("Cliente não encontrado!!");
                }
            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)//voltar
        {
            Op op = new Op();
            op.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Hospede hospede = new Hospede();

                hospede.Codigo = Convert.ToInt32(textBox1.Text);
                hospede.Nome = textBox2.Text;
                hospede.Telefone= Convert.ToInt32(textBox3.Text);
                hospede.Endereco = textBox4.Text;
                hospede.Dias = Convert.ToInt32(textBox5.Text);//recebe dados do text box para inserir posteriormente na atualizaçõa do bd

                Controller.Controller controller = new Controller.Controller();
                controller.Atualizar(hospede);


                MessageBox.Show("Dados do hospede " + hospede.Nome + " atualizado com sucesso!!");

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
