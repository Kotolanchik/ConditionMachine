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
        private ISubject conditionMachine;

        public CurrentConditionDisplay(ISubject conditionMachine)
        {
            this.conditionMachine = conditionMachine;
            conditionMachine.registerObserver(this);
        }

        public void update(string PressureSensor, string BrakeFluidSensor, bool CheckAuto, int speed, int tempp, int Tahometr)
        {
            this.PressureSensor = PressureSensor;
            this.BrakeFluidSensor = BrakeFluidSensor;
            this.CheckAuto = CheckAuto;
            display();
        }

        public void display()
        {
            if (CheckAuto == false && PressureSensor == "normal" && BrakeFluidSensor == "normal")
                Console.WriteLine("Машина исправна");
            else
                Console.WriteLine("Необходим ремонт");

        }

    }
}


