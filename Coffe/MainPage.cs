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

            User user = new User()
            {
                displayName = "Khar",
                userName = "Test",
                password = "44",
                phoneNumber = "1234567890",
            };

            User user1 = new User()
            {
                displayName = "sag",
                userName = "Test1",
                password = "28",
                phoneNumber = "1234512",
            };

            User user2 = new User()
            {
                displayName = "goraz",
                userName = "Test1",
                password = "44",
                phoneNumber = "1234512",
            };
        }
    }
}
