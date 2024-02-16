using System; 

class URI {

    static void Main(string[] args) { 
        Console.WriteLine("-------------------------------");
        Console.WriteLine("CALCULADORA DA ÁREA DO CÍRCULO!");
        Console.WriteLine("      Feito por Andrey");
        Console.WriteLine("-------------------------------");
        Console.WriteLine("");
        Console.Write("Digite o raio do círculo: ");
        Double Raio = Convert.ToDouble(Console.ReadLine());
        Double Pi = Math.PI;

        Double RaioII = Raio + Raio;
        Double Result = Pi * RaioII;

        Console.WriteLine("Área do círculo: "+ Math.Round(Result, 4));
    }
    
}
