using System.Numerics;

namespace DesafioRocketseat;

public class Desafio5
{
    static void Main()
    {
        string placa;
        bool validadeLetras = false;
        bool validadeNumeros = false;

        do
        {
            Console.WriteLine("Digite sua placa, exemplo: ABC1234");
            Console.Write("Placa: ");
            placa = Console.ReadLine();

            if (placa.Length < 7 || placa.Length > 7)
            {
                Console.WriteLine("Placa inválida!");
            }
        } 
        while (placa.Length < 7 || placa.Length > 7);

        for (int i = 0; i < 3; i++)
        {
            if (Char.IsLetter(placa[i]))
            {
                validadeLetras = true;
            }
            else
                validadeLetras = false;
        }

        for (int i = 3; i < 7; i++)
        {
            if (Char.IsNumber(placa[i]))
            {
                validadeNumeros = true;
            }
            else
                validadeNumeros = false;
        }

        if (validadeLetras == true && validadeNumeros == true)
        {
            Console.WriteLine("Sua placa é válida!");
        }
        else
        {
            Console.WriteLine("Sua placa é inválida!");
        }
    }
}