using Integradora._Generics.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Integradora.Program;

namespace Integradora.Electronics.Manager
{
    public class Electronics_Resistance_Manager : Generics_Manager
    {
        public override string TableName => TableNames.Electronics.Resistances;

        public class Resistance_Properties
        {
            public const string Resistance = "Resistance";
        }
        public override void DealWithZeElements(Dictionary<string, object> properties)
        {
            long? ID = null, Units = null, Sales = null;
            decimal? Price = null, Resistance = null;
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
                    case Resistance_Properties.Resistance: Resistance = (decimal)ele.Value; break;
                    default: throw new Exception($"{ele.Key} has no entry in this switch \nwhich is bad by the way");
                }

                if (ID is not null && Name is not null && Units is not null && Sales is not null && Price is not null && Resistance is not null)
                    Resistances.Add(new(Name, (int)Units, (int)Sales, (int)ID, (double)Price, (decimal)Resistance));
            }
        }

        protected override string DataBaseParametersExtra() => $"{Resistance_Properties.Resistance} decimal(10,2) not null";


        public List<Resistance> Resistances = [];
        public class Resistance(string name, int units = 0, int sales = 0, int id = 0, double price = 0, decimal resistance = 1) : Element(name, units, sales, id, price)
        {
            public ScientificNotationHelper ResistanceValue = new(resistance, 'Ω');

            protected override Dictionary<string, object> GetDataForInsertExtras()
            {
                Dictionary<string, object> dict = [];

                dict.Add(Resistance_Properties.Resistance, ResistanceValue.Value);

                return dict;
            }


            protected override string ToStringExtras() => $"Resistencia: {ResistanceValue}";
        }
        protected override void ClearElementsList() => Resistances.Clear();
    }
}
