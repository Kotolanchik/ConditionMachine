using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConditionMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var CondMachine = new ConditionMachine();
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay();
            CurrentStatisticDisplay statisticsDisplay = new CurrentStatisticDisplay();
            CurrentTempDisplay tempDisplay = new CurrentTempDisplay();

            CondMachine.NewsChanged += new NewsChangedEventHandler(currentDisplay.update);
            CondMachine.NewsChanged += new NewsChangedEventHandler(statisticsDisplay.update);
            CondMachine.NewsChanged += new NewsChangedEventHandler(tempDisplay.update);

            CondMachine.setMeasurements();
            Console.WriteLine();

            CondMachine.setMeasurements();
            Console.WriteLine();

            CondMachine.setMeasurements();
            Console.WriteLine();

            CondMachine.setMeasurements();
            Console.WriteLine();

            CondMachine.NewsChanged -= tempDisplay.update;

            CondMachine.setMeasurements();
            Console.WriteLine();

        }
    }
}
