using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Integradora.Products.Inventory;

using static Integradora.Products.Manager.Products_Manager;
using static Integradora.Program;

namespace Integradora.Products.Inventory
{
    public partial class Products_Inventory_Menu : Form
    {
        public Products_Inventory_Menu()
        {
            InitializeComponent();
            SetVisibleCore(true);


            _Products_Manager.SetUpDatabase();

            UpdateProductsCMBOX();
        }
        public void UpdateProductsCMBOX()
        {
            ProductsCMBOX.Items.Clear();

            foreach (Product product in _Products_Manager.Products) ProductsCMBOX.Items.Add(product.Name);
            if (ProductsCMBOX.Items.Count > 0) ProductsCMBOX.SelectedItem = ProductsCMBOX.Items[0];
            else MainText.Text = "No hay productos";
        }

        private void ProductsCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Edge-Case guarding
            if (ProductsCMBOX.Items.Count <= 0 || ProductsCMBOX.SelectedIndex < 0) return;

            if (ProductsCMBOX.SelectedIndex >= ProductsCMBOX.Items.Count) ProductsCMBOX.SelectedItem = ProductsCMBOX.Items[0];
            #endregion

            string? text = _Products_Manager.Products[ProductsCMBOX.SelectedIndex].ToString();
            text ??= $"Error al intentar acceder el elemento {ProductsCMBOX.SelectedIndex}";

            MainText.Text = text;
        }

        private void AddProductBTN_Click(object sender, EventArgs e) => _ = new Products_Inventory_AddProduct(this);

        private void RemoveProductBTN_Click(object sender, EventArgs e) => _ = new Products_Inventory_RemoveProduct(this);

        private void ModifyUnitsBTN_Click(object sender, EventArgs e)
        {
            if (ProductsCMBOX.Items.Count > 0) _ = new Products_Inventory_ModifyUnits(_Products_Manager.Products[ProductsCMBOX.SelectedIndex], this);
        }

        private void ModPriceBTN_Click(object sender, EventArgs e)
        {
            if (ProductsCMBOX.Items.Count > 0) _ = new Products_Inventory_ModifyPrice(_Products_Manager.Products[ProductsCMBOX.SelectedIndex], this);
        }

        private void ModNameBTN_Click(object sender, EventArgs e)
        {
            if (ProductsCMBOX.Items.Count > 0) _ = new Products_Inventory_ModifyName(_Products_Manager.Products[ProductsCMBOX.SelectedIndex], this);

        }
    }
}
