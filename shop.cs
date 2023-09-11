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
    public partial class shop : Form
    {
        public List<Product> Products { get; set; }
        public List<StoreProduct> StoreProducts { get; set; }

        public shop()
        {
            Products = GetProducts();
            StoreProducts = GetStoreProducts();
            InitializeComponent();
        }

        private List<StoreProduct> GetStoreProducts()
        {
            var list = new List<StoreProduct>();
            list.Add(new StoreProduct()
            {
                ProductName = "burger",
                Price = 123.00,

            });

            list.Add(new StoreProduct()
            {
                ProductName = "Pie",
                Price = 123.00,

            });

            list.Add(new StoreProduct()
            {
                ProductName = "Fries",
                Price = 123.00,

            });

            return list;
        }

        private List<Product> GetProducts()
        {
            var list = new List<Product>();

            list.Add(new Product()
            {
                ProductId = 1,
                ProductName = "burger",
                Qty = 2,
                Price = 123.00,
                Total = 2 * 123.00

            }) ;

            return list;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void shop_Load(object sender, EventArgs e)
        {
            var products = this.Products;
            var StoreProducts = this.StoreProducts;

            dataGridView1.DataSource = products;
            dataGridView2.DataSource = StoreProducts;
        } 

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
