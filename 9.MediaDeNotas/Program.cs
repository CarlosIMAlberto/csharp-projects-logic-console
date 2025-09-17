using System;
namespace MediaDeNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            GetData();
        }
        static void GetData()
        {
            System.Console.WriteLine("Quantas alunos deseja cadastrar");
            byte goal = CheckDataByte(Console.ReadLine());
            var Alunos = new Aluno[goal];
            for (int i = 0; i < goal; i++)
            {
                Alunos[i] = new Aluno();
                System.Console.WriteLine("Digite um nome");
                Alunos[i].Nome = Console.ReadLine();
                System.Console.WriteLine("Digite o valor da primeira nota");
                Alunos[i].Notas = new double[2];
                Alunos[i].Notas[0] = CheckDataDouble(Console.ReadLine());
                System.Console.WriteLine("Digite o valor da segunda nota");
                Alunos[i].Notas[1] = CheckDataDouble(Console.ReadLine());

            }
            for (int i = 0; i < goal; i++)
            {
                System.Console.WriteLine($"{Alunos[i].Nome} teve {Alunos[i].Notas[0]} e {Alunos[i].Notas[1]} a primeira e segunda prova, média = {Alunos[i].Media(Alunos[i].Notas):F2}");
            }

        }
        static double CheckDataDouble(string data)
        {
            double nota = 0;
            while (true)
            {
                if (double.TryParse(data, out nota))
                    if (nota >= 0 && nota <= 20)
                        break;
                System.Console.WriteLine("Digite");
                data = Console.ReadLine();
            }
            return nota;
        }
        static Byte CheckDataByte(string data)
        {
            byte goal=0;
            while (!byte.TryParse(data, out goal))
            {
                System.Console.WriteLine("Entrada Invlálida ! Digite um número Válido e Alunos");
                data = Console.ReadLine();
            }
         return goal;  
        }
           
        }
    struct Aluno
    {
        public string Nome;
        public double[] Notas;

        public double Media(double[] notas)
        {
            return (notas[0] + notas[1]) / 2;
        }
        public Aluno(string nome, double[] notas)
        {
            Nome = nome;
            Notas = notas;
        }

    }   
}
