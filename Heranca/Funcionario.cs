using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Funcionario
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }
        private string sobrenome;
        public string Sobrenome
        {
            get { return this.sobrenome; }
            set { this.sobrenome = value.ToUpper(); }
        }

        public string NomeCompleto
        {
            get { return $"{this.Nome} {this.Sobrenome}"; }
        }

        public virtual double Salario
        {
            get;
            set;
        }
    }
}
