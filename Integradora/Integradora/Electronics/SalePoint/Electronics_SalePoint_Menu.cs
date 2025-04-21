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
        protected static readonly string[] TableNames = [Program.TableNames.Electronics.Resistances, Program.TableNames.Electronics.Capacitors],
            PluralNames = ["Resistencias", "Capacitores"],
            SingularNames = ["Resistencia", "Capacitor"],
            GenderArticles = ["La", "El"];
        protected static readonly bool[]
            GenderBools = [false, true];

        private List<SaleElement> Elements = [], Selecteds = [];
        private class SaleElement(string section, string pluralName, string name, int units = 0, int sales = 0, int id = 0, double price = 0) : Element(name, units, sales, id, price)
        {
            public string Section = section;

            /// <summary>
            /// The plural name in spanish
            /// </summary>
            public string PluralName = pluralName;

            public static new SaleElement Parse(Resistance resistance) => new(Program.TableNames.Electronics.Resistances, PluralNames[0], resistance.Name, resistance.Units, 0, resistance.ID, resistance.Price.ActualNumberInsteadOfString);
            public static new SaleElement Parse(Capacitor capacitor) => new(Program.TableNames.Electronics.Capacitors, PluralNames[1], capacitor.Name, capacitor.Units, 0, capacitor.ID, capacitor.Price.ActualNumberInsteadOfString);
        }


        public Electronics_SalePoint_Menu()
        {
            InitializeComponent();

            foreach (string name in PluralNames) SectionsCOMBOX.Items.Add(name);
            SectionsCOMBOX.SelectedItem = SectionsCOMBOX.Items[0];
            UpdateCOMBOX();

            CreateTableOnceAgain();
            int widthToSet = MainTable.Width;

            SectionsCOMBOX.Width = ElementsCOMBOX.Width = widthToSet;

            PayUpBTN.Left = ResetTableBTN.Left = AddElementBTN.Left = ElementsCOMBOX.Left + ElementsCOMBOX.Width + 4;

            UpdateHeight();
            UpdatePriceLBL();

            SetVisibleCore(true);
        }
        private void UpdateCOMBOX()
        {
            Elements.Clear(); ElementsCOMBOX.Items.Clear();
            switch (SectionsCOMBOX.SelectedIndex)
            {
                case 0: foreach (Resistance resistance in _Resistance_Manager.Resistances) Elements.Add(SaleElement.Parse(resistance)); break;
                case 1: foreach (Capacitor capacitor in _Capacitor_Manager.Capacitors) Elements.Add(SaleElement.Parse(capacitor)); break;
                default: throw new Exception($"P{SectionsCOMBOX.SelectedIndex} could not be found");
            }
            foreach (SaleElement element in Elements) ElementsCOMBOX.Items.Add(element.OneLinerToString());
            ElementsCOMBOX.SelectedItem = ElementsCOMBOX.Items[0];
        }
        private void UpdateHeight() => MainTable.Height = MainTable.RowCount * 30;
        private void UpdatePriceLBL()
        {
            double priceReal = 0;

            foreach (Element spiderman in Selecteds)
            {
                priceReal += spiderman.Units * spiderman.Price.ActualNumberInsteadOfString;
            }

            Element.PriceHelper pizzaTime = new(priceReal);

            ActualTotalPriceLBL.Text = pizzaTime.ToString();
            ActualTotalPriceLBL.Width = (int)(ActualTotalPriceLBL.Text.Length * ActualTotalPriceLBL.Font.Size);

            ActualTotalPriceLBL.Left = ElementsCOMBOX.Left + ElementsCOMBOX.Width - ActualTotalPriceLBL.Width;

        }

        private void CreateTableOnceAgain()
        {
            MainTable.SuspendLayout();

            #region Deleting

            MainTable.Controls.Clear();
            MainTable.RowStyles.Clear();
            MainTable.ColumnStyles.Clear();

            MainTable.RowCount = 1;
            MainTable.ColumnCount = 4;

            #endregion

            #region Actual creating
            string[] TopLabels = ["N°", "Sección", "Nombre", "Precio"];
            int[] extraSpace = [3, 3, 4, -2];
            int widthToSet = 0;
            for (int i = 0; i < TopLabels.Length; i++)
            {
                Label label = new()
                {
                    Font = new("Segoe UI", 16f),
                    Text = TopLabels[i],
                    Height = 30
                };

                MainTable.Controls.Add(label, i, 0);
                try
                {
                    MainTable.ColumnStyles[i].SizeType = SizeType.Absolute;
                }
                catch
                {
                    MainTable.ColumnStyles.Add(new(SizeType.Absolute));
                }

                // 5 extra seems to be a good numbre
                int TextSize = (label.Text.Length + extraSpace[i]) * 24;
                MainTable.ColumnStyles[i].Width = TextSize;
                widthToSet += TextSize;
            }

            try
            {
                MainTable.RowStyles[0].SizeType = SizeType.Absolute;
            }
            catch
            {
                MainTable.RowStyles.Add(new(SizeType.Absolute));
            }
            MainTable.RowStyles[0].Height = 30;

            MainTable.Width = widthToSet;
            #endregion

            MainTable.ResumeLayout();
        }
        private void ResetTable()
        {
            Selecteds.Clear();

            UpdatePriceLBL();
            CreateTableOnceAgain();
            UpdateCOMBOX();
        }

        /// <summary>
        /// Note that I'm reusing the <see cref="Element"/> class, using the <see cref="Element.Units"/> property as a "Units to sell"
        /// </summary>
        /// <param name="element"></param>
        private void AddElementToTable(SaleElement element)
        {
            if (element.Units <= 0) return;

            int alreadyExistsIndex = -1;
            for (int i = 0; i < Selecteds.Count; i++)
            {
                if (Selecteds[i].ID == element.ID && Selecteds[i].Section == element.Section) alreadyExistsIndex = i;
            }

            string[] labels = new string[4];

            if (alreadyExistsIndex == -1)
            {
                Selecteds.Add(new SaleElement(element.Section, element.PluralName, element.Name, 1, 0, element.ID, element.Price.ActualNumberInsteadOfString));

                labels[0] = "1";
                labels[1] = element.PluralName;
                labels[2] = element.Name;
                labels[3] = $"{element.Price}";

                MainTable.RowCount++;
                for (int i = 0; i < labels.Length; i++)
                {
                    Label tempLabel = new()
                    {
                        Font = new("Segoe UI", 12),
                        Text = labels[i],
                        Height = 30,
                        Width = Text.Length * (int)Font.Size
                    };

                    MainTable.Controls.Add(tempLabel, i, Selecteds.Count);
                }
            }
            else
            {
                if (Selecteds[alreadyExistsIndex].Units < element.Units) Selecteds[alreadyExistsIndex].Units++;

                var labelButNotReally = MainTable.GetControlFromPosition(0, alreadyExistsIndex + 1);
                if (labelButNotReally is not null) labelButNotReally.Text = $"{Selecteds[alreadyExistsIndex].Units}";

                Element.PriceHelper priceTimesUnits = new(Selecteds[alreadyExistsIndex].Price.ActualNumberInsteadOfString * Selecteds[alreadyExistsIndex].Units);

                labelButNotReally = MainTable.GetControlFromPosition(3, alreadyExistsIndex + 1);
                if (labelButNotReally is not null) labelButNotReally.Text = $"{priceTimesUnits}";
            }

            UpdatePriceLBL();
            UpdateHeight();
        }

        #region Index Changed
        private void SectionsCOMBOX_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = SectionsCOMBOX.SelectedIndex;

            AddElementBTN.Text = $"Agregar {SingularNames[index]}";

            UpdateCOMBOX();

        }
        #endregion

        #region Click
        private void AddElementBTN_Click(object sender, EventArgs e) => AddElementToTable(Elements[ElementsCOMBOX.SelectedIndex]);
        private void ResetTableBTN_Click(object sender, EventArgs e) => ResetTable();
        private void PayUpBTN_Click(object sender, EventArgs e)
        {
            foreach (SaleElement selected in Selecteds)
            {
                SaleElement? tempElement = FindFirstBasedOnID(selected.ID, selected.Section);
                if (tempElement is null || selected is null) continue;
                if (tempElement.ID <= 0) continue; // 2025 Apr 17: assuming it sent an empty saleelement, the id should be 0

                DataBaseManager.ExecuteNonQuery($"update {tempElement.Section} set {Elements_Properties.Units} = {tempElement.Units - selected.Units} where {Elements_Properties.ID} = {selected.ID}");
                DataBaseManager.ExecuteNonQuery($"update {tempElement.Section} set {Elements_Properties.Sales} = {tempElement.Sales + selected.Units} where {Elements_Properties.ID} = {selected.ID}");
            }

            _Resistance_Manager.UpdateDataBase();
            _Capacitor_Manager.UpdateDataBase();

            ResetTable();
            CreateTableOnceAgain();
        }
        private SaleElement? FindFirstBasedOnID(int id, string section)
        {
            List<SaleElement> elements = []; // 2025 Apr 17: While with parsing, their special values will be lost, they aren't going to be used anyway

            switch (section)
            {
                case Program.TableNames.Electronics.Resistances:
                    foreach (Resistance res in _Resistance_Manager.Resistances) elements.Add(SaleElement.Parse(res));
                    break;
                case Program.TableNames.Electronics.Capacitors:
                    foreach (Capacitor cap in _Capacitor_Manager.Capacitors) elements.Add(SaleElement.Parse(cap));
                    break;
                default: throw new Exception($"{section} could not be found");
            }

            foreach (SaleElement element in elements) if (element.ID == id) return element;
            return null;
        }
        #endregion


    }
}
