using System;
using System.Collections.Generic;

namespace ClassesEConstrutores
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Points> list = new List<Points>();

            for (int i = 0; i < 50; i++)
            {
                list.Add(new Points(i, i * 2));
            }

            foreach (var item in list)
            {
                item.Print();
            }

            Console.ReadLine();
        }
    }
}
