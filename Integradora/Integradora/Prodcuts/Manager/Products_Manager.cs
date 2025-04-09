using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;

using Integradora;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Collections.Specialized.BitVector32;

namespace Integradora.Products.Manager
{
    public static class Products_Manager
    {
        /// <summary>
        /// Used to avoid typos when using the table for SQLite
        /// </summary>
        private const string TableName = "Products";

        
        /// <summary>
        /// <b>These CAN NOT be used when displaying text, as it isn't translated</b>
        /// </summary>
        protected class Products_Properties
        {
            public const string Name = "Name", ID = "ID", Units = "Units", Sales = "Sales", Price = "Price";
        }

        /// <summary>
        /// The base class of each product, <b>Check later if I can make a base class for electronics aswell</b>
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">unique to each product</param>
        /// <param name="units"></param>
        /// <param name="sales">Total sales</param>
        public class Product(string name, int units = 0, int sales = 0, int id = 0, double price = 0.00)
        {
            /// <summary>
            /// <b>Should be in spanish</b>
            /// </summary>
            public string Name = name;
            /// <summary>
            /// Should be unique
            /// </summary>
            public int ID = id;
            public int Units = units;
            public int Sales = sales;
            public double Price = price;
            public override string ToString()
            {
                string text = $"Nombre: {Name}(ID: {ID}) \n";

                #region Units shenagigans
                if (Units == 1) text += $"{Units} unidad";
                else text += $"{Units} unidades";
                #endregion
                text += '\n';

                #region Sales shenagigans
                if (Sales == 1) text += $"{Sales} venta";
                else text += $"{Sales} ventas";
                #endregion
                text += '\n';

                #region Price shenagigans
                text += "Precio: ";

                if (Price == (int)Price) text += $"${Price}.00";
                else if (Price.ToString().Split('.', 2)[1].Length == 1) text += $"${Price}0";
                else text += $"${Price}";
                #endregion
                text += '\n';

                return text;
            } 

            /// <summary>
            /// Note that this returns all properties except for <see cref="ID"/>, since <see cref="ID"/> is meant to be auto_increment
            /// </summary>
            /// <returns></returns>
            public Dictionary<string, object> GetDataForInsert()
            {
                Dictionary<string, object> dict = [];

                dict.Add(Products_Properties.Name, Name);
                dict.Add(Products_Properties.Units, Units);
                dict.Add(Products_Properties.Sales, Sales);
                dict.Add(Products_Properties.Price, Price);

                return dict;
            }
        }

        public static List<Product> Products = [];

        public static void SetUpDataBase()
        {
            Products.Clear();

            string dbPath = DataBaseManager.DB_Path;

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            // 2025 Apr 08: Delete this when Product inventory is made better
            DataBaseManager.ExecuteNonQuery($"drop table {TableName}");

            using SQLiteConnection connection = new(DataBaseManager.ConnectionString);
            connection.Open();
            string createTableQuery = $"CREATE TABLE IF NOT EXISTS {TableName} (" +
                $"{Products_Properties.ID} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{Products_Properties.Name} varchar(100) not null," +
                $"{Products_Properties.Units} integer not null," +
                $"{Products_Properties.Sales} integer not null," +
                $"{Products_Properties.Price} decimal(10,2)" +
                ");";
            using SQLiteCommand command = new(createTableQuery, connection);
            command.ExecuteNonQuery();

            Product product = new("Papas a la belgica", sales: 1, price: 4);
            DataBaseManager.InsertInto(TableName, product.GetDataForInsert());
            product = new("Suizas Papas", units: 1, price: 3.99);
            DataBaseManager.InsertInto(TableName, product.GetDataForInsert());
            product = new("Franco-Papa", sales: 2, price: 1.9);
            DataBaseManager.InsertInto(TableName, product.GetDataForInsert());

            UpdateDataBase();
        }


        public static void UpdateDataBase()
        {
            if (!File.Exists(DataBaseManager.DB_Path)) throw new Exception();

            List<Dictionary<string, object>> products = DataBaseManager.SelectFrom(TableName, "*");
            foreach(Dictionary<string, object> product in products)
            {
                long? ID = null, Units = null, Sales = null;
                decimal? Price = null;
                string? Name = null;
                foreach (var ele in product)
                {
                    switch (ele.Key)
                    {
                        case Products_Properties.Name: Name = ele.Value.ToString(); break;
                        case Products_Properties.ID: ID = (long)ele.Value; break;
                        case Products_Properties.Units: Units = (long)ele.Value; break;
                        case Products_Properties.Sales: Sales = (long)ele.Value; break;
                        case Products_Properties.Price: Price = (decimal)ele.Value; break;
                        default: throw new Exception($"{ele.Key} has no entry in this switch \nwhich is bad by the way");
                    }

                    if (ID != null && Name != null && Units != null && Sales != null && Price != null)
                        Products.Add(new(Name, (int)Units, (int)Sales, (int)ID, (double)Price));
                }
            }

        }
    }
}
