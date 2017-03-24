using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Citizen
{
    class Program
    {
        static void Main(string[] args)
        {
            Citizens Citizens = new Citizens();
            Student Tim = new Student("Tim", "Hook", "HG2345667");
            Pensioner Jeff = new Pensioner("Jeff", "Potter", "FJ214543");
            Working Sara = new Working("Sara", "Shwaps", "ET4325657");
            Pensioner Collin = new Pensioner("Collin", "Wissley", "KR4673254");

            Citizens.Add(Tim);
            Citizens.Add(Jeff);
            Citizens.Add(Sara);
            Citizens.Add(Collin);

            foreach (var item in Citizens)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 40));

            Citizens.Remove(Tim);
            Citizens.Remove(Jeff);

            foreach (var item in Citizens)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
