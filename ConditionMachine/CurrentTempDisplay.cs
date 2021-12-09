using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionMachine
{
    internal class CurrentTempDisplay : IObserver, IDisplayElement
    {
        private int tempp;
        private ISubject conditionMachine;

        public CurrentTempDisplay(ISubject conditionMachine)
        {
            this.conditionMachine = conditionMachine;
            conditionMachine.registerObserver(this);
        }

        public void update(string PressureSensor, string BrakeFluidSensor, bool CheckAuto, int speed, int tempp, int Tahometr)
        {
            this.tempp = tempp;

            display();
        }

        public void display()
        {
            if (tempp > 110)
                Console.WriteLine("Температура повышена!");
            else
                Console.WriteLine("Температура в норме.");

        }
    }

}
