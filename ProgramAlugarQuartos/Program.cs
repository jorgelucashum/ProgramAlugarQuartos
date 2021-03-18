using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramAlugarQuartos
{
    class Program
    {
        static void Main(string[] args)
        {
            Inquilino[] inquilinoVect = new Inquilino[10];

            Console.Write("Quantos quartos vão ser alugado? ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write("\nNome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                inquilinoVect[quarto] = new Inquilino { Nome = nome, Email = email, Quarto = quarto };

            }

            Console.Write("\nQuartos ocupados: ");
            for (int i = 0; i < inquilinoVect.Length; i++)
            {
                if (inquilinoVect[i] != null)
                {
                    Console.Write(inquilinoVect[i]);
                }
            }


            Console.ReadLine();
        }
    }
}
