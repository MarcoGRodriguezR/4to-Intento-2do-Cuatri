using Integradora.Products.Inventory;
using Integradora.Electronics.Inventory;

namespace Integradora
{
    /// <summary>
    /// The Main Menu, but Master Mind sounds cooler
    /// </summary>
    public partial class MasterMind : Form
    {
        #region Section Shenanigans
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
        #endregion

        #region Loading Shenanigans
        private LoadingScreenBecauseWeDefinitelyNeedThat LoadingScreen;

        private System.Windows.Forms.Timer updateTimer = new();
        private void InitializeUpdateTimer()
        {
            updateTimer.Interval = 1; // interval in milliseconds (e.g., 100ms = 10 times/sec)

            updateTimer.Tick += LoadingScreen.UpdateMethod;
            updateTimer.Start();
        }
        #endregion
        public MasterMind()
        {
            InitializeComponent();
            SetVisibleCore(true);
            LoadingScreen = new(this);
            InitializeUpdateTimer();

            ElectronicsBTN.Enabled = false;
            ErrorBTN.Enabled = false;
            ProductsBTN.Enabled = false;

            InventoryBTN.Enabled = false;
        }
        public void AllClear()
        {
            UpdateWhichButtonIsSelected();

            ElectronicsBTN.Enabled = true;
            ErrorBTN.Enabled = true;
            ProductsBTN.Enabled = true;

            InventoryBTN.Enabled = true;

            updateTimer.Stop();
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

        private void InventoryBTN_Click(object sender, EventArgs e)
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
