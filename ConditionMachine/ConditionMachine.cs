using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionMachine
{
    internal class ConditionMachine
    {
        private Random rnd;
        public ConditionMachine() { rnd = new Random(); }

        public event NewsChangedEventHandler NewsChanged;

        private string _PressureSensor() => (rnd.Next(2) == 1) ? "normal" : "trouble";
        private string _BrakeFluidSensor() => (rnd.Next(2) == 1) ? "normal" : "trouble";        
        private bool _CheckAuto() => ((rnd.Next(3) == 2)|| (rnd.Next(3) == 1)) ? false : true;
        private int _speed() => rnd.Next(0, 220);
        private int _tempp() => rnd.Next(-30, 130);
        private int _Tahometr() => rnd.Next(900, 6000);


        public void setMeasurements()
        {
            string PressureSensor = _PressureSensor(), BrakeFluidSensor = _BrakeFluidSensor();
            bool CheckAuto = _CheckAuto();
            int speed = _speed(), tempp = _tempp(), Tahometr = _Tahometr();

            if (NewsChanged != null)
                NewsChanged(this, new NewsEventArgs(PressureSensor, BrakeFluidSensor, CheckAuto, speed, tempp, Tahometr));
        }
    }
}
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


