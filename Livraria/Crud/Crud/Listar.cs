using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace Crud
{
    public partial class Listar : Form
    {
        private BindingSource bindingSource = new BindingSource();

        public Listar()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Controller controller = new Controller();
                dataGridView1.DataSource = controller.Listar();//popula o grid
                dataGridView1.ToString();
                
                           
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
