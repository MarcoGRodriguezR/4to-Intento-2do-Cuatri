using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Integrator.Products.Manager;
using static Integrator.Products.Manager.Products_Manager;
using static Integrator.Program;

namespace Integrator.Products.Inventory
{
    public partial class Products_Inventory_ModifyUnits : Form
    {
        private Product Product;
        private Products_Inventory_Menu Main;

        public Products_Inventory_ModifyUnits(Product product, Products_Inventory_Menu main)
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

            CurrentProductLBL.Text = (Product.Units == 1) switch
            {
                true => $"{Product.Name} tiene {Product.Units} unidad actualmente",
                _ => $"{Product.Name} tiene {Product.Units} unidades actualmente",
            };
        }

        private void AddUnitsTXT_TextChanged(object sender, EventArgs e) => TestTextToINT(ref AddUnitsTXT);
        private void AddUnitsBTN_Click(object sender, EventArgs e)
        {
            if (TestTextToINT(ref AddUnitsTXT)) UpdateUnits(int.Parse(AddUnitsTXT.Text));
        }


        private void SubUnitsTXT_TextChanged(object sender, EventArgs e) => TestTextToINT(ref SubUnitsTXT);

        private void SubUnitsBTN_Click(object sender, EventArgs e)
        {
            if (TestTextToINT(ref SubUnitsTXT)) UpdateUnits(-int.Parse(SubUnitsTXT.Text));
        }

        private void UpdateUnits(int amount)
        {
            Product.Units += amount;

            DataBaseManager.ExecuteNonQuery($"update {_Products_Manager.TableName} set units = {Product.Units} where ID = {Product.ID};");

            _Products_Manager.UpdateDataBase();
            Main.UpdateProductsCMBOX();
            Update_CurrentProductLBL();

        }

    }
}
