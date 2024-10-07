using Coffe.Core.Authentication;
using Coffe.Core.Storage;
using Coffe.Entities.Cart;
using Coffe.Entities.Product;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Coffe.UI
{
    public partial class CartPage : Form
    {
        public static List<Product> cartItems = new List<Product>();

        public CartPage()
        {
            InitializeComponent();
        }

        private void Cart_Load(object sender, EventArgs e)
        {
            CartsGridView.DataSource = cartItems;
            CartsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SetTotalPrice();
        }

        private void SetTotalPrice()
        {
            int totalPrice = 0;

            foreach (var item in cartItems)
            {
                totalPrice += item.price;
            }

            totalPriceText.Text = totalPrice.ToString();
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (CartsGridView.SelectedRows.Count > 0)
            {
                int rowIndex = CartsGridView.SelectedRows[0].Index;
                CartsGridView.Rows.RemoveAt(rowIndex);
                cartItems.RemoveAt(rowIndex);
                SetTotalPrice();
            }
            else
            {
                MessageBox.Show("please select a product to remove");
            }
        }

        private void orderBtn_Click(object sender, EventArgs e)
        {
            List<String> productsId = new List<String>();

            foreach (var item in cartItems)
            {
                productsId.Add(item.id);
            }

            Cart newCart = new Cart()
            {
                id = new Guid().ToString(),
                userId = LogedInUser.userName,
                productIds = productsId
            };

            DataBase.Instance.Store<Cart>(newCart);
        }
    }
}
