using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        //stack data structure
        private Stack<Sweepstakes> stack;


        public SweepstakesStackManager()
        {
            stack = new Stack<Sweepstakes>();
        }

        public void InsertSweepstakes(Sweepstakes sweeepstakes)
        {

        }

        public void GetSweepstakes()
        {
            
        }
    }
}
