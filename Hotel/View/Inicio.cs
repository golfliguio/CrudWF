using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Hotel.View;

namespace Hotel
{
    public partial class Inicio : System.Windows.Forms.Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Iniciar_Click(object sender, EventArgs e)
        {

            Op opera = new Op();
            opera.Show();
         
        }
    }
}
