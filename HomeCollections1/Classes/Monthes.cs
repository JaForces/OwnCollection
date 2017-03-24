using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HomeCollections1
{
    class Monthes
    {
        List<Month> monthes = null;
        public Monthes()
        {
            monthes = new List<Month>()
            {
                new Month("January", 31, 1),
                new Month("Febuary", 28, 2),
                new Month("March", 31, 3),
                new Month("April", 30, 4),
                new Month("May", 31, 5),
                new Month("June", 30, 6),
                new Month("July", 31, 7),
                new Month("August", 31, 8),
                new Month("September", 30, 9),
                new Month("October", 31, 10),
                new Month("November", 30, 11),
                new Month("December", 31, 12)
            };
        }
        public string this[int index]
        {
            get
            {
                if (index == monthes[index].Id - 1)
                    return monthes[index].Name;
                return "No Records";
            }
        }
        public IEnumerator GetEnumerator()
        {
            foreach (var item in monthes)
            {
                yield return item.Name;
            }
        }

        public void GetMonthByDays(int days)
        {
            foreach (var item in monthes)
            {
                if (item.Days == days)
                {
                    Console.WriteLine(item.Name); 
                }
            }
        }
    }
}
