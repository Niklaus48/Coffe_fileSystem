using Coffe.Core.Storage;
using Coffe.Entities.Users;
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
            if (string.IsNullOrEmpty(signupUsername.Text))
            {
                MessageBox.Show("enter username ");
                return;
            }

            if (string.IsNullOrEmpty( signupPassword.Text))
            {
                MessageBox.Show("enter Password ");
                return;
            }

            if (string.IsNullOrEmpty(signupDis.Text))
            {
                MessageBox.Show("enter Displayname ");
                return;
            }

            if (string.IsNullOrEmpty(signupPhone.Text))
            {
                MessageBox.Show("enter phoneNumber ");
                return;
            }

            User user = new User()
            {
                displayName = signupDis.Text,
                userName = signupUsername.Text,
                password = signupPassword.Text,
                phoneNumber = signupPhone.Text,
            };

            try
            {
                DataBase.Instance.Store(user);
            }
            catch
            {
                MessageBox.Show("You have already registered");
                Form signIn = new Sign_IN();
                signIn.ShowDialog();
            }



        }
    }
}
