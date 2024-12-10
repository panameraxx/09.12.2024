using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
     class Program
    {
      /// <summary>
      /// Найти минимальное или максимальное значение в массиве 
      /// </summary>
     
        static void Main(string[] args)
        {
            int[] omas = { -8, 6, 9, 10 };
            int max = omas.Max();
            int min = omas.Min();
            Console.WriteLine($"минимальное = {min} \n максимальное = {max}");
            Console.ReadKey();
        }
    }
}
