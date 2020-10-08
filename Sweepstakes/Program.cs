using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want a que or a stack?");

            SweepstakesQueueManager thing = new SweepstakesQueueManager();
            SweepstakesStackManager thing2 = new SweepstakesStackManager();
            Console.ReadLine();
            Simulation sim1 = new Simulation();
            sim1.RunMain();
            Console.ReadLine();


        }
    }
}
