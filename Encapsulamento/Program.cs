using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario func = new Funcionario();
            func.Nome = "Fulano";
            func.Sobrenome = "de Tal";

            Console.WriteLine($"{func.NomeCompleto}");
            Console.ReadLine();
        }
    }
}
