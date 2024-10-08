using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public class Bird
    {
        public virtual void Fly()
        {
        }
    }

    public class Sparrow : Bird
    {
        public override void Fly()
        {
        }
    }

    public class Penguin : Bird
    {
        //Below fly is not applicable to penguin
        public override void Fly()
        {
        }
    }
}
