using Integrator.Electronics.Manager;
using Integrator.Products.Manager;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Integrator.Program;

using static Integrator.Products.Manager.Products_Manager;

using static Integrator.Electronics.Manager.Electronics_Resistance_Manager;
using static Integrator.Electronics.Manager.Electronics_Capacitor_Manager;

namespace Integrator._Generics.Manager
{
    /// <summary>
    /// Base class for Managers of data base thingies
    /// </summary>
    public abstract class Generics_Manager
    {
        /// <summary>
        /// Used to avoid typos when using the table for SQLite
        /// </summary>
        public abstract string TableName { get; }

        /// <summary>
        /// <b>These CAN NOT be used when displaying text, as it isn't translated</b>
        /// </summary>
        public class Elements_Properties
        {
            public const string Name = "Name", ID = "ID", Units = "Units", Sales = "Sales", Price = "Price";
        }

        #region Element thingies
        /// <summary>
        /// The base class of each element, will the be the base of products and electronics
        /// </summary>
        /// <param name="name"></param>
        /// <param name="id">unique to each product</param>
        /// <param name="units"></param>
        /// <param name="sales">Total sales</param>
        public class Element(string name, int units = 0, int sales = 0, int id = 0, double price = 0.00)
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
            #region Price
            public class PriceHelper(double price)
            {
                public double ActualNumberInsteadOfString = price;
                public override string ToString()
                {
                    string text = "";

                    if (ActualNumberInsteadOfString == (int)ActualNumberInsteadOfString) text += $"${ActualNumberInsteadOfString}.00";
                    else if (ActualNumberInsteadOfString.ToString().Split('.', 2)[1].Length == 1) text += $"${ActualNumberInsteadOfString}0";
                    else if (ActualNumberInsteadOfString.ToString().Split('.', 2)[1].Length > 2)
                    {
                        string theFirstHalf = ((int)ActualNumberInsteadOfString).ToString();
                        string theOtherHalf = ActualNumberInsteadOfString.ToString().Split('.', 2)[1];

                        text = $"${theFirstHalf}.{theOtherHalf[0]}{theOtherHalf[1]}";
                    }
                    else text += $"${ActualNumberInsteadOfString}";

                    return text;
                }
            } public PriceHelper Price = new(price);
            #endregion

            #region ScientificNotationHelper
            public class ScientificNotationHelper(decimal value, char symbol)
            {
                public decimal Value = value;
                public char Symbol = symbol;

                public override string ToString()
                {
                    #region Outside Values
                    int antiDecimal = (int)Value;
                    string prefix = "hmm";
                    decimal amount = Value;
                    int divideByHowMuch = 0;
                    #endregion

                    #region Positive prefixes
                    if (antiDecimal > 0)
                    {
                        string valueButText = antiDecimal.ToString();

                        switch (valueButText.Length)
                        {
                            default:
                                prefix = "Y";
                                divideByHowMuch = 24;
                                break;
                            case 24: case 23: case 22:
                                prefix = "Z";
                                divideByHowMuch = 21;
                                break;
                            case 21: case 20: case 19:
                                prefix = "E";
                                divideByHowMuch = 18;
                                break;
                            case 18: case 17: case 16:
                                prefix = "P";
                                divideByHowMuch = 15;
                                break;
                            case 15: case 14: case 13:
                                prefix = "T";
                                divideByHowMuch = 12;
                                break;
                            case 12: case 11: case 10:
                                prefix = "G";
                                divideByHowMuch = 9;
                                break;
                            case 9: case 8: case 7:
                                prefix = "M";
                                divideByHowMuch = 6;
                                break;
                            case 6: case 5: case 4:
                                prefix = "k";
                                divideByHowMuch = 3;
                                break;
                            case 3:
                                prefix = "h";
                                divideByHowMuch = 2;
                                break;
                            case 2:
                                prefix = "da";
                                divideByHowMuch = 1;
                                break;
                            case 1: case 0:
                                prefix = "";
                                divideByHowMuch = 0;
                                break;
                        }

                    }
                    #endregion

                    #region Negative Prefixes
                    else
                    {
                        string textBUTOBSELETE = Value.ToString();
                        string textBUTREAL = textBUTOBSELETE.Substring(textBUTOBSELETE.IndexOf('.') + 1);

                        int howManyCeroes = 1;
                        foreach (char c in textBUTREAL)
                        {
                            if (!char.IsDigit(c)) throw new Exception($"{c} is not a number");

                            if (c == '0') howManyCeroes++;
                            else if (char.IsDigit(c)) break;
                        }

                        switch (howManyCeroes)
                        {
                            case <= 1:
                                prefix = "d";
                                divideByHowMuch = -1;
                                break;
                            case 2:
                                prefix = "c";
                                divideByHowMuch = -2;
                                break;
                            case 3: case 4: case 5:
                                prefix = "m";
                                divideByHowMuch = -3;
                                break;
                            case 6: case 7: case 8:
                                prefix = "µ";
                                divideByHowMuch = -6;
                                break;
                            case 9: case 10: case 11:
                                prefix = "n";
                                divideByHowMuch = -9;
                                break;
                            case 12: case 13: case 14:
                                prefix = "p";
                                divideByHowMuch = -12;
                                break;
                            case 15: case 16: case 17:
                                prefix = "f";
                                divideByHowMuch = -15;
                                break;
                            case 18: case 19: case 20:
                                prefix = "a";
                                divideByHowMuch = -18;
                                break;
                            case 21: case 22: case 23:
                                prefix = "z";
                                divideByHowMuch = -21;
                                break;
                            default:
                                prefix = "y";
                                divideByHowMuch = -24;
                                break;
                        }
                    }
                    #endregion

                    amount /= (decimal)Math.Pow(10, divideByHowMuch);

                    return $"{amount}{prefix}{Symbol}";
                }
            }
            #endregion

            #region ToString
            public string OneLinerToString()
            {
                string text = $"{Name}, {Price} ";

                switch (Units == 1)
                {
                    case true: text += "(1 unidad)"; break;
                    case false: text += $"({Units} unidades)"; break;
                }

                return $"{text} {OneLinerToStringExtras()}";
            } 
            protected virtual string OneLinerToStringExtras() => "";
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
                text += $"Precio: {Price}";
                #endregion
                text += '\n';

                text += ToStringExtras();

                return text;
            }
            protected virtual string ToStringExtras() => "";
            #endregion

            #region GetDataForInsert
            /// <summary>
            /// Note that this returns all properties except for <see cref="ID"/>, since <see cref="ID"/> is meant to be auto_increment
            /// </summary>
            /// <returns></returns>
            public Dictionary<string, object> GetDataForInsert()
            {
                Dictionary<string, object> dict = [];

                dict.Add(Elements_Properties.Name, Name);
                dict.Add(Elements_Properties.Units, Units);
                dict.Add(Elements_Properties.Sales, Sales);
                dict.Add(Elements_Properties.Price, Price.ActualNumberInsteadOfString);
                // 2025 Apr 12: Seems like dictionaries don't have AddRange function
                foreach (KeyValuePair<string, object> thingy in GetDataForInsertExtras()) dict.Add(thingy.Key, thingy.Value);

                return dict;
            }
            protected virtual Dictionary<string, object> GetDataForInsertExtras() => [];
            #endregion

            #region Parse
            public static Element Parse(Product product) => new(product.Name, product.Units, product.Sales, product.ID, product.Price.ActualNumberInsteadOfString);

            #region Electronics
            public static Element Parse(Resistance resistance) => new(resistance.Name, resistance.Units, resistance.Sales, resistance.ID, resistance.Price.ActualNumberInsteadOfString);
            public static Element Parse(Capacitor capacitor) => new(capacitor.Name, capacitor.Units, capacitor.Sales, capacitor.ID, capacitor.Price.ActualNumberInsteadOfString);
            #endregion
            #endregion
        }
        /// <summary>
        /// Used to clear your list of elements
        /// </summary>
        protected abstract void ClearElementsList();
        #endregion

        #region Update Database
        public void UpdateDataBase()
        {
            if (!File.Exists(DataBaseManager.DB_Path)) throw new Exception();

            ClearElementsList();

            List<Dictionary<string, object>> elements = DataBaseManager.SelectFrom(TableName, "*");
            foreach (Dictionary<string, object> properties in elements)
            {
                DealWithZeElements(properties);
            }

        }

        /// <summary>
        /// Used to add a <see cref="Element"/> derivative to <b>A LIST MADE IN THE DERIVATIVE CLASS</b> check the origin of this method for an example
        /// </summary>
        /// <param name="properties"></param>
        public abstract void DealWithZeElements(Dictionary<string, object> properties);
        //{
        //    long? ID = null, Units = null, Sales = null;
        //    decimal? Price = null;
        //    string? Name = null;
        //    foreach (var ele in properties)
        //    {
        //        switch (ele.Key)
        //        {
        //            case Products_Properties.Name: Name = ele.Value.ToString(); break;
        //            case Products_Properties.ID: ID = (long)ele.Value; break;
        //            case Products_Properties.Units: Units = (long)ele.Value; break;
        //            case Products_Properties.Sales: Sales = (long)ele.Value; break;
        //            case Products_Properties.Price: Price = (decimal)ele.Value; break;
        //            default: throw new Exception($"{ele.Key} has no entry in this switch \nwhich is bad by the way");
        //        }

        //        if (ID != null && Name != null && Units != null && Sales != null && Price != null)
        //            Elements.Add(new(Name, (int)Units, (int)Sales, (int)ID, (double)Price));
        //    }
        //}
        #endregion

        #region Setting up database
        public void SetUpDatabase()
        {
            ClearElementsList();

            string dbPath = DataBaseManager.DB_Path;

            if (!File.Exists(dbPath))
                SQLiteConnection.CreateFile(dbPath);

            // 2025 Apr 08: Delete this when Product inventory is made better
            DataBaseManager.ExecuteNonQuery($"drop table if exists {TableName}");

            using SQLiteConnection connection = new(DataBaseManager.ConnectionString);
            connection.Open();

            #region Perfect the query
            string query = $"CREATE TABLE IF NOT EXISTS {TableName} (" +
                $"{Elements_Properties.ID} INTEGER PRIMARY KEY AUTOINCREMENT," +
                $"{Elements_Properties.Name} varchar(100) not null," +
                $"{Elements_Properties.Units} integer not null," +
                $"{Elements_Properties.Sales} integer not null," +
                $"{Elements_Properties.Price} decimal(10,2) not null";
            if (DataBaseParametersExtra() is not null && DataBaseParametersExtra() != string.Empty)
            {
                if (ShouldAddComa()) query += ", ";
                query += DataBaseParametersExtra();
            }
            query += ");";


            #endregion

            using SQLiteCommand command = new(query, connection);
            command.ExecuteNonQuery();

            switch (TableName)
            {
                case TableNames.Products:
                    Product product = new("Papas a la belgica", 3, sales: 1, price: 4);
                    DataBaseManager.InsertInto(TableName, product.GetDataForInsert());
                    product = new("Suizas Papas", 1, price: 3.99);
                    DataBaseManager.InsertInto(TableName, product.GetDataForInsert());
                    product = new("Franco-Papa", 3, sales: 2, price: 1.9);
                    DataBaseManager.InsertInto(TableName, product.GetDataForInsert());
                    break;

                case TableNames.Electronics.Resistances:
                    Resistance resitance = new("Resistencia mini", 3,  resistance: 1, price: 2.99);
                    DataBaseManager.InsertInto(TableName, resitance.GetDataForInsert());
                    resitance = new("Resistencia chica", resistance: 5);
                    DataBaseManager.InsertInto(TableName, resitance.GetDataForInsert());
                    resitance = new("Resistencia mediana", resistance: 1000);
                    DataBaseManager.InsertInto(TableName, resitance.GetDataForInsert());
                    resitance = new("Resistencia grande", resistance: 50000);
                    DataBaseManager.InsertInto(TableName, resitance.GetDataForInsert());
                    break;

                case TableNames.Electronics.Capacitors:
                    Capacitor capacitor = new("Capacitor grande", units: 3, capacitance: 1, price: 3.02);
                    DataBaseManager.InsertInto(TableName, capacitor.GetDataForInsert());
                    capacitor = new("Capacitor mediano", capacitance: (decimal)0.001);
                    DataBaseManager.InsertInto(TableName, capacitor.GetDataForInsert());
                    capacitor = new("Capacitor chico", capacitance: (decimal)0.000001);
                    DataBaseManager.InsertInto(TableName, capacitor.GetDataForInsert());
                    break;

            }

            UpdateDataBase();
        }
        private bool ShouldAddComa()
        {
            foreach(char letter in DataBaseParametersExtra())
            {
                if (char.IsLetter(letter) || char.IsDigit(letter)) return true;
                else if (letter is ',') return false;
            }
            return true;
        }

        /// <summary>
        /// Used to add extra parameters to the database for <see cref="Elements"/> that are not covered by <see cref="Element"/>, <b>SEPARATE EACH PARAMETER WITH A COMA</b>
        /// </summary>
        /// <returns></returns>
        protected virtual string DataBaseParametersExtra() => string.Empty;
        #endregion
    }
}
