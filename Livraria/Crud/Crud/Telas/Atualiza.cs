using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Crud
{
    public partial class Atualiza : Form
    {
        public Atualiza()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Livro l = new Livro();

                l.Codigo = Convert.ToInt32(textBox1.Text);
                l.Titulo = textBox2.Text;
                l.Autor = textBox3.Text;
                l.Lancamento = textBox4.Text;

                Controller cont = new Controller();

                cont.Atualizar(l);

                MessageBox.Show(" Livro " + l.Titulo + " - Atualizado com sucesso!!");


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
            

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int Codigo = Convert.ToInt32(textBox1.Text);//pega o valor no textbox de pesquisa

                Controller cont = new Controller();

                Livro l = cont.PesquisarPorCodigo(Codigo);

                if(l!=null)
                {
                    textBox2.Text = l.Titulo;
                    textBox3.Text = l.Autor;
                    textBox4.Text = l.Lancamento;

                    //se existir livro cadastrado, retorna os valores na textbox de acordo com o codigo inserido
                }
                else
                {
                    MessageBox.Show("Livro não encontrado no Acervo");
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Inicio ini = new Inicio();
            ini.Show();
            Dispose();
        }
    }
}
