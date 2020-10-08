using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    static class UserInterface
    {
        public static string GetUserInputFor(string stringPrompt)
        {
            Console.WriteLine(stringPrompt);
            
            return Console.ReadLine();

        }
        public static void PrintContestantInfo(Contestant contestant, Dictionary<int, Contestant> contestants)
        {
            Console.WriteLine("Thank you for putting your name in the contest!\n", contestants);
        }
    }
}
