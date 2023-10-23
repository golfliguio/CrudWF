using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel.View
{
    public partial class Consultar : Form
    {
        public Consultar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotel.View.Op op = new Op();
            op.Show();
        }

        private void Consultar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Hospede'. Você pode movê-la ou removê-la conforme necessário.
            this.hospedeTableAdapter.Fill(this.masterDataSet.Hospede);

        }
    }
}
