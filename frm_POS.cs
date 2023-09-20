using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PointOfSale.Databaselayer

{
    public partial class frm_POS : Form
    {
        frm_Customer  customerform;
        
        public frm_POS()
        {
            InitializeComponent();
        }

        private void frm_POS_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void addNewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (customerform == null)
            {
                customerform = new frm_Customer();
            }
            customerform.MdiParent = this;
            customerform.Show();
        }

        private void addNewToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (customerform == null)
            {
                customerform = new frm_Customer();
            }
            customerform.MdiParent = this;
            customerform.Show();
        }
    }
}
