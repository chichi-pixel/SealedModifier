using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedModifier
{
    public virtual void CodingCsharp() => Console.WriteLine("Base class");


    public class Derived : Base
    {
        // this Method is sealed!
        public sealed override void CodingCsharp() => Console.WriteLine("Derived class");
        
    }
    public class DerivedFromDerived : Derived
    {
        // no compile!already is sealed in the Derived Class!
        public CodingCsharp()
        {


        }
    }

}
      
