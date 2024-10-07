using Coffe.Core.Storage;
using Coffe.Entities.Product;
using Coffe.Entities.Users;
using Coffe.form;
using Coffe.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {

            //Form signup = new Sign_UP();
            //signup.ShowDialog();

            Form signIn = new Sign_IN();
            signIn.ShowDialog();

            //Form addProduct = new AddProduct();
            //addProduct.ShowDialog();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignup_Click(object sender, EventArgs e)
        {

        }
    }
}
