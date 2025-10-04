using static System.Console;

namespace ListaDeCompras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            List<Produto> Lista = new List<Produto>();
            WriteLine("Seja benvindo a lista de compras");
            WriteLine("Nesta Lista Pode Adicionar Produtos com a seguinte descrição: ");
            WriteLine("Nome, Quantidade, Preço Unitário e o Preço total");
            while (true)
            {
                var P = new Produto();
                WriteLine("Digite o nome do Produto");
                P.Nome = TestarNome(Console.ReadLine());
                WriteLine("Digite o Preço Unitário do Produto");
                P.Preço = TestarPreco(Console.ReadLine());
                WriteLine("Digite quantidade a comprar: ");
                P.Quantidade = TestarQuantidade(Console.ReadLine());
                P.PrecoTotal = P.Preço * P.Quantidade;
                Lista.Add(P);
                WriteLine("Digite 1 para sair do cadastramento ou qualquer tecla para para sair");
                string valor = Console.ReadLine();
                if (valor.Equals("1"))
                {
                    break;
                }

            }

            WriteLine("Cadastrou os seguuintes Produtos ");
            WriteLine("Quantidade|   Nome|  Preço| Preço Total");
            foreach (Produto item in Lista)
            {
                WriteLine($"{item.Quantidade}    {item.Nome}  {item.Preço.ToString("c")}  {item.PrecoTotal.ToString("c")}");
            }


        }
        static string TestarNome(string nome)
        {
            double valorNumerico = 0;
            while (string.IsNullOrWhiteSpace(nome) || double.TryParse(nome, out valorNumerico))
            {
                WriteLine("Erro! Valor Inválio. Digite nome sem caracteres numéricos");
                nome = Console.ReadLine();
            }
            return nome;
        }
        static double TestarPreco(string preço)
        {
            double Preço;
            while (!double.TryParse(preço, out Preço))
            {
                WriteLine("Erro! Valor Inválio. Digite um valor númerico");
                preço = Console.ReadLine();
            }
            return Preço;
        }
        static int TestarQuantidade(string valor)
        {
            int quantidade;
            while (!int.TryParse(valor, out quantidade))
            {
                WriteLine("Erro! Valor Inválio. Digite um valor númerico");
                valor = Console.ReadLine();
            }
            return quantidade;
        }
        struct Produto
        {
            public double Preço;
            public string Nome;
            public int Quantidade;
            public double PrecoTotal;
        }
    }
}
