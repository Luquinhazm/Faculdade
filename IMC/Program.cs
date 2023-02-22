// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Seu Peso: ");
        double peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Altura: ");
        double altura = double.Parse(Console.ReadLine());
        double imc = peso / (altura * altura);
        Console.WriteLine("IMC = {0:N1}", imc);
        if (imc < 20)
        {
            Console.WriteLine("Abaixo do Peso");
        }
        else if (imc < 25)
        {
            Console.WriteLine("Peso ideal");
        }
        else
        {
            Console.WriteLine("Acima do Peso");
        }
    }
}