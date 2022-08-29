using System;

namespace SealedModifier
{
    //it does not compile public class SealedBase! We have to use only the public class SealedBase for deriving the class!
    public class SealedBase
    {

    }

    
    public class DerivedFromSealed : SealedBase
    {
        public DerivedFromSealed()
        {
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my GitHub Account!");
            Console.ReadKey();
        }
    }
}
