using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeCollections1
{
    class Program
    {
        static void Main(string[] args)
        {
            Monthes myCalendar = new Monthes();
            foreach (var item in myCalendar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(new string('-', 40));
            myCalendar.GetMonthByDays(31); 
            Console.ReadKey();
        }
    }
}
