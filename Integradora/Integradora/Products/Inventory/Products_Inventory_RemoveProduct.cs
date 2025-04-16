using Integrator.Products.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Integrator.Products.Manager;

using static Integrator.Program;
using static Integrator.Products.Manager.Products_Manager;

namespace Integrator.Products.Inventory
{
    public partial class Products_Inventory_RemoveProduct : Form
    {
        private Products_Inventory_Menu Main;

        public Products_Inventory_RemoveProduct(Products_Inventory_Menu main)
        {
            InitializeComponent();
            Main = main;

            UpdateCMBOX();

            SetVisibleCore(true);
        }
        private void UpdateCMBOX()
        {
            ProductsCOMBOX.Items.Clear();
            foreach (Product product in _Products_Manager.Products) ProductsCOMBOX.Items.Add(product.Name);
            if (ProductsCOMBOX.Items.Count > 0) ProductsCOMBOX.SelectedItem = ProductsCOMBOX.Items[0];
        }

        private void RemoveProductBTN_Click(object sender, EventArgs e)
        {
            if (ProductsCOMBOX.Items.Count <= 0 || ProductsCOMBOX.Items is null)
            {
                StatusLBL.Text = "No hay productos para eliminar";
                return;
            }

            try
            {
                Product pro = _Products_Manager.Products[ProductsCOMBOX.SelectedIndex];
                DataBaseManager.ExecuteNonQuery($"delete from {_Products_Manager.TableName} where ID = {pro.ID}");

                _Products_Manager.UpdateDataBase();
                Main.UpdateProductsCMBOX();
                UpdateCMBOX();

                StatusLBL.Text = "Se ha eliminado el producto exitosamente";
            }
            catch (Exception exception)
            {
                StatusLBL.Text = "Hubo un error";
                Console.WriteLine(exception);
            }
        }
    }
}
