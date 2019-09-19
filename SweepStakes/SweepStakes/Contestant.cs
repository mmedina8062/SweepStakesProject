using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepStakes
{
    public abstract class Contestant
    {
        //member variables
        public Contestant FirstName;
        public Contestant LastName;
        public Contestant RegistrationNumber;


        //ctor
        public Contestant()
        {

        }

        //member methods
        public abstract void Name();

        public abstract void Email();

        public abstract void RegistrationNumber()



    }
}
