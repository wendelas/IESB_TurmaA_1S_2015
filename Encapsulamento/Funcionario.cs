namespace Encapsulamento
{
    class Funcionario
    {
        private string nome;
        public string Nome
        {
            get { return this.nome; }
            set { this.nome = value.ToUpper(); }
        }
        //private string sobrenome;
        //public string Sobrenome
        //{
        //    get { return this.sobrenome; }
        //    set { this.sobrenome = value.ToUpper(); }
        //}
        public string Sobrenome
        {
            get;
            set;
        }

        public string NomeCompleto
        {
            get { return $"{this.Nome} {this.Sobrenome}"; }
        }

    }
}
