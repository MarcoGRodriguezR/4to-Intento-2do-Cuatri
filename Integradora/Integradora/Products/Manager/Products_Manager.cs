using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;
using static System.Net.Mime.MediaTypeNames;
using Integradora._Generics.Manager;

using static Integradora.Program;

namespace Integradora.Products.Manager
{
    public class Products_Manager : Generics_Manager
    {
        public sealed override string TableName => TableNames.Products;

        public override void DealWithZeElements(Dictionary<string, object> properties)
        {
            long? ID = null, Units = null, Sales = null;
            decimal? Price = null;
            string? Name = null;
            foreach (var ele in properties)
            {
                switch (ele.Key)
                {
                    case Elements_Properties.Name: Name = ele.Value.ToString(); break;
                    case Elements_Properties.ID: ID = (long)ele.Value; break;
                    case Elements_Properties.Units: Units = (long)ele.Value; break;
                    case Elements_Properties.Sales: Sales = (long)ele.Value; break;
                    case Elements_Properties.Price: Price = (decimal)ele.Value; break;
                    default: throw new Exception($"{ele.Key} has no entry in this switch \nwhich is bad by the way");
                }

                if (ID != null && Name != null && Units != null && Sales != null && Price != null)
                    Products.Add(new(Name, (int)Units, (int)Sales, (int)ID, (double)Price));
            }
        }

        public List<Product> Products = [];
        public class Product(string name, int units = 0, int sales = 0, int id = 0, double price = 0) : Element(name, units, sales, id, price)
        {

        }

        protected override void ClearElementsList() => Products.Clear();

    }
}
