using Coffe.Core.Storage;
using Coffe.Entities.Materials;
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
    public partial class AddProduct : Form
    {
        Dictionary<CheckBox, string> checkBoxes = new Dictionary<CheckBox, string>();

        public AddProduct()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private async void AddProduct_Load(object sender, EventArgs e)
        {
            var materials = await DataBase.Instance.Read<Materials>();

            foreach (var material in materials)
            {
                CheckBox newMaterial = new CheckBox();
                newMaterial.Name = material.name;
                checkBoxes.Add(newMaterial,material.id);
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(productName.Text))
            {
                MessageBox.Show("please fill productName box");
                return;
            }

            var selectedMaterials = new List<string>();

            foreach (var checkBoxe in checkBoxes)
            {
                if (checkBoxe.Key.Checked == true)
                {
                    selectedMaterials.Add(checkBoxe.Value);
                }
            }

            if (selectedMaterials == null || selectedMaterials.Count == 0)
            {
                MessageBox.Show("please select at least one material");
                return;
            }
            Product newProduct = new Product()
            {
                id = new Guid().ToString(),
                name = productName.Text,
                price = (int)productPrice.Value,
                materialsId = selectedMaterials
            };

            DataBase.Instance.Store<Product>(newProduct);

        }
    }
}
