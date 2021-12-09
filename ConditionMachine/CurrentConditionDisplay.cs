using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionMachine
{
    internal class CurrentConditionDisplay : IObserver, IDisplayElement
    {
        private string PressureSensor, BrakeFluidSensor;
        private bool CheckAuto;



        public void update(object sender, NewsEventArgs e)
        {
            this.PressureSensor = e.PressureSensor;
            this.BrakeFluidSensor = e.BrakeFluidSensor;
            this.CheckAuto = e.CheckAuto;
            display();
        }

        public void display()
        {
            
            if (CheckAuto == false && PressureSensor == "normal" && BrakeFluidSensor == "normal")
                Console.WriteLine("Машина исправна");
            else
                Console.WriteLine("Необходим ремонт");
            if (CheckAuto == true)
                Console.WriteLine("Горит чек");
            else Console.WriteLine("Не горит чек");
           
        }

    }
}


