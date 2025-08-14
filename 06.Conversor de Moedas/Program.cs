using System;
namespace ConversordeMoeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
            Console.ReadKey();
        }
        static void Menu()
        {
            System.Console.WriteLine("Seja Benvindo ao nosso conversor de Moedas");
            System.Console.WriteLine("A nossa aplicação permite fazer conversões dentre quaisquer uma das seguintes moedas kwanza, dolar e euro");
            System.Console.WriteLine("Estas moedas estão representadas pelos seguintes números 1(kwanza), 2(Dolar), 3(EURO)");
            while (true)
            {
                GetData();
                System.Console.WriteLine("Digite 0 para sair ou qualquer numero ou letra para continuar");
                string sair = Console.ReadLine();
                if (sair.Equals("0"))
                { 
                    return;
                }
            }
        }
        static void GetData()
        {
            System.Console.WriteLine("Digite Escolha 1(kwanza), 2(Dolar), 3(EURO) para  de origem");
            byte entrada1 = TestGetData(Console.ReadLine());
            TestData1(entrada1);

        }
        static void TestData1(byte entrada1)
        {
            byte entrada2=0;
            if (entrada1 == (byte)EMoeda.kwanza)
            {
                System.Console.WriteLine("Escolha  2(Dolar) ou 3(EURO) para  moeda de destino");
                entrada2 = TestGetData(Console.ReadLine());
            }
            if (entrada1 == (byte)EMoeda.euro)
            {
                System.Console.WriteLine("Digite Escolha 1(kwanza) ou 2(Dolar) para  moeda de destino");
                entrada2 = TestGetData(Console.ReadLine());
            }
            if (entrada1 == (byte)EMoeda.dolar)
            {
                System.Console.WriteLine("Digite Escolha 1(kwanza) ou  3(EURO) para  moeda de destino");
                entrada2 = TestGetData(Console.ReadLine());
            }
            while (true)
            {
                if (entrada1 != entrada2)
                {
                    break;
                }
                System.Console.WriteLine("A Moeda de origem e de destino precisam ser diferentes");
                GetData();
            }
             TestMooeda(entrada1, entrada2);
        }
        static void TestMooeda(byte entrada1, byte entrada2)
        {
            System.Console.WriteLine("Digite o valor a converter");
            double valor = TestValue(Console.ReadLine());
            System.Console.WriteLine("O valor será apresentado em: ");
            for (int i = 5; i > 0; i--)
            {
                System.Console.Write(i);
                Thread.Sleep(1000);
                Console.Clear();
            }
            switch (entrada1)
            {
                case (byte)EMoeda.kwanza:
                    switch (entrada2)
                    {
                        case (byte)EMoeda.dolar:
                            Console.WriteLine(ConversorKwzToDolar(valor) + " Dolares");
                            break;
                        case (byte)EMoeda.euro:
                            Console.WriteLine(ConversorKwzToEuro(valor) + " Euros");
                            break;
                    }
                    break;
                case (byte)EMoeda.dolar:
                    switch (entrada2)
                    {
                        case (byte)EMoeda.kwanza:
                            Console.WriteLine(ConversorDolarToKwz(valor) + " Kwanzas");
                            break;
                        case (byte)EMoeda.euro:
                            Console.WriteLine(ConversorDolarToEuro(valor) + " Euros");
                            break;
                    }
                    break;
                case (byte)EMoeda.euro:
                    switch (entrada2)
                    {
                        case (byte)EMoeda.kwanza:
                            Console.WriteLine(ConversorEuroToKwz(valor) + " Kwanzas");
                            break;
                        case (byte)EMoeda.dolar:
                            Console.WriteLine(ConversorEuroToDolar(valor) + " Dolares");
                            break;
                    }
                    break;
            }

        }
        static double TestValue(string entrada)
        {
            double number;

           while(!double.TryParse(entrada, out number))
            {
                Console.WriteLine("Digite apenas um valor numérico");
                entrada = Console.ReadLine();
            }
            return number;
        }
        
        
        static byte TestGetData(string entrada)
        {
            byte number = 0;
            while (true)
            {

                if (byte.TryParse(entrada, out number))
                {
                    if ((number == 1) || (number == 2) || (number == 3))
                    {
                        break;
                    }
                }
                Console.WriteLine("Digite apenas 1(kwanza), 2(Dolar), 3(EURO) para Moeda");
                entrada = Console.ReadLine();
            }
            return number;
        }
       
        static double ConversorKwzToDolar(double kwz)
            {
                
                string onekwzindolarz = "0,0010810wz";
                double dolar = double.Parse(onekwzindolarz.Substring(0,onekwzindolarz.Length - 3));
                return dolar * kwz;
            }
        static double ConversorDolarToKwz(double dolar)
        {
                string onedolarinkwz = "925,0kwz";
                double kwz = double.Parse(onedolarinkwz.Substring(0, onedolarinkwz.Length - 3));
                return kwz * dolar;
        }
        static double ConversorKwzToEuro(double kwz)
        {
            
            string onekwzinneuro = "0,005749kwz";
            double euro = double.Parse(onekwzinneuro.Substring(0,onekwzinneuro.Length - 3));
            return euro * kwz;
        }
        static double ConversorEuroToKwz(double euro)
        {
            string oneeuroinkwz = "1073,92kwz";
            double kwz = double.Parse(oneeuroinkwz.Substring(0,oneeuroinkwz.Length - 3));
            return kwz * euro;
           
        }
         static double ConversorEuroToDolar(double euro)
        {
            string oneeuroindolar = "1,167dolar";
            double dolar = double.Parse(oneeuroindolar.Substring(0, oneeuroindolar.Length - 5));
            return dolar * euro;
           
        }
        static double ConversorDolarToEuro(double dolar)
        {
            string onedolarineuro = "0,856euro";
            double euro = double.Parse(onedolarineuro .Substring(0, onedolarineuro.Length  - 4));
            return dolar * euro;
           
        }

        enum EMoeda
        {
            kwanza = 1,
            dolar = 2,
            euro = 3
        }
    }
    
}