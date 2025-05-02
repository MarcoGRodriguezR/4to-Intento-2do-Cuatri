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

namespace Integrator
{
    public partial class LoadingScreenBecauseWeDefinitelyNeedThat : Form
    {
        private MasterMind Main;

        private static int ToSeconds(double value) => (int)(value * 1000);

        public LoadingScreenBecauseWeDefinitelyNeedThat(MasterMind main)
        {
            InitializeComponent();
            Main = main;
            Visible = true;

            Progress.Maximum = 3;
            Status.Text = "e";
        }


        private LoadingStates CurrentState;
        private enum LoadingStates
        {
            PreTimerForFancyness,
            Products,
            Electronics_Resistances,
            Electronics_Capacitors,
            Finished
        }

        private int Counter = 0, CounterMAX = 0;
        /// <summary>
        /// Note that this runs every milisecond
        /// </summary>
        public void UpdateMethod(object sender, EventArgs e)
        {
            double timer = 0.05;

            switch (CurrentState)
            {
                case LoadingStates.PreTimerForFancyness:
                    CounterMAX = ToSeconds(timer);
                    Status.Text = "Cargando";
                    Progress.Value = 0;

                    if (Counter >= CounterMAX)
                    {
                        CurrentState++;
                        Progress.Value++;
                        Counter = 0;
                    }
                    else Counter++;
                    break;
                case LoadingStates.Products:
                    Status.Text = "Cargando Productos";
                    CounterMAX = ToSeconds(timer);
                    
                    if (Counter is 0)
                    {
                        _Products_Manager.SetUpDatabase();
                        Counter++;
                    }
                    else if (Counter < CounterMAX)
                    {
                        Counter++;
                    }
                    else
                    {
                        Progress.Value++;
                        CurrentState++;
                        Counter = 0;
                    }

                    break;
                case LoadingStates.Electronics_Resistances:
                    Status.Text = "Cargando Resistencias";
                    CounterMAX = ToSeconds(timer);

                    if (Counter is 0)
                    {
                        _Resistance_Manager.SetUpDatabase();
                        Counter++;
                    }
                    else if (Counter < CounterMAX)
                    {
                        Counter++;
                    }
                    else
                    {
                        Progress.Value++;
                        CurrentState++;
                        Counter = 0;
                    }

                    break;
                case LoadingStates.Electronics_Capacitors:
                    Status.Text = "Cargando Capacitores";
                    CounterMAX = ToSeconds(timer);

                    if (Counter is 0)
                    {
                        _Capacitor_Manager.SetUpDatabase();
                        Counter++;
                    }
                    else if (Counter < CounterMAX)
                    {
                        Counter++;
                    }
                    else
                    {
                        CurrentState++;
                        Counter = 0;
                    }

                    break;
                case LoadingStates.Finished:
                    CounterMAX = ToSeconds(timer);
                    Status.Text = "Finalizando";

                    if (Counter >= CounterMAX)
                    {
                        Counter = 0;
                        Main.AllClear();
                        Dispose();
                    }
                    else Counter++;
                    break;
            }


        }
    }
}
