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

        public void update(object sender, NewsEventArgs e)
        {
            this.speed = e.speed;
            this.Tahometr = e.Tahometr;

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


