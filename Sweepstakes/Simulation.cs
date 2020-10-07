using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Simulation
    {
        //member variables
        public Contestant contestant1;
        public Contestant contestant2;
        public Sweepstakes sweepstakes1;
        //constructor
        public Simulation()
        {
            
        }
        // member methods

        public void RunMain()
        {
            sweepstakes1 = new Sweepstakes("Chachie");                                  //fix later for random number getting deleted. Gets program working right now. 
            contestant1 = new Contestant("Jack", "Sparrow", "JSparrow@gmail.com", sweepstakes1.GetRandomNumber(50));
            contestant2 = new Contestant("Steve", "Rogers", "SRogers@gmail.com", sweepstakes1.GetRandomNumber(50));
            sweepstakes1.RegisterContestant(contestant1);
            sweepstakes1.RegisterContestant(contestant2);
            Console.ReadLine();
        }

        public void CreateMarketingFirmWithManager()
        {

        }
    }
}
