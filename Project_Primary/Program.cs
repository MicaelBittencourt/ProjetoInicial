using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Primary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------Questionário------------------");
            Console.WriteLine("Qual Seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual Seu endereço?");
            string endereco = Console.ReadLine();
            Console.WriteLine("Qual Seu email?");
            string email = Console.ReadLine();
            DateTime utcDate = DateTime.UtcNow;

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("Nome: "+nome+" \nIdade:"+idade+"\nEndereço: "+endereco+"\nData de Cadaastro: "+utcDate.ToLocalTime());

        }
    }
}
