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

        public void update(object sender, NewsEventArgs e)
        {
            this.tempp = e.tempp;
            display();
        }

        public void display()
        {
            if (tempp > 110)
                Console.WriteLine("Температура повышена!");
            else if(tempp >75 && tempp <109)
                Console.WriteLine("Температура в норме.");
            else
                Console.WriteLine("Температура низкая => повышенный расход топлива");

           
           
        }
    }

}
