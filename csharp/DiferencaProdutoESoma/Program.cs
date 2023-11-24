// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


public class DIO {
        
static void Main(string[] args){

        int numeroDeEntrada = int.Parse(Console.ReadLine());
        int multiplicacao = 1, soma = 1;

        while (numeroDeEntrada > 0){
             int temp = numeroDeEntrada % 10;
             multiplicacao *= temp;
             soma += temp;
            numeroDeEntrada = numeroDeEntrada / 10 ;
           }
           int diferenca = multiplicacao - soma;

           Console.WriteLine(diferenca);
        }
    }
