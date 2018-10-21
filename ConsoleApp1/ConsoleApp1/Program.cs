using ConsoleApp1.Dominio;
using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Mulher Ale = new Mulher("Alessandra Soares", "Programadora");

            Ale.BebeMaisQueOsHomens = true;
            Ale.DataNasc = new DateTime(1999, 05, 07);
            Ale.EstaDeTPM = false;
            Ale.EstaGravida = true;
            Ale.Idade = 19;

            string nomeIdade = Ale.NomeEIdade();

            // Console.WriteLine("Olar, meu nome é: " + Ale.Nome);
            // Console.WriteLine($"Eu tenho {Ale.Idade} anos");
            Console.WriteLine(nomeIdade);
            Console.Write(string.Format("Minha profissão é {0}", Ale.Profissao));

            Console.ReadKey();
        }
    }
}