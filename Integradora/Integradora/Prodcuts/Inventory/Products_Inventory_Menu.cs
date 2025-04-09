using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Integradora.Products.Manager;

namespace Integradora.Products.Inventory
{
    public partial class Products_Inventory_Menu : Form
    {
        public Products_Inventory_Menu()
        {
            InitializeComponent();
            SetVisibleCore(true);
            Products_Manager.SetUpDataBase();

            UpdateProductsCMBOX();
        }
        private void UpdateProductsCMBOX()
        {
            ProductsCMBOX.Items.Clear();

            foreach (Products_Manager.Product product in Products_Manager.Products) ProductsCMBOX.Items.Add(product.Name);
            if (ProductsCMBOX.Items.Count > 0) ProductsCMBOX.SelectedItem = ProductsCMBOX.Items[0];
        }

        private void ProductsCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Edge-Case guarding
            if (ProductsCMBOX.Items.Count <= 0 || ProductsCMBOX.SelectedIndex < 0) return;

            if (ProductsCMBOX.SelectedIndex >= ProductsCMBOX.Items.Count) ProductsCMBOX.SelectedItem = ProductsCMBOX.Items[0];
            #endregion

            string? text = Products_Manager.Products[ProductsCMBOX.SelectedIndex].ToString();
            text ??= $"Error al intentar acceder el elemento {ProductsCMBOX.SelectedIndex}";

            MainText.Text = text;
        }
    }
}
