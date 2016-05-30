using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Elevator
{
    class Elevator
    {
        static void Main()
        {
            int people = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());
            int courses = 0;
            courses += people / capacity;
            if (people % capacity > 0)
            {
                courses += 1;
            }
            Console.WriteLine(courses);
        }
    }
}
