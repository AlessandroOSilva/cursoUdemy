using System;
using System.ComponentModel.DataAnnotations;

namespace AluguelDeQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many rooms will be rent? ");
            int quant = int.Parse(Console.ReadLine());

            Quarto[] vect = new Quarto[9];

            for ( int i = 0; i < quant; i++)
            {
                string nome, email;
                int numero;
                Console.WriteLine();
                Console.WriteLine("RENT #"+ (i + 1) + ": ");
                Console.Write("Nome: ");
                nome = Console.ReadLine();

                Console.Write("Email: ");
                email = Console.ReadLine();

                Console.Write("Numero: ");
                numero = int.Parse(Console.ReadLine());

                vect[i] = new Quarto { Inquilino = nome, Email = email, Numero = numero };
            }
            
            Console.WriteLine();
            Console.WriteLine("BUSY ROOMS");
            Console.WriteLine();
            for (int i = 0; i < quant; i++)
            {
                if(vect[i] != null)
                {
                    Console.WriteLine(vect[i]);
                }
            }
        }
    }
}
