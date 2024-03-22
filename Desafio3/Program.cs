namespace DesafioRocketseat;

public class Desafio3
{
    static void Main()
    {
        Console.WriteLine("Qual o primeiro valor?");
        string inpuValor1 = Console.ReadLine();
        double valor1;
        double.TryParse(inpuValor1, out valor1);

        Console.WriteLine("Qual o segundo valor?");
        string inputValor2 = Console.ReadLine();
        double valor2;
        double.TryParse(inputValor2, out valor2);



        //double valor1 = 600;
        //double valor2 = 322;
        double soma = valor1 + valor2;
        Console.WriteLine("Os valores somados resultaram em:" + " " + soma);

        double subtracao = valor1 - valor2;
        Console.WriteLine("Os valores subtraídos resultaram em:" + " " + subtracao);

        double multiplicacao = valor1 * valor2;
        Console.WriteLine("Os valores multiplicados resultaram em:" + " " + multiplicacao);

        double divisao = valor1 / valor2;
        if (valor2 == 0)
        {
            Console.WriteLine("O segundo valor da divisão é 0");
        }
        else
        Console.WriteLine("Os valores divididos resultaram em" + " " +  divisao);

        double media = valor1 + valor2;
        media = media / 2;
        Console.WriteLine("A média entre os dois valores é:" + " " + media);
    }
}