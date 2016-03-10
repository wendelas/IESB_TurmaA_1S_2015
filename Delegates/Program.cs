using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<double, double, double> somar =
                 ((a, b) =>
                 {
                     return a + b;
                 });
            Console
                .WriteLine($"Soma.........: 10 + 20 = {somar(10, 20)}");

            Func<double, double, double> subtrair =
                 (a, b) => a - b;
            Console.WriteLine($"Subtrair.....: 10 - 20 = {subtrair(10, 20)}");

            Func<double, double, double> multiplicar =
                 (a, b) => a * b;
            Console.WriteLine($"Multiplicar..: 10 * 20 = {multiplicar(10, 20)}");

            Func<double, double, double> dividir =
                 (a, b) => a / b;
            Console.WriteLine($"Dividir......: 10 / 20 = {dividir(10, 20)}");

            Console.ReadLine();
        }

        //static double Somar(double a, double b)
        //{
        //    return a + b;
        //}

        //static double Subtrair(double a, double b)
        //{
        //    return a * b;
        //}

        //static double Multiplicar(double a, double b)
        //{
        //    return a * b;
        //}

        //static double Dividir(double a, double b)
        //{
        //    return a / b;
        //}
    }
}
