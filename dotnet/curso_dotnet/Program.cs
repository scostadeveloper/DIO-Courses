using _DOTNET.Models; //Usamos o namespace da classe que queremos usar*/

class {

    static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
// TODO: Crie as outras condições necessárias para a resolução do desafio:
        string[] valores = new string[2];
        for (int i = 0; < n; i++)
        {
            valores = Console.ReadLine().Split(' ')
            string a = valores[0];
            string b = valores[1];
            
            if (b.Length > a.Length){
              Console.WriteLine("nao encaixa");
            }
                
            else if (a.EndsWith(b)){
                Console.WriteLine("encaixa");
            }
            else
                Console.WriteLine("nao encaixa");

        }

    }

}






// Pessoa p = new Pessoa(); 
// p.Nome = "Biel";
// p.Idade = 22;

// p.Apresentar();

// Calculadora c = new Calculadora();
// c.Somar(3,5);



/*
//Criar Lista sem precisar definir a capacidade. Sempre que possivel tentar usar listas ao inves de arrays.
List<string> listaString = new List<string>();

listaString.Add(Console.ReadLine());
listaString.Add("BH");
listaString.Add("SP");
listaString.Add("RJ");

Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Add("SC");

Console.WriteLine($"Items na minha lista: {listaString.Count} - Capacidade {listaString.Capacity}");

listaString.Remove("MG");


//Percorrer a lista com for
for (int contador = 0; contador < listaString.Count; contador++)
{
    Console.WriteLine($"Percorrendo com o for: {contador} - {listaString[contador]}");
}

//Percorrer a lista com foreach
int contadorForeach = 0;
foreach (string item in listaString)
{
    Console.WriteLine($"Percorrendo com o foreach°: {contadorForeach} - {item}");
    contadorForeach++;
}
*/






// int[] arrayInteiro = new int[4];

// arrayInteiro[0] = 72;
// arrayInteiro[1] = 64;
// arrayInteiro[2] = 50;
// arrayInteiro[3] = 1;

// int[] arrayInteiro2 = new int[arrayInteiro.Length * 2];
// Array.Copy(arrayInteiro, arrayInteiro2, arrayInteiro.Length); // arraysInteiros para arraysInteiros2 com a capacidade inteira (copia tudo) 
// Console.WriteLine(arrayInteiro2[2]);

// Array.Resize(ref arrayInteiro, arrayInteiro.Length * 2);  //Para alterar a capacidade de armazenamento do array podemos utilizar essa funcao

// Console.WriteLine("Percorrendo o array com o foreach");
// for (int contador = 0; contador < arrayInteiro.Length; contador++)  //enquanto contador = 0; contador for menor que arrayInteiro.LeiaOArray; incremente 1 no contador
// {
//   Console.WriteLine($"Posicao N°{contador} - {arrayInteiro[contador]}");
// }

// Console.WriteLine("Percorrendo o array com o foreach");

// foreach(int valor in arrayInteiro)  //Para cada elementos no valor de arrayInteiro {faca}
// {                                   //Foreach funciona apenas em listas e arrays
//   Console.WriteLine(valor);
// }








// string opcao;
// bool exibirMenu = true;

// while(exibirMenu)
// {
//   Console.Clear();
//   Console.WriteLine("Digite a sua opção:");
//   Console.WriteLine("1 - Cadastrar cliente");
//   Console.WriteLine("2 - Buscar cliente");
//   Console.WriteLine("3 - Apagar cliente");
//   Console.WriteLine("4 - Encerrar");

//   opcao = Console.ReadLine();


//   switch(opcao)
//   {
//     case "1":
//       Console.WriteLine("Cadastro de cliente");
//         break;

//     case "2":
//       Console.WriteLine("Busca de cliente");
//         break;

//     case "3":
//       Console.WriteLine("Apagar cliente");
//         break;

//     case "4":
//       Console.WriteLine("Encerrar");
//       //exibirMenu = true;   //Valida para sair do bloco while e switch para executar o que está fora dos blocos
//         //Environment.Exit(0);  //Para encerrar o loop
//         break;

//     default:
//       Console.WriteLine("Opção inválida");
//         break;
//   }
// }
// Console.WriteLine("O programa se encerrou.");














// int soma = 0, numero = 0;


// do
// {
//   Console.WriteLine("Digite um número (Digite 0 para parar.)");
//   numero = Convert.ToInt32(Console.ReadLine());
//   soma += numero;

// } while(numero != 0);
//   Console.WriteLine($"O numero que você digitou é: {soma}");






// int numero = 10;
// int contador = 1;

// while (contador <= numero){
//   Console.WriteLine($"{contador}° {numero} x {contador} = {numero*contador}");
//   contador++;

//   if (contador == 4){ //Para interromper o fluxo de execução 
//     break;
//   }
// }






// int numero = 5;


// for (int i = 0; i <= 10; i++){
//   Console.WriteLine($"{numero} x {i} = {numero*i}");
// }




// Calculadora calc = new Calculadora();
// // calc.Somar(10, 30);
// // calc.Subtracao(10, 50);
// // calc.Multiplicar(15, 45);
// // calc.Divisao(2, 2);
// // calc.Potencia(3, 3);
// // calc.Seno(30);
// // calc.Coseno(30);
// // calc.Tangente(30);
// calc.RaizQuadrada(9);





// int numero = 10;

// Console.WriteLine(numero);

// Console.WriteLine("Incrementando o 10");
// numero++;

// Console.WriteLine(numero);



// DateTime dataAtual = DateTime.Now.AddDays(5);   //Para mostrar a data ou horário configurado no pc ou servidor
// Console.WriteLine(dataAtual.ToString("dd/MM/yyyy HH:mm"));



// string apresentacao = "Olá, seja bem vindo";
// int quantidade = 1;
// double altura = 1.80;
// decimal preco = 1.80M;
// bool condicao = true;

// Console.WriteLine(apresentacao);
// Console.WriteLine("Valor da variável quantidade: " + quantidade);
// Console.WriteLine("Valor da variável altura: " + altura.ToString("0.00"));  //ToString é para representar o numero inteiro e quantos numeros decimais vai exibir
// Console.WriteLine("Valor da variável preco: " + preco);
// Console.WriteLine("Valor da variável condição: " +condicao);



// Pessoa pessoa1 = new Pessoa();     //setamos uma variável e chamamos a classe     //Exemplo de como seria = curso_dotnet.Models.Pessoa

// pessoa1.Nome = "Sergio";    
// pessoa1.Idade = 28;
// pessoa1.Apresentar();
