using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;

namespace LINQ
{
    class Program
    {
        public static ObservableCollection<Funcionario> funcionarios = new ObservableCollection<Funcionario>();

        static void Main(string[] args)
        {
            CarregarJsons();

            //var filtroSimple1 = from f in funcionarios
            //                    where f.Nome.StartsWith("A")
            //                    select f;
            ////var filtroSimple = funcionarios
            ////    .Where((f) => f.Nome.StartsWith("A"));

            //foreach (var item in filtroSimple1)
            //{
            //    Console.WriteLine($"{item.NomeCompleto}");
            //}

            //var filtroSimple2 = from f in funcionarios
            //                    where f.Nome.StartsWith("A")
            //                    select new
            //                    {
            //                        Campo1 = f.Nome,
            //                        Campo2 = f.Sobrenome
            //                    };
            //var filtroSimples2 = funcionarios
            //    .Where((f) => f.Nome.StartsWith("A"))
            //    .Select((f) => new
            //    {
            //        Campo1 = f.Nome,
            //        Campo2 = f.Sobrenome
            //    });
            //foreach (var item in filtroSimple2)
            //    Console.WriteLine($"{item.Campo1} {item.Campo2}");


            //var filtro3 = (from f in funcionarios
            //              group f by
            //              f.Nome.First().ToString() into g
            //              select new
            //              {
            //                  Chave = g.Key,
            //                  Quantidade = g.Count()
            //              }).OrderBy( g => g.Quantidade);
            //foreach (var item in filtro3)
            //{
            //    Console
            //        .WriteLine($"{item.Chave} - {item.Quantidade}");
            //}

            var filtro = from f in funcionarios
                         group f by new
                         {
                             Faixa = ((DateTime.Now - f.DataAdmissao)
                             .TotalDays / 365) > 3 ? "Senior" : "Junior"
                         } into grp select
                         new
                         {
                            Faixa = grp.Key, Quantidade = grp.Count()
                         };

            var filtr2 = funcionarios
                .Select(f => new
                {
                    Faixa = ((DateTime.Now - f.DataAdmissao)
                             .TotalDays / 365) > 3 ? "Senior" : "Junior"
                })
                .GroupBy( novoF => novoF.Faixa)
                .Select( g => new
                {
                    Faixa = g.Key, Quantidade = g.Count()
                });
            foreach (var item in filtr2)
            {
                Console.WriteLine($"{item} - {item.Quantidade}");
            }

            Console.ReadLine();
        }

        private static void CarregarJsons()
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.DateFormatString = "dd/MM/yyyy";

            string pasta = Path.GetDirectoryName(
                Path.GetDirectoryName(Directory.GetCurrentDirectory()));
            var arquivo = Path.Combine(pasta, "Funcionario.json");
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string json = sr.ReadToEnd();
                var registries = JsonConvert.DeserializeObject<ObservableCollection<Funcionario>>(json, settings);

                funcionarios = new ObservableCollection<Funcionario>(registries);
            }

            arquivo = Path.Combine(pasta, "Gerente.json");
            using (StreamReader sr = new StreamReader(arquivo))
            {
                string json = sr.ReadToEnd();
                var registries = JsonConvert.DeserializeObject<ObservableCollection<Gerente>>(json, settings);

                var list = funcionarios.Concat(registries);
                funcionarios = new ObservableCollection<Funcionario>(list);
            }
        }
    }
}
