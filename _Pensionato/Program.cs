using System;

namespace _Pensionato
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos quartos serão alugados? ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine();

            Estudante[] aluguel = new Estudante[10];

            for(int i =0;i<n;i++)
            {
                Console.WriteLine("Aluguel #" + (i + 1));
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Email: ");
                string email = Console.ReadLine();
                Console.Write("Quarto: ");
                int quarto = int.Parse(Console.ReadLine());
                aluguel[quarto] = new Estudante(nome, email, quarto);
                Console.WriteLine();
            }

            Console.WriteLine("Quartos Ocupados: ");

            for(int i =0;i<10;i++)
            {
                if(aluguel[i] != null)
                {
                    Console.WriteLine(aluguel[i]);
                }
            }
            Console.WriteLine();


            
        }
    }
}
