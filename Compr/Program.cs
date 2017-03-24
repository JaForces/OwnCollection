using System;
using System.Collections;

namespace Compr
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random((int)DateTime.Now.Ticks);
            ArrayList list = new ArrayList();

            for (int i = 0; i < 20; i++)
            {
                list.Add(rnd.Next(1, 100));
            }


            list.Sort(new OwnClass());

            foreach (var item in list)
            {
                Console.Write(item + " ");
            }


            Console.ReadKey();
        }

        
    }

    public class OwnClass : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();
        public int Compare(object x, object y)
        {
            return comparer.Compare(y, x);
        }

       
    }
}
