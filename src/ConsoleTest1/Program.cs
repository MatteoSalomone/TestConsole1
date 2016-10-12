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
            // classi parziali
            Dog muttley = new Dog("Muttley");

            // reflection
            Type t1 = muttley.GetType();
            Console.WriteLine($"test classe parziale {Environment.NewLine} classe: {t1.Name}, namespace:{t1.Namespace}");

            muttley.Speak(2);
            muttley.Sleep();


            // casting tra classi (test da debuggare)
            CastingTest castTest = new CastingTest();
            castTest.test();
        }
    }
}
