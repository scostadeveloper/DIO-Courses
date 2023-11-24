using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
namespace _DOTNET.Models    //Namespace / caminho lógico
{
    /// <summary>
    /// Representa uma pessoa fisica
    /// </summary>
    public class Pessoa  //Classe
    {
        //Propriedade: São as propriedade são ás carácteristicas que a pessoa vai ter
        public string Nome { get; set; }   //Propriedade
        public int Idade { get; set; }  //get = pega o valor //set = atribui um valor   //Propriedade

        //Metodo: É a ação que a pessoa pode realizar
/// <summary>
/// Faz a pessoa se apresentar, dizendo seu nome e idade
/// </summary>
        public void Apresentar()    //Metodo ou Função     //O @ serve para setar que queremos usar a variável mesmo sendo uma palavra reservada
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");   //Parâmetro ou argumento.   //console = classe / WriteLine = Método
        }
    }
}