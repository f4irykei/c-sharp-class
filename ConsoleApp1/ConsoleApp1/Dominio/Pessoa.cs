using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Dominio
{
    class Pessoa
    {
        public Pessoa(string nome, string profissao)
        {
            Nome = nome;
            Profissao = profissao;

        }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public DateTime DataNasc { get; set; }
        public string Profissao { get; set; }
        public char Genero { get; set; }

        public string NomeEIdade()
        {
            return $"O nome dessa pessoa é {Nome} e a idade é {Idade}";
        }
    }
}
