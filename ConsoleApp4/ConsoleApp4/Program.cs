using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    /// <summary>
    /// Сортировка массива по возрастанию и выполнить реверс 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] fruit = { 4, 3, 6,7 };
            Array.Sort(fruit);
            Console.WriteLine(fruit);
            Array.Reverse(fruit);
            Console.WriteLine(fruit);
            Console.ReadKey();
        }
    }
}
