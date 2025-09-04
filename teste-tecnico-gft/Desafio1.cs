namespace teste_tecnico_gft
{
    public class Desafio1
    {
        public string Nome { get; }
        public int Quantidade { get; private set; }

        public Desafio1(string nome, int quantidade)
        {
            Nome = nome;
            Quantidade = quantidade;
        }

        public bool Retirar(int quantidade)
        {
            if (quantidade <= 0 || quantidade > Quantidade)
                return false;

            Quantidade -= quantidade;
            return true;
        }

        public string ExibirDados()
        {
            return $"Item: {Nome}, Quantidade: {Quantidade}";
        }
    }
}
