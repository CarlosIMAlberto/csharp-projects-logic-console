using System;
using System.Threading;
namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            System.Console.WriteLine("Seja Benvindo ao nosso Programa");
            System.Console.WriteLine("O nosso Programa permite-nos ver toda Tabuada ou a tabela de um número específico ");
            Thread.Sleep(1000);
            System.Console.WriteLine("Estamos iniciando por sí");
            Thread.Sleep(1200);
            System.Console.WriteLine("Esperamos que tenha uma excelente experiência");
            Thread.Sleep(2500);
            System.Console.WriteLine("O programa começa em ");
            System.Console.Write("5 ");
            Thread.Sleep(1200);
            Console.Clear();
            System.Console.WriteLine("4 ");
            Thread.Sleep(1200);
            Console.Clear();
            System.Console.WriteLine("3 ");
            Thread.Sleep(1200);
            Console.Clear();
            System.Console.WriteLine("2 ");
            Thread.Sleep(1200);
            Console.Clear();
            System.Console.WriteLine("1 ");
            Thread.Sleep(1200);
            Console.Clear();
            System.Console.WriteLine("O nosso Programa permite-nos ver toda Tabuada ou a tabela de um número específico ");
            GetData();
        }
        static void GetData()
        {
            System.Console.WriteLine("Digite 1 para ver toda tabuada e 2 para um número específico");
            byte inputTested = TestGetData(Console.ReadLine());
            if (inputTested == (byte)ETabuada.tabuada)
            {
                ShowTabuada();
                TestExit();
            }
            else
            {
                System.Console.WriteLine("Digite que valor que deseja ver a tabuada específica");
                int numero = TestGetNUmber(Console.ReadLine());
                ShowTabuadaEspecificNumber(numero);
                TestExit();
            }
        }
        static int TestGetNUmber(string number)
        {
            int number1;
            while (!int.TryParse(number, out number1))
            {
                System.Console.WriteLine("Digite um valor numérico");
                number = Console.ReadLine();
            }
            return number1;
        }
        static void ShowTabuada()
        {
            for (int l = 2; l <= 12; l++)
            {
                for (int r = 1; r <= 12; r++)
                {
                    System.Console.WriteLine(l + " * " + r + " = " + l * r);
                }
            }

        }
        static void ShowTabuadaEspecificNumber(int number)
        {
            for (int r = 1; r <= 12; r++)
            {
                System.Console.WriteLine(number + " * " + r + " = " + number * r);
            }


        }
        static byte TestGetData(string input)
        {
            while (true)
            {
                if (input.Equals("1") || input.Equals("2"))
                {
                    break;
                }
                System.Console.WriteLine("Digite apenas 1 ou 2 como foi informado acima");
                input = Console.ReadLine();
            }
            byte inputReal = byte.Parse(input);
            return inputReal;
        }
        static void TestExit()
        {
                System.Console.WriteLine("Digite 1 para (continuar) ou 2 para (sair)");
                byte exit = TestGetData(Console.ReadLine());
                if (exit == (byte)ESair.continuar)
                {
                    Menu();
                }
                else
                {
                    return;
                }
        }
        

        enum ETabuada
        {
            tabuada = 1,
            EspecificNumber = 2
        }
        enum ESair
        {
            continuar = 1,
            sair = 2
        }
    }
}