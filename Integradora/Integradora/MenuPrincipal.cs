using Integradora.Products.Inventory;
using Integradora.Electronics.Inventory;

namespace Integradora
{
    public partial class MasterMind : Form
    {
        /// <summary>
        /// Used to know what section we are using currently
        /// </summary>
        private Sections SectionActual;
        private enum Sections
        {
            Products,
            Electronics,
            Error,
        }
        /// <summary>
        /// This is to disable the button of the current section and enable all others for ease of use, <b>Change the value of <see cref="SectionActual"/> before calling this method</b>
        /// </summary>
        private void UpdateWhichButtonIsSelected()
        {
            ProductsBTN.Enabled = SectionActual != Sections.Products;
            ElectronicsBTN.Enabled = SectionActual != Sections.Electronics;
            ErrorBTN.Enabled = SectionActual != Sections.Error;
        }

        public MasterMind()
        {
            InitializeComponent();
            UpdateWhichButtonIsSelected();
        }

        #region _Click Functions

        #region Sections
        private void ProductsBTN_Click(object sender, EventArgs e)
        {
            SectionActual = Sections.Products;
            UpdateWhichButtonIsSelected();
        }

        private void ElectronicsBTN_Click(object sender, EventArgs e)
        {
            SectionActual = Sections.Electronics;
            UpdateWhichButtonIsSelected();
        }

        private void Error_Click(object sender, EventArgs e)
        {
            SectionActual = Sections.Error;
            UpdateWhichButtonIsSelected();
        }
        #endregion

        private void Inventory_Click(object sender, EventArgs e)
        {
            object menu;

            switch(SectionActual)
            {
                case Sections.Products:
                    menu = new Products_Inventory_Menu();
                    break;
                case Sections.Electronics:
                    menu = new Electronics_Inventory_Menu();
                    break;
                default:
                    throw new Exception($"{SectionActual} has no entry for this switch");
            }
        }
        #endregion

    }
}
