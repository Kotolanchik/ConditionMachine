using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionMachine
{
    internal class CurrentStatisticDisplay : IObserver, IDisplayElement
    {
        private int speed, Tahometr;

        private ISubject conditionMachine;

        public CurrentStatisticDisplay(ISubject conditionMachine)
        {
            this.conditionMachine = conditionMachine;
            conditionMachine.registerObserver(this);
        }

        public void update(string PressureSensor, string BrakeFluidSensor, bool CheckAuto, int speed, int tempp, int Tahometr)
        {
            this.speed = speed;
            this.Tahometr = Tahometr;

            display();
        }

        public void display()
        {
            if (Tahometr > 3500)
            {
                Console.Write("Расход горючего очень большой. ");
                if (speed > 140) Console.WriteLine("Сбавьте скорость!!!");
                else Console.WriteLine();
            }
            else
            {
                Console.Write("Умеренный расход горючего. ");
                if (speed > 140) Console.WriteLine("Сбавьте скорость!!!");
                else Console.WriteLine();
            }

        }
    }
}


