using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Dominio
{
    class Mulher : Pessoa
    {
        public Mulher(string nome, string profissao) : base(nome, profissao)
        {
            Genero = 'f';
        }
        public bool EstaDeTPM { get; set; }
        public bool BebeMaisQueOsHomens { get; set; }

        private bool estaGravida;

        public bool EstaGravida
        {
            get { return estaGravida; }
            set
            {
                if (EstaDeTPM)
                    estaGravida = false;
                else
                    estaGravida = value;
            }
        }
    }
}