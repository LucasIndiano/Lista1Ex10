using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista1Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade, ano;
            Console.WriteLine("Digite seu ano de nascimento: ");
            idade = int.Parse(Console.ReadLine());
            ano = 2024 - idade;
            if (ano >= 16) { Console.WriteLine("Pode Votar"); }
            else { Console.WriteLine("Não pode votar"); }

            if (ano >= 18) { Console.WriteLine("Pode Dirigir");}
            else { Console.WriteLine("Não pode Dirigir"); }

            Console.ReadKey();
        }
    }
}
