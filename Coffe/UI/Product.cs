using Coffe.Core.Storage;
using Coffe.Entities.Product;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe.UI
{
    public partial class ProductView : Form
    {
        public ProductView()
        {
            InitializeComponent();
        }

        private async void Product_Load(object sender, EventArgs e)
        {
            var products = await DataBase.Instance.Read<Product>();

            foreach (var product in products)
            {
                
            }
            productList.DataSource = products;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
