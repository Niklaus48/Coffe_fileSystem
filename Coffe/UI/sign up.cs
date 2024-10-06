using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coffe.form
{
    public partial class Sign_UP : Form
    {
        public Sign_UP()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if(signupUsername.Text == null)
            {
                MessageBox.Show("enter username ");
                return;
            }

            if (signupPassword.Text == null)
            {
                MessageBox.Show("enter Password ");
                return;
            }

            if (signupDis.Text == null)
            {
                MessageBox.Show("enter Displayname ");
                return;
            }

            if (signupPhone.Text == null)
            {
                MessageBox.Show("enter phoneNumber ");
                return;
            }



        }
    }
}
