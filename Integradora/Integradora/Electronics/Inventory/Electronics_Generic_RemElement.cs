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
using static Integrator.Products.Manager.Products_Manager;
using static Integrator._Generics.Manager.Generics_Manager;

namespace Integrator.Electronics.Inventory
{
    public partial class Electronics_Generic_RemElement : Form
    {
        private Electronics_Inventory_Menu Main;
        private List<string> Names;
        private List<int> IDs;
        private string PluralName, SingularName, TableName;
        private bool Male;

        public Electronics_Generic_RemElement(Electronics_Inventory_Menu main, string tableName, string singularName, string pluralName, bool male, List<string> names, List<int> iDs)
        {
            InitializeComponent();
            SetVisibleCore(true);

            Main = main;
            Names = names;
            IDs = iDs;
            PluralName = pluralName;
            SingularName = singularName;
            Male = male;
            TableName = tableName;

            string article = male switch
            {
                true => "un",
                false => "una"
            };
            StatusLBL.Text = $"Eliga {article} {singularName} para eliminar";
            UpdateCOMBOX();

        }
        private void UpdateCOMBOX()
        {
            ElectronicsCOMBOX.Items.Clear();
            foreach (string name in Names) ElectronicsCOMBOX.Items.Add(name);
            if (ElectronicsCOMBOX.Items.Count > 0) ElectronicsCOMBOX.SelectedItem = ElectronicsCOMBOX.Items[0];
        }

        private void RemoveElectronicBTN_Click(object sender, EventArgs e)
        {

            if (ElectronicsCOMBOX.Items.Count <= 0 || ElectronicsCOMBOX.Items is null)
            {
                StatusLBL.Text = $"No hay {PluralName.ToLower()} para eliminar";
                return;
            }

            try
            {
                int index = ElectronicsCOMBOX.SelectedIndex;

                DataBaseManager.ExecuteNonQuery($"delete from {TableName} where ID = {IDs[index]}");
                Names.RemoveAt(index); IDs.RemoveAt(index);

                Main.UpdateDatabaseBasedOnElectronicTypesCMBOX();
                Main.UpdateElectronicsCMBOX();
                UpdateCOMBOX();

                string article = Male switch
                {
                    true => "el",
                    false => "la"
                };

                StatusLBL.Text = $"Se ha eliminado {article} {SingularName.ToLower()} exitosamente";
            }
            catch (Exception exception)
            {
                StatusLBL.Text = "Hubo un error";
                Console.WriteLine(exception);
            }
        }
    }
}
