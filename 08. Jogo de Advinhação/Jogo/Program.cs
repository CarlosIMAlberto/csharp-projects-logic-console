using System;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
namespace Jogo
{
    class Program
    {
        static  Random numberSystem = new Random();
        static void Main(string[] args)
        {
            Console.Clear();
            Menu();
        }
        static void Menu()
        {
            System.Console.WriteLine("Welcolme in our Guessing Game");
            System.Console.WriteLine("In our game you will be invited to choose two different numbers to creat a range that you will play our gameguessing.");
            System.Console.WriteLine("After that you also will be invited to choose a number between it range you think will be the number that we choosed");
            System.Console.WriteLine("Our guessing and yours guessing needs to be equals for win."); 
            GetData();
        }
        static void GetData()
        {

             
            while(true)
            {
                System.Console.WriteLine("Type a first number of range");
                int input = ValidateData(Console.ReadLine());
                System.Console.WriteLine("Type a last number of the range");
                int input2 = ValidateData(Console.ReadLine());
                ValidateData2(input, input2);
                if (input > input2)
                {
                    int replace = input;
                    input = input2;
                    input2 = replace;
                }
                System.Console.WriteLine("Type the number that I choosed");
                int inputUser = ValidateData(Console.ReadLine());
                while(!((inputUser>=input) && (inputUser<=input2)))
                {
                    System.Console.WriteLine($"Type the number inside the sequence between {input} and {input2}");
                    inputUser = ValidateData(Console.ReadLine());
                }
                int numberSystemChoosed = numberSystem.Next(input, input2 + 1);
                TestingGame(inputUser, numberSystemChoosed);
                System.Console.WriteLine("Do you want to Exit? Press 2(Exit) or any number to (continue) gaming");
                int testContinue= ValidateData(Console.ReadLine());
                if(testContinue == 2)
                {
                    return;
                }
                Console.Clear();
            }
        }
        static void TestingGame(int inputUser, int numberSystemChoosed)
        {
            System.Console.WriteLine("Loanding the result in: ");
            for(int i=1; i<=5; i++)
            {
                System.Console.WriteLine(i);
                Thread.Sleep(1000);
            }
            Thread.Sleep(2500);
            if (inputUser == numberSystemChoosed)
            {
                Thread.Sleep(1000);
                System.Console.WriteLine("Congratulations you Win");
            }
            else if (inputUser > numberSystemChoosed)
            {
                System.Console.WriteLine("You lost");
                System.Console.WriteLine($"Your choice {inputUser} is greater than my choice {numberSystemChoosed} ");
            }
            else if (inputUser < numberSystemChoosed)
            {
                System.Console.WriteLine("You lost");
                System.Console.WriteLine($"Your choice {inputUser} is  less than my choice {numberSystemChoosed} ");
            }
            
        }
        static void ValidateData2(int input, int input2)
        {
            if (input == input2)
            {
                System.Console.WriteLine("Type a diferent numbers");
                GetData();
            }
            
        }
        static int ValidateData(string input)
        {
            int testedInput = 0;
            while (!int.TryParse(input, out testedInput))
            {
                System.Console.WriteLine("Type a numeric value");
                input = Console.ReadLine();
            }
            return testedInput;
        }
    }
}