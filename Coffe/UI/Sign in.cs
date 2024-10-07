using Coffe.Core.Storage;
using Coffe.Entities.Users;
using Coffe.form;
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
    public partial class Sign_IN : Form
    {
        public Sign_IN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void signinUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private async void buttonSignin_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(signinPassword.Text))
            {
                MessageBox.Show("Please enter your password");
                return;
            }
            if (string.IsNullOrEmpty(signinUsername.Text))
            {
                MessageBox.Show("Please enter your Username");
                return;
            }

            var user = signinUsername.Text;
            var pas = signinPassword.Text;
            var check = await DataBase.Instance.Read<User>(p => p.userName == user);
            if (check == null)
            {
                MessageBox.Show("You are not registered yet!");
                Form signUp = new Sign_UP();
                signUp.ShowDialog();
                Close();
            }

            if (check.FirstOrDefault().password == pas)
            {
                MessageBox.Show("you are logged in");
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Password");
            }

        }

        private void signinPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sign_IN_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
