using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public class MarketingFirm 
    {
        //member variable
        
        private ISweepstakesManager SweepstakesManager;
        private ISweepstakesManager SweepstakeQueueManager;
        public ISweepstakesManager getSweepstakesManager
        {
            get
            {
                return SweepstakesManager;
            }
        }

        public ISweepstakesManager getSweepstakeQueueManager
        {
            get
            {
                return SweepstakeQueueManager;
            }
        }

        //ctor
        public MarketingFirm(ISweepstakesManager SweepstakeQueueManager, ISweepstakesManager SweepstakeStackManager, string contestant)
        {
            this.SweepstakeQueueManager = SweepstakeQueueManager;
            this.SweepstakesManager = SweepstakeStackManager; 

        }

        //member method
        public void getSweepstakes()
        {
             
        }
       
    }
}
