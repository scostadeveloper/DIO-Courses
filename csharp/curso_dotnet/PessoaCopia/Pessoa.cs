using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace curso_dotnet.PessoaCopia    //Namespace / caminho lógico      //O nome do arquivo precisa ser o mesmo do namespace para facilitar buscas
{
    public class Pessoa  //Classe
    {
        //Propriedade: São as propriedade são ás carácteristicas que a pessoa vai ter
        public string Nome { get; set; }   //Propriedade
        public int Idade { get; set; }  //get = pega o valor //set = atribui um valor   //Propriedade
        public string NomeRepresentanteLegalDaPessoaFisica { get; set; }

        //Metodo: É a ação que a pessoa pode realizar
        public void Apresentar()    //Metodo ou Função     //O @ serve para setar que queremos usar a variável mesmo sendo uma palavra reservada
        {
            Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos.");   //Parâmetro ou argumento.   //console = classe / WriteLine = Método
        }
    }
}