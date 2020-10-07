using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        //functionality to create sweepstakes
        //implement dependency injection to utilize sweepstakes manager, document wehre I will be using Dependency and what benefits it add to structure
        //dependency injection will come from the simulation class when making a marketing firm manager. 

        private ISweepstakesManager manager;
        public SweepstakesStackManager sweepStack;
        public SweepstakesQueueManager sweepQueue;


        public MarketingFirm()
        {
            sweepStack = new SweepstakesStackManager();
            sweepQueue = new SweepstakesQueueManager();
        }
    }
}
