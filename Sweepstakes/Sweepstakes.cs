using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes : IUserInterface
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public int RegistrationNumber { get; set; }

        public void NewContestant(IUserInterface contestant)
        {
            
        }
    }

    //dictonary data structure
    private List<IUserInterface> contestants = new List<IUserInterface>();

        public void AddContestant(IUserInterface contestants)
        {
        contestants.Add(contestant);
        }
    }
}
