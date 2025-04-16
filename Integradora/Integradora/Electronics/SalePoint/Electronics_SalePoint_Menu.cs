using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using static Integrator.Program;
using static Integrator._Generics.Manager.Generics_Manager;
using static Integrator.Electronics.Manager.Electronics_Resistance_Manager;
using static Integrator.Electronics.Manager.Electronics_Capacitor_Manager;

namespace Integrator.Electronics.SalePoint
{
    public partial class Electronics_SalePoint_Menu : Form
    {
        protected readonly string[] TableNames = [Program.TableNames.Electronics.Resistances, Program.TableNames.Electronics.Capacitors],
            PluralNames = ["Resistencias", "Capacitores"],
            SingularNames = ["Resistencia", "Capacitor"],
            GenderArticles = ["La", "El"];
        protected readonly bool[]
            GenderBools = [false, true];

        private List<Element> Elements = [], Selecteds = [];

        public Electronics_SalePoint_Menu()
        {
            InitializeComponent();

            foreach (string name in PluralNames) SectionsCOMBOX.Items.Add(name);
            SectionsCOMBOX.SelectedItem = SectionsCOMBOX.Items[0];

            UpdateCOMBOX();

            SetVisibleCore(true);
        }
        private void UpdateCOMBOX()
        {
            Elements.Clear(); ElementsCOMBOX.Items.Clear();
            switch (SectionsCOMBOX.SelectedIndex)
            {
                case 0: foreach (Resistance resistance in _Resistance_Manager.Resistances) Elements.Add(Element.Parse(resistance)); break;
                case 1: foreach (Capacitor capacitor in _Capacitor_Manager.Capacitors) Elements.Add(Element.Parse(capacitor)); break;
                default: throw new Exception($"P{SectionsCOMBOX.SelectedIndex} could not be found");
            }
            foreach (Element element in Elements) ElementsCOMBOX.Items.Add(element.OneLinerToString());
            ElementsCOMBOX.SelectedItem = ElementsCOMBOX.Items[0];
        }

        private void SectionsCOMBOX_SelectedIndexChanged(object sender, EventArgs e) => UpdateCOMBOX();
    }
}
