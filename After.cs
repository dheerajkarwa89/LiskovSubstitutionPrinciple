using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    public abstract class _Bird
    {        
    }

    public interface IFlyingBird
    {
        void Fly();
    }

    public class _Sparrow : _Bird, IFlyingBird
    {
        public void Fly()
        { 
        }
    }

    public class _Penguin : _Bird
    {
        //no fly method adhering to LSP
    }
}
