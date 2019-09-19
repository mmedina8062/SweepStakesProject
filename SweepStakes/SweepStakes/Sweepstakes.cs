using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class Sweepstakes
    {
        //member variable
        public Dictionary<int, Contestant> contestants = new Dictionary<int, Contestant>();
        int count = 1;
         

        public Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            Console.WriteLine("Please Enter Name\n");
            Console.WriteLine("First Name: ");
            contestant.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            contestant.LastName = Console.ReadLine();

            Console.WriteLine("Please Enter Email: ");
            contestant.email = Console.ReadLine();

            contestant.registrationNumber = count;

            count++;

            contestants.Add(contestant.registrationNumber, contestant);
        }

        public Contestant PickWinner()
        {
            Random rand = new Random();
            int randomKey = rand.Next(1, contestants.Count);

            Contestant winner = contestants[randomKey];

            return winner;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine(contestant.FirstName + contestant.LastName + contestant.registrationNumber, contestant);
        }
    }
}
