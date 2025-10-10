namespace DiceRollSimulator
{
    class Program
    {
        static void Main(string[] agrs)
        {
            System.Console.WriteLine("Seja benvindo ao simulador de lançamento de Dados");
            System.Console.WriteLine("Faca a sua escoha entre os números 1 e 6");
            System.Console.WriteLine("Faca o seu lancamento");
            int user = Validar(Console.ReadLine());
            var a = new Random();
            int b = a.Next(1, 6);
            if (user == b)
            {
                System.Console.WriteLine("Você acertou");
            }
        }
        static int Validar(string valor)
        {
            int integer;
            while (!int.TryParse(valor, out integer) || (integer > 6 && integer <1))
            {
                System.Console.WriteLine("Valor Invalido! Digite um valor numérico entre 1 a 6");
                valor = Console.ReadLine();
            }
            return integer;
        }
    }
}