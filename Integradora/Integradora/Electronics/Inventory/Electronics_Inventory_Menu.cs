using Integradora.Electronics.Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Integradora.Electronics.Manager.Electronics_Resistance_Manager;
using static Integradora.Products.Manager.Products_Manager;
using static Integradora._Generics.Manager.Generics_Manager;
using static Integradora.Program;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Inventory_Menu : Form
    {

        protected readonly string[] PluralNames = ["Resistencias", "Capacitores"],
            SingularNames = ["Resistencia", "Capacitor"],
            GenderNames = ["La", "El"];

        public Electronics_Inventory_Menu()
        {
            InitializeComponent();
            SetVisibleCore(true);

            _Resistance_Manager.SetUpDatabase();
            _Capacitor_Manager.SetUpDatabase();

            ElectronicTypesCMBOX.Items.Clear();
            foreach (string Section in PluralNames) ElectronicTypesCMBOX.Items.Add(Section);
            ElectronicTypesCMBOX.SelectedItem = ElectronicTypesCMBOX.Items[0];

            UpdateElectronicsCMBOX();
        }
        private int FindWhatIndexToChooseBasedOnElectronicTypesCMBOX()
        {
            for (int i = 0; i <  PluralNames.Length; i++)
            {
                if (PluralNames[i] == ElectronicTypesCMBOX.Text) return i;
            }
            throw new Exception("Error finding number");
        }

        private void UpdateElectronicsCMBOX()
        {
            ElectronicsCMBOX.Items.Clear();

            // 2025 Apr 13: Can't do this with a nice switch, if chain it is then
            //List<Element> elements = ElectronicTypeCMBOX.Text switch
            //{
            //    PluralNames[0] => [],
            //    _ => []
            //};
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX();

            List<Element> elements = [];
            switch (index)
            {
                case 0: elements.AddRange(_Resistance_Manager.Resistances); break;
                case 1: elements.AddRange(_Capacitor_Manager.Capacitors); break;
                default: throw new Exception($"{index} has no entry in this switch");
            }

            foreach (Element element in elements) ElectronicsCMBOX.Items.Add(element.Name);
            if (ElectronicsCMBOX.Items.Count > 0) ElectronicsCMBOX.SelectedItem = ElectronicsCMBOX.Items[0];
            else MainText.Text = $"No hay {PluralNames[ElectronicTypesCMBOX.SelectedIndex]}";


        }

        private void ElectronicTypeCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            ElectronicsLBL.Text = SingularNames[ElectronicTypesCMBOX.SelectedIndex];

            ElectronicsCMBOX.Left = ElectronicsLBL.Left + ElectronicsLBL.Width + 4;

            UpdateElectronicsCMBOX();
        }
        private void ElectronicsCMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Edge-Case guarding
            if (ElectronicsCMBOX.Items.Count <= 0 || ElectronicsCMBOX.SelectedIndex < 0) return;

            if (ElectronicsCMBOX.SelectedIndex >= ElectronicsCMBOX.Items.Count) ElectronicsCMBOX.SelectedItem = ElectronicsCMBOX.Items[0];
            #endregion

            //string? text = _Products_Manager.Products[ElectronicsCMBOX.SelectedIndex].ToString();
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX(), selectedIndex = ElectronicsCMBOX.SelectedIndex;
            MainText.Text = index switch
            {
                0 => _Resistance_Manager.Resistances[selectedIndex].ToString(),
                1 => _Capacitor_Manager.Capacitors[selectedIndex].ToString(),
                _ => $"Error al intentar acceder {GenderNames[index]} {SingularNames[index]} {selectedIndex}"
            };
        }
    }
}
