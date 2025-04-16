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
using static Integrator.Products.Manager.Products_Manager;

namespace Integrator.Products.SalePoint
{
    public partial class Products_SalePoint_Menu : Form
    {
        private List<Element> Elements = [], Selecteds = [];

        public Products_SalePoint_Menu()
        {
            InitializeComponent();

            UpdateCOMBOX();

            CreateTableOnceAgain();
            int widthToSet = MainTable.Width;

            ElementsCOMBOX.Width = widthToSet;
            PayUpBTN.Left = ResetTableBTN.Left = AddElementBTN.Left = ElementsCOMBOX.Left + ElementsCOMBOX.Width + 4;

            UpdatePriceLBL();

            SetVisibleCore(true);
        }
        private void UpdateCOMBOX()
        {
            Elements.Clear(); ElementsCOMBOX.Items.Clear();
            foreach (Product product in _Products_Manager.Products) Elements.Add(Element.Parse(product));
            foreach (Element element in Elements) ElementsCOMBOX.Items.Add(element.OneLinerToString());
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

        /// <summary>
        /// Note that I'm reusing the <see cref="Element"/> class, using the <see cref="Element.Units"/> property as a "Units to sell"
        /// </summary>
        /// <param name="element"></param>
        private void AddElementToTable(Element element)
        {
            if (element.Units <= 0) return;

            int alreadyExistsIndex = -1;
            for (int i = 0; i < Selecteds.Count; i++)
            {
                if (Selecteds[i].ID == element.ID) alreadyExistsIndex = i;
            }

            string[] labels = new string[3];

            if (alreadyExistsIndex == -1)
            {
                Selecteds.Add(new Element(element.Name, 1, 0, element.ID, element.Price.ActualNumberInsteadOfString));

                labels[0] = "1";
                labels[1] = $"{element.Name}";
                labels[2] = $"{element.Price}";

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

                labelButNotReally = MainTable.GetControlFromPosition(2, alreadyExistsIndex + 1);
                if (labelButNotReally is not null) labelButNotReally.Text = $"{priceTimesUnits}";
            }

            UpdatePriceLBL();
            UpdateHeight();
        }
        private void CreateTableOnceAgain()
        {
            MainTable.SuspendLayout();

            #region Deleting

            MainTable.Controls.Clear();
            MainTable.RowStyles.Clear();
            MainTable.ColumnStyles.Clear();

            MainTable.RowCount = 1;
            MainTable.ColumnCount = 3;

            #endregion

            #region Actual creating
            string[] TopLabels = ["N°", "Nombre", "Precio"];
            int[] extraSpace = [5, 5, -2];
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

        private void AddElementBTN_Click(object sender, EventArgs e) => AddElementToTable(Elements[ElementsCOMBOX.SelectedIndex]);
        private void RestartTableBTN_Click(object sender, EventArgs e) => ResetTable();
        private void PayUpBTN_Click(object sender, EventArgs e)
        {
            foreach (Element selected in Selecteds)
            {
                Element tempElement = FindFirstBasedOnID(selected.ID);
                if (tempElement is null || selected is null) continue;
                if (tempElement.ID <= 0) continue;

                DataBaseManager.ExecuteNonQuery($"update {TableNames.Products} set {Elements_Properties.Units} = {tempElement.Units - selected.Units} where {Elements_Properties.ID} = {selected.ID}");
                DataBaseManager.ExecuteNonQuery($"update {TableNames.Products} set {Elements_Properties.Sales} = {tempElement.Sales + selected.Units} where {Elements_Properties.ID} = {selected.ID}");
            }

            _Products_Manager.UpdateDataBase();

            ResetTable();
            CreateTableOnceAgain();

        }

        private static Element FindFirstBasedOnID(int id)
        {
            foreach (Element element in _Products_Manager.Products) if (element.ID == id) return element;
            return null;
        }
    }
}
