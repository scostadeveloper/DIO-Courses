
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











// See https://aka.ms/new-console-template for more information

//     int qt = int.Parse(Console.ReadLine());
// int a = 0;
// int b = 1;
//     for (int i = 0; i < 1000; i++)
//     {
//         qt = [1];
//     }
//     Console.WriteLine(a);
//     Console.WriteLine(b);



//     List<string> listaString = new List<string>();

// listaString.Add(Console.ReadLine());

// //Percorrer a lista com for
// for (int contador = 0; contador < listaString.Count; contador++){
//     Console.WriteLine($"Percorrendo com o for: {contador}");
// }

// //Percorrer a lista com foreach
// int contadorForeach = 0;
// foreach (string item in listaString)
// {
//     Console.WriteLine($"Percorrendo com o foreach°: {contadorForeach} - {item}");
//     contadorForeach++;
// }