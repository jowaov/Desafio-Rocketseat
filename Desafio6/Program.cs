namespace DesafioRocketseat;

public class Desafio6
{
    static void Main()
    {
        Console.WriteLine("Escolha o formato da data e hora:");
        Console.WriteLine("1 - Formato Completo");
        Console.WriteLine("2 - Data (dd/mm/aaaa)");
        Console.WriteLine("3 - Hora (24 horas)");
        Console.WriteLine("4 - Data com mês por extenso");

        int opcao = int.Parse(Console.ReadLine());

        switch (opcao)
        {
        case 1:
            Console.WriteLine(DateTime.Now.ToString("F"));
            break;

        case 2:
            Console.WriteLine(DateTime.Now.ToString("d"));
            break;

        case 3:
            Console.WriteLine(DateTime.Now.ToString("t"));
            break;

        case 4:
            Console.WriteLine(DateTime.Now.ToString("dd MMMM yyyy"));
            break;
        }
    }
};