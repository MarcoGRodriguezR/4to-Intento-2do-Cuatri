using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Integradora._Generics.Manager.Generics_Manager;
using static Integradora.Program;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Generic_ModifyPrice : Form
    {
        private Electronics_Inventory_Menu Main;
        private string TableName, NameToUse;
        private int ID;
        private Element.PriceHelper Price;

        public Electronics_Generic_ModifyPrice(Electronics_Inventory_Menu main, string tableName, string name, double price, int id)
        {
            InitializeComponent();
            SetVisibleCore(true);

            Main = main;
            TableName = tableName;
            NameToUse = name;
            Price = new(price);
            ID = id;

            UpdateCurrentElectronic();

        }
        private void UpdateCurrentElectronic()
        {
            CurrentElectronicLBL.Text = $"{NameToUse} cuesta {Price} actualmente";
        }

        private void OvrPriceTXT_TextChanged(object sender, EventArgs e) => TestPriceTXT();
        private bool TestPriceTXT() => TestTextToDOUBLE(ref OvrPriceTXT);
        private void OvrPriceBTN_Click(object sender, EventArgs e)
        {
            if (TestPriceTXT()) UpdatePrice(double.Parse(OvrPriceTXT.Text));
        }

        private void UpdatePrice(double price)
        {
            if (!TestPriceTXT())
            {
                CurrentElectronicLBL.Text = "Error al acceder el numero";
                return;
            }

            Price.ActualNumberInsteadOfString = price;

            DataBaseManager.ExecuteNonQuery($"update {TableName} set {Elements_Properties.Price} = {Price.ActualNumberInsteadOfString} where ID = {ID}");

            Main.UpdateDatabaseBasedOnElectronicTypesCMBOX();
            Main.UpdateElectronicsCMBOX();
            UpdateCurrentElectronic();
        }

    }
}
