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
        public Dictionary<int, Contestant> contestant = new Dictionary<int, Contestant>();
        int count = 1;

        public Sweepstakes(string name)
        {

        }

        public void RegisterContestant(Contestant contestant)
        {
            Console.WriteLine("Please Enter Name Below \n");
            Console.WriteLine("First Name: ");
            contestant.FirstName = Console.ReadLine();

            Console.WriteLine("Last Name: ");
            contestant.LastName = Console.ReadLine();

            Console.WriteLine("Please Enter Email: ");
            contestant.email = Console.ReadLine();

            
            count++;

            

        }

        public Contestant PickWinner()
        {

        }

        public void PrintContestantInfo(Contestant contestant)
        {

        }
    }
}
