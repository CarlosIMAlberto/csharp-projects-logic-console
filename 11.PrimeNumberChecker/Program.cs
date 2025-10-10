using System;
namespace PrimeNumberChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Digite um número inteiro");
            int valor = CheckerInt(Console.ReadLine());
            string resultado = PrimeNChecker(valor);
            System.Console.WriteLine(resultado);
        }
        public static int CheckerInt(string valor)
        {
            int integer = 0;
            while (!int.TryParse(valor, out integer))
            {
                System.Console.WriteLine("Valor inválido! digite um valor numérico inteiro");
                valor = Console.ReadLine();
            }
            return integer;
        }
        public static string PrimeNChecker(int number)
        {
            int cont = 0;
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    cont++;
                }
            }
            if(cont == 2)
            {
                return "Número Primo";
            }
            else
            {
                return "Este número não é um número primo";
            }
        }
    }
}