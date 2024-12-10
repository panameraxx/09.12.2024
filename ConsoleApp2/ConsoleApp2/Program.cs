using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsoleApp2
{
    /// <summary>
    /// 
    /// </summary>
    class Program
    {
        static int Size()
        {
            Console.WriteLine("Размер массива:");
            int size;
            while(!int.TryParse(Console.ReadLine(), out size) || size <=0)
            {
                Console.WriteLine("Ошибка");
               
            }
            return size;
        }
        static int[] Input(int size)
        {
            
            int[] omas = new int[size];
            for (int i = 0; i < omas.Length; i++)
            {
                Console.WriteLine($"Введите{i + 1} значение");
                omas[i] = int.Parse(Console.ReadLine());
            }
            return omas;
        }

        static void Main(string[] args)
        {
            int[] omas = Input(Size());
            Array.Clear(omas, 1, 3);
            Output(omas);
            Console.ReadKey();
        }
        static void Output(int[] omas)
        {
            foreach (var e  in omas)
            {
                Console.WriteLine(e);
            }
        }
    }
}
