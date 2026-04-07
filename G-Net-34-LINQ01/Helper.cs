using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_34_LINQ01
{
    public class Helper
    {
        public static void Print<T>(string title, IEnumerable<T> items)
        {
            Console.WriteLine(new string('_',30));
                Console.WriteLine(title);
                foreach (var item in items)
                    Console.WriteLine(item);
                Console.WriteLine();
            Console.WriteLine(new string('_', 30));
        }
        public static void PrintList<T>(string name, IEnumerable<T> items)
        {
            Console.WriteLine(new string('_', 30));
            Console.WriteLine($"{name} :[{string.Join(',',items)}]");
            Console.WriteLine(new string('_', 30));

        }
    }
}
