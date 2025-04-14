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
using static Integradora.Products.Manager.Products_Manager;
using static Integradora.Program;

namespace Integradora.Products.Inventory
{
    public partial class Products_Inventory_ModifyPrice : Form
    {
        private readonly Product Product;
        private readonly Products_Inventory_Menu Main;

        public Products_Inventory_ModifyPrice(Product product, Products_Inventory_Menu main)
        {
            InitializeComponent();
            Main = main;

            Product = product;
            Update_CurrentProductLBL();

            SetVisibleCore(true);
        }
        private void Update_CurrentProductLBL()
        {
            if (Product is null) throw new Exception($"Product: {Product} is null");

            CurrentProductLBL.Text = $"{Product.Name} cuesta {Product.Price} actualmente";
        }

        private void OvrPriceTXT_TextChanged(object sender, EventArgs e) => TestTextToDOUBLE(ref OvrPriceTXT);
        private void OvrPriceBTN_Click(object sender, EventArgs e)
        {
            if (TestTextToDOUBLE(ref OvrPriceTXT)) UpdatePrice(double.Parse(OvrPriceTXT.Text));
        }
        private void UpdatePrice(double price)
        {
            Product.Price.ActualNumberInsteadOfString = price;

            DataBaseManager.ExecuteNonQuery($"update {_Products_Manager.TableName} set price = {Product.Price.ActualNumberInsteadOfString} where ID = {Product.ID};");

            _Products_Manager.UpdateDataBase();
            Main.UpdateProductsCMBOX();
            Update_CurrentProductLBL();
        }
    }
}
