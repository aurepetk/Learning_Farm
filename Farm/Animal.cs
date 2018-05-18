using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    public class Animal
    {
        public string Saying { get; set; }
        public string Name { get; set; }

        public Animal(string name)
        {
            Name = name;
        }

        public void Talk()
        {
            Console.WriteLine(Saying);
        }
    }

    public class Horse: Animal
    {
        public Horse(string name) :base (name)
        {
            Saying = "Yhaha";
        }
    }

    public class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
            Saying = "Mooo";
        }
    }

    public class Sheep : Animal
    {
        public Sheep(string name) : base(name)
        {
            Saying = "Bah";
        }
    }

    public class Pig : Animal
    {
        public Pig(string name) : base(name)
        {
            Saying = "Oink";
        }
    }
}
