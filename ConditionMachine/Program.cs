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
            CurrentConditionDisplay currentDisplay = new CurrentConditionDisplay(CondMachine);
            CurrentStatisticDisplay statisticsDisplay = new CurrentStatisticDisplay(CondMachine);
            CurrentTempDisplay tempDisplay = new CurrentTempDisplay(CondMachine);
            CondMachine.setMeasurements("normal", "normal", false, 79, 100, 3000);
            Console.WriteLine();
            CondMachine.setMeasurements("normal", "normal", true, 150, 120, 8500);
            Console.WriteLine();
            CondMachine.setMeasurements("hard", "hard", false, 79, 100, 3600);
            CondMachine.removeObserver(statisticsDisplay);
            Console.WriteLine();
            CondMachine.setMeasurements("hard", "normal", false, 144, 100, 3600);
            Console.WriteLine();

        }
    }
}
