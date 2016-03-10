using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            ObservableCollection<Funcionario> list
                = new ObservableCollection<Funcionario>();

            list.CollectionChanged += List_CollectionChanged;
            //list.CollectionChanged -= List_CollectionChanged;

            list.Add(new Funcionario());
            list.Add(new Funcionario());
            list.Add(new Funcionario());
            list.Add(new Funcionario());
            list.Add(new Funcionario());
            list.Add(new Funcionario());

            list.RemoveAt(2);

            //var result = list
            //    .Where( (f) => f.Nome.Contains("Fulano"));
            //var result = from f in list
            //             where f.Nome.Contains("Fulano")
            //             select new
            //             {
            //                 MeuNome = f.NomeCompleto
            //             };

            //foreach (var item in result)
            //{

            //}



            Console.ReadLine();
        }

        private static void
            List_CollectionChanged(object sender,
            NotifyCollectionChangedEventArgs e)
        {
            switch (e.Action)
            {
                case NotifyCollectionChangedAction.Add:
                    Console.WriteLine("Lista adicionada");
                    break;
                case NotifyCollectionChangedAction.Remove:
                    Console.WriteLine("Lista removida");
                    break;
                case NotifyCollectionChangedAction.Replace:
                    Console.WriteLine("Lista alterada");
                    break;
                default:
                    break;
            }
        }
    }
    }
}
