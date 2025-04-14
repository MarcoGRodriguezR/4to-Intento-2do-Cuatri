using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

using Integradora.Products.Inventory;
using Integradora.Products.Manager;

using static Integradora.Program;
using static Integradora.Products.Manager.Products_Manager;

namespace Integradora.Products.Inventory
{
    public partial class Products_Inventory_AddProduct : Form
    {
        private Products_Inventory_Menu Main;
        public Products_Inventory_AddProduct(Products_Inventory_Menu main)
        {
            InitializeComponent();
            SetVisibleCore(true);
            Main = main;
        }

        private void NameText_TextChanged(object sender, EventArgs e) => Verify_NameText();
        private bool Verify_NameText()
        {
            // 2025 Apr 09: This is probably not needed, just keeping it as a failsafe
            return !(NameText.Text is null or "");
        }
        private void UnitsText_TextChanged(object sender, EventArgs e) => Verify_UnitsText();
        private bool Verify_UnitsText()
        {
            try
            {
                int test = int.Parse(UnitsText.Text);
                return true;
            }
            catch
            {
                UnitsText.Text = "0";
                return false;
            }
        }

        private void SalesText_TextChanged(object sender, EventArgs e) => Verify_SalesText();
        private bool Verify_SalesText()
        {
            try
            {
                int test = int.Parse(SalesText.Text);
                return true;
            }
            catch
            {
                SalesText.Text = "0";
                return false;
            }
        }

        private void PriceText_TextChanged(object sender, EventArgs e) => Verify_PriceText();
        private bool Verify_PriceText()
        {
            try
            {
                double test = double.Parse(PriceText.Text);
                return true;
            }
            catch
            {
                PriceText.Text = "0";
                return false;
            }
        }

        private void AddProductBTN_Click(object sender, EventArgs e)
        {
            if (!Verify_NameText())
            {
                StatusLabel.Text = "Nombre vacio";
                return;
            }

            if (!Verify_UnitsText())
            {
                StatusLabel.Text = "Error en el campo unidades";
                return;
            }

            if (!Verify_SalesText())
            {
                StatusLabel.Text = "Error en el campo ventas";
                return;
            }

            if (!Verify_PriceText())
            {
                StatusLabel.Text = "Error en el campo precio";
                return;
            }

            try
            {
                Product product = new(NameText.Text, int.Parse(UnitsText.Text), int.Parse(SalesText.Text), price: double.Parse(PriceText.Text));
                DataBaseManager.InsertInto(_Products_Manager.TableName, product.GetDataForInsert());
                _Products_Manager.UpdateDataBase();

                Main.UpdateProductsCMBOX();

                StatusLabel.Text = "Se agregó exitosamente";
            }
            catch
            {
                StatusLabel.Text = "Hubo un error";
            }
        }
    }
}
