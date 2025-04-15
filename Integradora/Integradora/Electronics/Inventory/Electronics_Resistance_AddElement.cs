using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Integradora.Program;
using static Integradora.Electronics.Manager.Electronics_Resistance_Manager;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Resistance_AddElement : Form
    {
        private Electronics_Inventory_Menu Main;

        public Electronics_Resistance_AddElement(Electronics_Inventory_Menu main)
        {
            InitializeComponent();
            SetVisibleCore(true);
            StatusLBL.Text = "";

            Main = main;
        }

        private void NameTXT_TextChanged(object sender, EventArgs e) => TestName();
        private bool TestName() => TestTextToSTRING(ref NameTXT);

        private void UnitsTXT_TextChanged(object sender, EventArgs e) => TestUnits();
        private bool TestUnits() => TestTextToINT(ref UnitsTXT, "0");

        private void SalesTXT_TextChanged(object sender, EventArgs e) => TestSales();
        private bool TestSales() => TestTextToINT(ref SalesTXT, "0");

        private void PriceTXT_TextChanged(object sender, EventArgs e) => TestPrice();
        private bool TestPrice() => TestTextToDOUBLE(ref PriceTXT, "0");

        private void ResistanceTXT_TextChanged(object sender, EventArgs e) => TestResistance();
        private bool TestResistance() => TestTextToDECIMAL(ref ResistanceTXT, "0");

        private void AddResistanceBTN_Click(object sender, EventArgs e)
        {
            if (!TestName())
            {
                StatusLBL.Text = "Error en Nombre";
                return;
            }

            if (!TestUnits())
            {
                StatusLBL.Text = "Error en unidades";
                return;
            }

            if (!TestSales())
            {
                StatusLBL.Text = "Error en ventas";
                return;
            }

            if (!TestPrice())
            {
                StatusLBL.Text = "Error en precio";
                return;
            }

            if (!TestResistance())
            {
                StatusLBL.Text = "Error en resistencia";
                return;
            }

            try
            {
                Resistance resistance = new(NameTXT.Text, int.Parse(UnitsTXT.Text), int.Parse(SalesTXT.Text), default, double.Parse(PriceTXT.Text), decimal.Parse(ResistanceTXT.Text));
                DataBaseManager.InsertInto(_Resistance_Manager.TableName, resistance.GetDataForInsert());
                StatusLBL.Text = "Todo bien";
                _Resistance_Manager.UpdateDataBase();

                Main.UpdateElectronicsCMBOX();
            }
            catch (Exception ex)
            {
                StatusLBL.Text = $"Hubo un error \n{ex}";
            }
        }
    }
}
