using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Farmer
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }

        public Farmer(string name, int years)
        {
            Name = name;
            YearsOfExperience = years;
        }

        public void FeedAnimal(Animal animal)
        {
            Console.WriteLine(Name + " fed " + animal.Name + " and " + animal.Name + " said ");
            animal.Talk();
        }

        public void WashAnimal(Animal animal)
        {
            Console.WriteLine(Name + " washed " + animal.Name);
        }

    }
}
