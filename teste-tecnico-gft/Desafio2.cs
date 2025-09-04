namespace teste_tecnico_gft
{
    public class Pessoa 
    {
        public string Nome { get; set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public virtual string Saudacao()
        {
            return $"Olá, sou {Nome}.";
        }
    }

    public class Cliente : Pessoa
    {
        public int numeroFidelidade { get; }

        public Cliente(string nome, int numeroFidelidade) : base(nome)
        {
            this.numeroFidelidade = numeroFidelidade;
        }

        public override string Saudacao()
        {
            return $"{base.Saudacao()}, cliente número {numeroFidelidade}.";
        }
    }
}
