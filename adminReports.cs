using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsF
{
    public partial class adminReports : Form
    {
        public List<sale> sales { get; set; }

        public adminReports()
        {
            sales = GetSale();
            InitializeComponent();
        }

        private List<sale> GetSale()
        {
            var list = new List<sale>();

            list.Add(new sale()
            {
                saleNumber = "001",
                type = "cash",
                date = "2023/01/01",
                customer = "Sam Smith",
                amnt = 12056.00

            });

            list.Add(new sale()
            {
                saleNumber = "002",
                type = "cash",
                date = "2023/01/02",
                customer = "Simmy Smith",
                amnt = 12056.00

            });

            list.Add(new sale()
            {
                saleNumber = "003",
                type = "cash",
                date = "2023/01/03",
                customer = "John Smith",
                amnt = 12056.00

            });

            list.Add(new sale()
            {
                saleNumber = "004",
                type = "cash",
                date = "2023/01/04",
                customer = "Sam Alen",
                amnt = 12056.00

            });

            list.Add(new sale()
            {
                saleNumber = "005",
                type = "cash",
                date = "2023/01/05",
                customer = "Tim Smith",
                amnt = 12056.00

            });

            list.Add(new sale()
            {
                saleNumber = "006",
                type = "cash",
                date = "2023/01/06",
                customer = "Sam Smith",
                amnt = 12056.00

            });

            list.Add(new sale()
            {
                saleNumber = "007",
                type = "cash",
                date = "2023/01/07",
                customer = "Sam Smith",
                amnt = 12056.00

            });

            return list;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void adminReports_Load(object sender, EventArgs e)
        {
            var sales = this.sales;
            dataGridView1.DataSource = sales;

            chart1.Series["Sales Amnt"].Points.AddXY("mon", 1400);
            chart1.Series["Sales Amnt"].Points.AddXY("tue", 3000);
            chart1.Series["Sales Amnt"].Points.AddXY("wed", 270);
            chart1.Series["Sales Amnt"].Points.AddXY("thur", 2700);
            chart1.Series["Sales Amnt"].Points.AddXY("fri", 4000);
            chart1.Series["Sales Amnt"].Points.AddXY("sat", 3200);
            chart1.Series["Sales Amnt"].Points.AddXY("sun", 1000);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
