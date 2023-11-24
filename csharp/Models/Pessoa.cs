using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class Pessoa
    {
        //Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }

        //Metodos / Função
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");
        }
    }
}