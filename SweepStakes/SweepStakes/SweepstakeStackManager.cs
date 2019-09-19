using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class SweepstakeStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            

            stack.Push(sweepstakes);

            Console.WriteLine();

        }

        public Sweepstakes GetSweepstakes()
        {
            return stack.Pop();
            
            
            

            



        }
    }
}
