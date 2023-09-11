using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace WindowsF
{
    public partial class Checkout : Form
    {
        public Checkout()
        {
           
            InitializeComponent();
        }

        



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Receipt frm = new Receipt())
            {
                frm.ShowDialog();
            }
        }

        private void Checkout_Load(object sender, EventArgs e)
        {

        }
    }
}
