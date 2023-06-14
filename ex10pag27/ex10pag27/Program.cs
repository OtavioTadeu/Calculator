using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10pag27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, cd, i;

            Console.WriteLine("Operações:");
            Console.WriteLine("1 - Soma:");
            Console.WriteLine("2 - Subtração:");
            Console.WriteLine("3 - Multiplicação:");
            Console.WriteLine("4 - Divisão:");
            Console.WriteLine("-------------------------------");
            Console.Write("Digite o código da operação: ");
            cd = int.Parse(Console.ReadLine());
            Console.Write("Digite o primeiro valor: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");
            b = int.Parse(Console.ReadLine());
            while (cd != 9)
            {
                if (cd == 1)
                {
                    c = (a + b);
                    Console.WriteLine("Resultado: " + c);

                }
                if (cd == 2)
                {
                    c = (a - b);
                    Console.WriteLine("Resultado: " + c);

                }
                if (cd == 3)
                {
                    c = (a * b);
                    Console.WriteLine("Resultado: " + c);

                }
                if (cd == 4)
                {
                    if (b == 0)
                    {
                        Console.WriteLine("N2 não pode ser 0.");
                    }
                    else
                    {
                        c = (a / b);
                        Console.WriteLine("Resultado: " + c);
                    }
                }
                Console.WriteLine("Operações:");
                Console.WriteLine("1 - Soma:");
                Console.WriteLine("2 - Subtração:");
                Console.WriteLine("3 - Multiplicação:");
                Console.WriteLine("4 - Divisão:");
                Console.WriteLine("-------------------------------");
                Console.Write("Digite o código da operação: ");
                cd = int.Parse(Console.ReadLine());
                Console.Write("Digite o primeiro valor: ");
                a = int.Parse(Console.ReadLine());
                Console.Write("Digite o segundo valor: ");
                b = int.Parse(Console.ReadLine());
                Console.Clear();
            }

            Console.ReadKey();
        }
    }
}
