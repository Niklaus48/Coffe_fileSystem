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

            List<int> ids = new List<int>();
            ids.Add(1);
            ids.Add(2);
            ids.Add(3);

            Product product = new Product()
            {
                name = "Ghahve",
                price = 200,
                materialsId = ids,
                id = 1,
            };

            DataBase.Instance.Store(user, "Users\\users.txt");
            DataBase.Instance.Store(user1, "Users\\users.txt");
            DataBase.Instance.Store(user2, "Users\\users.txt");
            DataBase.Instance.Store(product, "Products\\products.txt");

            var sag = DataBase.Instance.Read<User>("Users\\users.txt", p => p.password == "44");

            foreach (var item in sag)
            {
                Console.WriteLine(item.displayName);
            }

            Console.WriteLine(sag);
        }
    }
}
