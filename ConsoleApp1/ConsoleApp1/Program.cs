using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Определить колво элементов в одномерном массиве с явной инициализацией
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            int[] omas = { 1, 21, 1, 2, 3 };
            int size = omas.Length;
            Console.WriteLine($"Размер: {size}");
            Console.ReadKey();
        }
    }
}
