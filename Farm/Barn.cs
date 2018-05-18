using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Barn
    {
        public Animal[] Animals { get; set; }
        public Farmer[]Farmers { get; set; }

        public Barn()
        {
            Animals = new Animal[4];
            Animal an1 = new Cow("Flower");
            Animal an2 = new Horse("Ben");
            Animal an3 = new Pig("Martha");
            Animal an4 = new Sheep("Meggie");

            Farmers = new Farmer[3];
            Farmer fa1 = new Farmer("John", 15);
            Farmer fa2 = new Farmer("Samanta", 4);
            Farmer fa3 = new Farmer("Nick", 7);

            Animals[0] = an1;
            Animals[1] = an2;
            Animals[2] = an3;
            Animals[3] = an4;

            Farmers[0] = fa1;
            Farmers[1] = fa2;
            Farmers[2] = fa3;
        }

        public void Work(int farmerid, int animalid, int jobid)
        {
            Farmer worker = Farmers[farmerid];
            Animal animal = Animals[animalid];

            switch (jobid)
            {
                case 1:
                    worker.FeedAnimal(animal);
                    break;
                case 2:
                    worker.WashAnimal(animal);
                    break;
                default:
                    Console.WriteLine("Invalid jobid.");
                    break;
            }
        }

    }
}
