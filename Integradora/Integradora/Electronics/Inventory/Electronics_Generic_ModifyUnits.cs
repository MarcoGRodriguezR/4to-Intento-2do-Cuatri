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
using static Integradora._Generics.Manager.Generics_Manager;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Generic_ModifyUnits : Form
    {
        private Electronics_Inventory_Menu Main;
        private string TableName, NameToUse;
        private int Units, ID;


        public Electronics_Generic_ModifyUnits(Electronics_Inventory_Menu main, string tableName, string name, int units, int id)
        {
            InitializeComponent();
            SetVisibleCore(true);

            Main = main;
            TableName = tableName;
            NameToUse = name;
            Units = units;
            ID = id;

            UpdateCurrentElectronic();
        }

        private void UpdateCurrentElectronic()
        {
            CurrentElemenLBL.Text = (Units == 1) switch
            {
                true => $"{NameToUse} tiene {Units} unidad actualmente",
                _ => $"{NameToUse} tiene {Units} unidades actualmente"
            };
        }

        private void AddUnitsTXT_TextChanged(object sender, EventArgs e) => TestAddUnits();
        private bool TestAddUnits() => TestTextToINT(ref AddUnitsTXT);
        private void AddUnitsBTN_Click(object sender, EventArgs e)
        {
            if (TestAddUnits()) UpdateUnits(int.Parse(AddUnitsTXT.Text));
        }

        private void SubUnitsTXT_TextChanged(object sender, EventArgs e) => TestSubUnits();
        private bool TestSubUnits() => TestTextToINT(ref SubUnitsTXT);
        private void SubUnitsBTN_Click(object sender, EventArgs e)
        {
            if (TestSubUnits()) UpdateUnits(-int.Parse(SubUnitsTXT.Text));
        }

        private void UpdateUnits(int amount)
        {
            Units += amount;

            DataBaseManager.ExecuteNonQuery($"Update {TableName} set {Elements_Properties.Units} = {Units} where {Elements_Properties.ID} = {ID}");

            Main.UpdateDatabaseBasedOnElectronicTypesCMBOX();
            Main.UpdateElectronicsCMBOX();
            UpdateCurrentElectronic();
        }

    }
}
