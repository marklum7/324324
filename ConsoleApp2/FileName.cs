using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Animal
    {
        public abstract string pol { get; set; }
    }

    public class Pet : Animal
    {
        public override string pol { get; set; }
        public string name { get; set; }
    }

    public class Cat : Pet
    {
        public string color { get; set; }
    }

    public class Dog : Pet
    {
        public string poroda { get; set; }
    }
}
