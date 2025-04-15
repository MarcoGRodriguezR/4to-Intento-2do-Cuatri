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
using static Integradora.Electronics.Manager.Electronics_Capacitor_Manager;
using static Integradora.Program;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Capacitor_ModifyCapacitance : Form
    {
        private Electronics_Inventory_Menu Main;
        private Capacitor Capacitor;

        public Electronics_Capacitor_ModifyCapacitance(Electronics_Inventory_Menu main, Capacitor capacitor)
        {
            InitializeComponent();

            Main = main;
            Capacitor = capacitor;

            UpdateCurrentElectronic();

            SetVisibleCore(true);
        }
        private void UpdateCurrentElectronic()
        {
            if (Capacitor is null) return;

            CurrentElectronicLBL.Text = $"La capacitancia de {Capacitor.Name} es: {Capacitor.Capacitance}";
        }

        private void OverrideTXT_TextChanged(object sender, EventArgs e) => TestText();
        private bool TestText() => TestTextToDECIMAL(ref OverrideTXT);
        private void OverrideBTN_Click(object sender, EventArgs e)
        {
            if (TestText()) UpdateCapacitance(decimal.Parse(OverrideTXT.Text));
        }

        private void UpdateCapacitance(decimal value)
        {
            Capacitor.Capacitance.Value = value;

            DataBaseManager.ExecuteNonQuery($"Update {TableNames.Electronics.Capacitors} set {Capacitor_Properties.Capacitance} = {Capacitor.Capacitance.Value} where {Elements_Properties.ID} = {Capacitor.ID}");

            Main.UpdateDatabaseBasedOnElectronicTypesCMBOX();
            Main.UpdateElectronicsCMBOX();
            UpdateCurrentElectronic();
        }

    }
}
