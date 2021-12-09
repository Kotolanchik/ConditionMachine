using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionMachine
{

    public class NewsEventArgs
    {
        public NewsEventArgs(string PressureSensor, string BrakeFluidSensor, bool CheckAuto, int speed, int tempp, int Tahometr)
        {
            this.PressureSensor = PressureSensor;
            this.BrakeFluidSensor = BrakeFluidSensor;
            this.CheckAuto = CheckAuto;
            this.speed = speed;
            this.tempp = tempp;
            this.Tahometr = Tahometr;
        }
        public string PressureSensor { get; private set; }
        public string BrakeFluidSensor { get; private set; }
        public bool CheckAuto { get; private set; }
        public int speed { get; private set; }
        public int tempp { get; private set; }
        public int Tahometr { get; private set; }
    }
    public delegate void NewsChangedEventHandler(object sender, NewsEventArgs e);

    internal class ConditionMachine: ISubject
    {
        private ArrayList observers;
        private string PressureSensor, BrakeFluidSensor;
        private bool CheckAuto;
        private int speed, tempp, Tahometr;       
       
        public ConditionMachine()
        {
            observers = new ArrayList();
        }




        
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void removeObserver(IObserver o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.RemoveAt(i);
        }
        public void notifyObservers()
        {
            for (int i = 0; i < observers.Count; i++)
            {
                IObserver observer = (IObserver)observers[i];
                observer.update(PressureSensor, BrakeFluidSensor, CheckAuto, speed, tempp, Tahometr);
            }
        }
        public void measurementsChanged()
        {
            notifyObservers();
        }
        public void setMeasurements(string PressureSensor, string BrakeFluidSensor, bool CheckAuto, int speed, int tempp, int Tahometr)
        {
            this.PressureSensor = PressureSensor;
            this.BrakeFluidSensor = BrakeFluidSensor;
            this.CheckAuto = CheckAuto;
            this.speed = speed;
            this.tempp = tempp;
            this.Tahometr = Tahometr;
            measurementsChanged();
        }
    }

}
