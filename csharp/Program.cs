using csharp.Models;



//MENU INTERATIVO

string opcao;
bool exibirMenu = true;

while (exibirMenu)
{
    Console.Clear();
    Console.WriteLine("Digite a sua opção:");
    Console.WriteLine("1 - Cadastrar cliente");
    Console.WriteLine("2 - Buscar cliente");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar");


opcao = Console.ReadLine();

switch (opcao)
{
    case "1":
        Console.WriteLine("Cadastro de cliente");
        break;
    case "2":
        Console.WriteLine("Busca de cliente");
        break;
    case "3":
        Console.WriteLine("Apagar cliente");
        break;
    case "4":
        Console.WriteLine("Encerrar");
            exibirMenu = false;
        break;
    default:
    Console.WriteLine("Opção invalida");
        break;
 }
}




























// for (int contador = 0; contador <= 20; contador++)
// {
//     Console.WriteLine(contador);
// }

// int numero = 5;
// int contador = 0;
// int auxiliar = 0;

// while (contador <= 10)
// {
//     Console.WriteLine($"{contador}° execução: {numero} x {contador} = {numero * contador}");
//     contador++;
// }

// int soma = 0, numero = 0;


// do
// {
//     Console.WriteLine("Digite um numero: ");
//     numero = Convert.ToInt32(Console.ReadLine());

//     soma += numero;

// } while (numero != 0);

// Console.WriteLine($"Total da soma dos numeros digitados é: {soma}");





















// Pessoa pessoa1 = new Pessoa();  //Instanciamento da classe Pessoa

// //Atribuindo valores aos atributos da classe Pessoa
// pessoa1.Nome = "Sergio Costa";
// pessoa1.Idade = 28;
// pessoa1.Apresentar();


// Console.WriteLine("Digite uma letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("É uma vogal");
//         break;

//     default:
//         Console.WriteLine("Não é uma vogal");
//         break;
// }