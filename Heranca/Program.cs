using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func1 = new Funcionario();
            func1.Salario = 1000;
            Console.WriteLine($"{func1.Salario}");

            Gerente ger1 = new Gerente();
            ger1.Salario = 1000;
            Console.WriteLine($"{ger1.Salario}");

            Funcionario ger2 = new Gerente();
            ger2.Salario = 1200;
            Console.WriteLine($"{ger2.Salario}");

            Console.ReadLine();
        }
    }
}
