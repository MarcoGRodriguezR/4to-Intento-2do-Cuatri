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
    public partial class Products_Inventory_ModifyName : Form
    {

        private readonly Product Product;
        private readonly Products_Inventory_Menu Main;

        public Products_Inventory_ModifyName(Product product, Products_Inventory_Menu main)
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

            CurrentProductLBL.Text = $"El nombre del producto es: {Product.Name}";
        }

        private void OvrNameTXT_TextChanged(object sender, EventArgs e) => TestTextToSTRING(ref OvrNameTXT);
        private void OvrNameBTN_Click(object sender, EventArgs e)
        {
            if (TestTextToSTRING(ref OvrNameTXT)) UpdateName(OvrNameTXT.Text);
        }

        private void UpdateName(string name)
        {
            Product.Name = name;

            DataBaseManager.ExecuteNonQuery($"update {_Products_Manager.TableName} set name = '{Product.Name}' where ID = {Product.ID};");

            _Products_Manager.UpdateDataBase();
            Main.UpdateProductsCMBOX();
            Update_CurrentProductLBL();
        }
    }
}
