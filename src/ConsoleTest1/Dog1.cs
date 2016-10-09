using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    partial class Dog
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            private set {
                //look at value
                _name = value;
            }
        }
        public Dog(string name)
        {
            _name = name;
        }
        public void Speak(int times, string what="bark")
        {
            for (int i = 0; i < times; i++)
            {
                Console.WriteLine(what);
            }
        }
    }
}
