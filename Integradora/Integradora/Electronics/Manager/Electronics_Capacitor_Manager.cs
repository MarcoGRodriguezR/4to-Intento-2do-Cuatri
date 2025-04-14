using Integradora._Generics.Manager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static Integradora.Program;

namespace Integradora.Electronics.Manager
{
    public class Electronics_Capacitor_Manager : Generics_Manager
    {
        public override string TableName => TableNames.Electronics.Capacitors;

        public class Capacitor_Properties
        {
            public const string Capacitance = "Capacitance";
        }
        public override void DealWithZeElements(Dictionary<string, object> properties)
        {
            long? ID = null, Units = null, Sales = null;
            decimal? Price = null, Capacitance = null;
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
                    case Capacitor_Properties.Capacitance: Capacitance = (decimal)ele.Value; break;
                    default: throw new Exception($"{ele.Key} has no entry in this switch \nwhich is bad by the way");
                }

                if (ID is not null && Name is not null && Units is not null && Sales is not null && Price is not null && Capacitance is not null)
                    Capacitors.Add(new(Name, (int)Units, (int)Sales, (int)ID, (double)Price, (decimal)Capacitance));
            }
        }

        protected override string DataBaseParametersExtra() => $"{Capacitor_Properties.Capacitance} decimal(10,2) not null";


        public List<Capacitor> Capacitors = [];
        public class Capacitor(string name, int units = 0, int sales = 0, int id = 0, double price = 0, decimal capacitance = 1) : Element(name, units, sales, id, price)
        {
            public ScientificNotationHelper Capacitance = new(capacitance, 'F');

            protected override Dictionary<string, object> GetDataForInsertExtras()
            {
                Dictionary<string, object> dict = [];

                dict.Add(Capacitor_Properties.Capacitance, Capacitance.Value);

                return dict;
            }


            protected override string ToStringExtras() => $"Capacitancia: {Capacitance}";
        }
        protected override void ClearElementsList() => Capacitors.Clear();
    }
}
