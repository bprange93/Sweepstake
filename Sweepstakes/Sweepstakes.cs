using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    public class Sweepstakes
    {
        private Dictionary<int, Contestant> contestants;
        private string name;
        public string Name { get; set; }

        public Sweepstakes(string Name)
        {
            this.Name = name;
            contestants = new Dictionary<int, Contestant>();
        }

                        //move to UserInterface
        public void RegisterContestant(Contestant contestant) //Assingns contestant obj an int Key and adds the contestants registration
        {
            int registerNumber = contestants.Count + 1;
            contestants.Add(registerNumber, contestant);
            contestant.RegistrationNumber = registerNumber;
            Console.WriteLine($"{ contestants.Count} + {contestant.RegistrationNumber} + {contestant.FirstName}");
        }

        //public Contestant PickWinner()
        //{
        //    return;
        //}

        public void PrintContestantInfo(Contestant contestant)
        {
            
        }

        public int GetRandomNumber(int max)
        {
            Random random = new Random();
            int randomResult = random.Next(max);
            return randomResult;
        }
    }
}

