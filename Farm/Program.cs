using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            Barn barn = new Barn();
            Console.WriteLine("Insert farmer's id:");
            int farmer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert animal's id:");
            int animal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Insert job's id:");
            int work = Convert.ToInt32(Console.ReadLine());
            barn.Work(farmer, animal, work);
        }
    }
}
