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
using static Integradora.Products.Manager.Products_Manager;
using static Integradora.Program;

namespace Integradora.Electronics.Inventory
{
    public partial class Electronics_Generic_ModifyName : Form
    {
        private Electronics_Inventory_Menu Main;
        private string TableName, NameToUse, SingularName;
        private int ID;
        private bool Male;

        public Electronics_Generic_ModifyName(Electronics_Inventory_Menu main, string tableName, string singularName, string name, int id, bool male)
        {
            InitializeComponent();
            SetVisibleCore(true);

            Main = main;
            TableName = tableName;
            NameToUse = name;
            SingularName = singularName;
            ID = id;
            Male = male;

            string article = Male switch
            {
                true => "el",
                false => "la"
            };
            OvrNameLBL.Text = $"Escriba el nuevo nombre para {article} {singularName}";

            UpdateCurrentElectronic();
        }
        private void UpdateCurrentElectronic()
        {
            string article = Male switch
            {
                true => "del",
                false => "de la"
            };

            CurrentElectronicLBL.Text = $"El nombre {article} {SingularName} es: {NameToUse}";
        }

        private void OvrNameTXT_TextChanged(object sender, EventArgs e) => TestTextToSTRING(ref OvrNameTXT);
        private void OvrNameBTN_Click(object sender, EventArgs e)
        {
            if (TestTextToSTRING(ref OvrNameTXT)) UpdateName(OvrNameTXT.Text);
            else throw new Exception();
        }

        private void UpdateName(string name)
        {
            NameToUse = name;

            DataBaseManager.ExecuteNonQuery($"update {TableName} set {Elements_Properties.Name} = '{NameToUse}' where {Elements_Properties.ID} = {ID}");

            Main.UpdateDatabaseBasedOnElectronicTypesCMBOX();
            Main.UpdateElectronicsCMBOX();
            UpdateCurrentElectronic();
        }
    }
}
