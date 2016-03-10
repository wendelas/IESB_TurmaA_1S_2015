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
