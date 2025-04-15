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
using static Integradora.Electronics.Manager.Electronics_Capacitor_Manager;
using static Integradora._Generics.Manager.Generics_Manager;
using static Integradora.Program;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Inventory_Menu : Form
    {

        protected readonly string[] TableNames = [Program.TableNames.Electronics.Resistances, Program.TableNames.Electronics.Capacitors],
            PluralNames = ["Resistencias", "Capacitores"],
            SingularNames = ["Resistencia", "Capacitor"],
            GenderArticles = ["La", "El"];
        protected readonly bool[]
            GenderBools = [false, true];
        /// <summary>
        /// Hard coded value to multiply with <see cref="string.Length"/> to resize <see cref="Button"/> to fit text
        /// </summary>
        private int MultiplierForWidth = 12;

        public Electronics_Inventory_Menu()
        {
            InitializeComponent();

            ElectronicTypesCMBOX.Items.Clear();
            foreach (string Section in PluralNames) ElectronicTypesCMBOX.Items.Add(Section);
            ElectronicTypesCMBOX.SelectedItem = ElectronicTypesCMBOX.Items[0];

            UpdateElectronicsCMBOX();

            ResizeButtonsBasedOnModPropertiesBTN();

            SetVisibleCore(true);
        }
        private int FindWhatIndexToChooseBasedOnElectronicTypesCMBOX()
        {
            for (int i = 0; i < PluralNames.Length; i++)
            {
                if (PluralNames[i] == ElectronicTypesCMBOX.Text) return i;
            }
            throw new Exception("Error finding number");
        }
        public void UpdateDatabaseBasedOnElectronicTypesCMBOX()
        {
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX();
            switch (index)
            {
                case 0: _Resistance_Manager.UpdateDataBase(); break;
                case 1: _Capacitor_Manager.UpdateDataBase(); break;
                default: throw new Exception($"{index} could not be found");
            }
        }
        private void ResizeButtonsBasedOnModPropertiesBTN()
        {
            ModUnitsBTN.Width = ModPriceBTN.Width = ModNameBTN.Width = ModPropertiesBTN.Width = ModPropertiesBTN.Text.Length * MultiplierForWidth;
        }


        public void UpdateElectronicsCMBOX()
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
            int selectedIndex = ElectronicTypesCMBOX.SelectedIndex;

            ElectronicsLBL.Text = SingularNames[selectedIndex];
            ElectronicsCMBOX.Left = ElectronicsLBL.Left + ElectronicsLBL.Width + 4;

            #region Add and Remove
            AddElectronicBTN.Text = $"Agregar {SingularNames[selectedIndex]}";
            AddElectronicBTN.Width = AddElectronicBTN.Text.Length * MultiplierForWidth;

            RemElectronicBTN.Text = $"Eliminar {SingularNames[selectedIndex]}";
            RemElectronicBTN.Width = RemElectronicBTN.Text.Length * MultiplierForWidth;
            RemElectronicBTN.Left = AddElectronicBTN.Left + AddElectronicBTN.Width + 4;
            #endregion

            #region The Modify Buttons
            ModPropertiesBTN.Text = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX() switch
            {
                0 => "Modificar Resistencia",
                1 => "Modificar Capacitancia",
                _ => "Modificar Propiedades"
            };

            ResizeButtonsBasedOnModPropertiesBTN();
            #endregion

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
                _ => $"Error al intentar acceder {GenderArticles[index]} {SingularNames[index]} {selectedIndex}"
            };
        }

        #region _Click Functions

        #region Add and Remove
        private void AddElectronicBTN_Click(object sender, EventArgs e)
        {

            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX();
            switch (index)
            {
                case 0: _ = new Electronics_Resistance_AddElement(this); break;
                case 1: _ = new Electronics_Capacitor_AddElement(this); break;
                default: throw new Exception($"{index} has no entry in this switch");
            }
        }

        private void RemElectronicBTN_Click(object sender, EventArgs e)
        {
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX();
            List<string> names = []; List<int> ids = [];
            switch (index)
            {
                case 0:
                    foreach (Resistance resistance in _Resistance_Manager.Resistances)
                    {
                        names.Add(resistance.Name);
                        ids.Add(resistance.ID);
                    }
                    break;
                case 1:
                    foreach (Capacitor capacitor in _Capacitor_Manager.Capacitors)
                    {
                        names.Add(capacitor.Name);
                        ids.Add(capacitor.ID);
                    }

                    break;
                default: throw new Exception($"{index} could not be found");
            }

            _ = new Electronics_Generic_RemElement(this, TableNames[index], SingularNames[index], PluralNames[index], GenderBools[index], names, ids);
        }
        #endregion

        #region Modify buttons
        private void ModUnitsBTN_Click(object sender, EventArgs e)
        {
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX(), selectedIndex = ElectronicsCMBOX.SelectedIndex;
            string name;
            int units, id;

            switch (index)
            {
                case 0:
                    name = _Resistance_Manager.Resistances[selectedIndex].Name;
                    units = _Resistance_Manager.Resistances[selectedIndex].Units;
                    id = _Resistance_Manager.Resistances[selectedIndex].ID;
                    break;
                case 1:
                    name = _Capacitor_Manager.Capacitors[selectedIndex].Name;
                    units = _Capacitor_Manager.Capacitors[selectedIndex].Units;
                    id = _Capacitor_Manager.Capacitors[selectedIndex].ID;
                    break;
                default: throw new Exception($"{index} could not be found");
            }

            _ = new Electronics_Generic_ModifyUnits(this, TableNames[index], name, units, id);
        }

        private void ModPriceBTN_Click(object sender, EventArgs e)
        {
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX(), selectedIndex = ElectronicsCMBOX.SelectedIndex;
            string name;
            int id;
            double price;

            switch (index)
            {
                case 0:
                    name = _Resistance_Manager.Resistances[selectedIndex].Name;
                    price = _Resistance_Manager.Resistances[selectedIndex].Price.ActualNumberInsteadOfString;
                    id = _Resistance_Manager.Resistances[selectedIndex].ID;
                    break;
                case 1:
                    name = _Capacitor_Manager.Capacitors[selectedIndex].Name;
                    price = _Capacitor_Manager.Capacitors[selectedIndex].Price.ActualNumberInsteadOfString;
                    id = _Capacitor_Manager.Capacitors[selectedIndex].ID;
                    break;
                default: throw new Exception($"{index} could not be found");
            }

            _ = new Electronics_Generic_ModifyPrice(this, TableNames[index], name, price, id);
        }

        private void ModNameBTN_Click(object sender, EventArgs e)
        {
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX(), selectedIndex = ElectronicsCMBOX.SelectedIndex;
            string name;
            int id;

            switch (index)
            {
                case 0:
                    name = _Resistance_Manager.Resistances[selectedIndex].Name;
                    id = _Resistance_Manager.Resistances[selectedIndex].ID;
                    break;
                case 1:
                    name = _Capacitor_Manager.Capacitors[selectedIndex].Name;
                    id = _Capacitor_Manager.Capacitors[selectedIndex].ID;
                    break;
                default: throw new Exception($"{index} could not be found");
            }


            _ = new Electronics_Generic_ModifyName(this, TableNames[index], SingularNames[index], name, id, GenderBools[index]);
        }

        private void ModPropertiesBTN_Click(object sender, EventArgs e)
        {
            int index = FindWhatIndexToChooseBasedOnElectronicTypesCMBOX(), selectedIndex = ElectronicsCMBOX.SelectedIndex;

            switch (index)
            {
                case 0: _ = new Electronics_Resistance_ModifyResistance(this, _Resistance_Manager.Resistances[selectedIndex]); break;
                case 1: _ = new Electronics_Capacitor_ModifyCapacitance(this, _Capacitor_Manager.Capacitors[selectedIndex]); break;
                default: throw new Exception($"{index} could not be found");
            }
        }
        #endregion

        #endregion
    }
}
