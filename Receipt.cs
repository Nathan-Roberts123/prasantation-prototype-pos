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
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();
        }

        void getData()
        {
            ReportDataSource rs = new ReportDataSource();
            var prds = new List<Product>();

            prds.Add(new Product()
            {
                ProductId = 1,
                ProductName = "burger",
                Qty = 2,
                Price = 123.00,
                Total = 2 * 123.00
            });

            rs.Name = "DataSet1";
            rs.Value = prds;
            this.reportViewer2.LocalReport.DataSources.Add(rs);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "WindowsF.Report1.rdlc";

            this.Controls.Add(reportViewer2);
            this.reportViewer2.RefreshReport();

        }

        private void Receipt_Load(object sender, EventArgs e)
        {
         
            this.getData();

        }

        private void reportViewer2_Load(object sender, EventArgs e)
        {

        }
    }
}
