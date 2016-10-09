using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Dog muttley = new Dog("Muttley");

            muttley.Speak(2);
            
            muttley.Sleep();

            // test da debuggare
            CastingTest castTest = new CastingTest();
            castTest.test();
        }
    }
}
