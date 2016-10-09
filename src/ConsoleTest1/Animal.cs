using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleTest1
{
    class CastingTest
    {
        public void test()
        {
            var animal = new Animal();
            var feline = new Feline();
            var cat = new Cat();

            TakeAnimal(animal);
        }

        public void TakeAnimal(Animal a)
        {
            a.Alive = true;

            if (a is Cat)
            {
                var cat = a as Cat;
                cat.FurColor = "Smoke";
                cat.Name = "Tappo";
            }
        }
    }

    public class Animal
    {
        public Boolean Alive { get; set; }
    }

    public class Feline : Animal
    {
        public string FurColor { get; set; }
    }

    public class Cat : Feline
    {
        public string Name { get; set; }
    }
}
