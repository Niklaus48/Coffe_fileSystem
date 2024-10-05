using Coffe.Core.Storage;
using Coffe.Entities.Product;
using Coffe.Entities.Users;
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
            User user = new User()
            {
                displayName = "Test",
                userName = "Test2",
                password = "Test3",
                phoneNumber = "1234567890",
            };

            List<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);

            Product product = new Product()
            {
                name = "Ghahve",
                price = 200,
                materialsId = ids ,
                id = 1,
            };
            DataBase dataBase = new DataBase();
            dataBase.Store<User>(user);
            Console.WriteLine("\n");
            dataBase.Store<Product>(product);
        }
    }
}
