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
using static Integradora.Electronics.Manager.Electronics_Resistance_Manager;
using System.Drawing.Text;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Resistance_ModifyResistance : Form
    {
        private Electronics_Inventory_Menu Main;
        private Resistance Resistance;

        public Electronics_Resistance_ModifyResistance(Electronics_Inventory_Menu main, Resistance resistance)
        {
            InitializeComponent();

            Main = main;
            Resistance = resistance;

            UpdateCurrentElectronic();


            SetVisibleCore(true);
        }
        private void UpdateCurrentElectronic()
        {
            if (Resistance is null) return;

            CurrentElectronicLBL.Text = $"La resistencia de {Resistance.Name} es: {Resistance.ResistanceValue}";
        }

        private void OvrResistanceTXT_TextChanged(object sender, EventArgs e) => TestText();
        private bool TestText() => TestTextToDECIMAL(ref OvrResistanceTXT);

        private void OvrResistanceBTN_Click(object sender, EventArgs e)
        {
            if (TestText()) UpdateResistance(decimal.Parse(OvrResistanceTXT.Text));
        }

        private void UpdateResistance(decimal value)
        {
            Resistance.ResistanceValue.Value = value;

            DataBaseManager.ExecuteNonQuery($"Update {TableNames.Electronics.Resistances} set {Resistance_Properties.Resistance} = {Resistance.ResistanceValue.Value} where {Elements_Properties.ID} = {Resistance.ID}");
            
            Main.UpdateDatabaseBasedOnElectronicTypesCMBOX();
            Main.UpdateElectronicsCMBOX();
            UpdateCurrentElectronic();
        }
    }
}
