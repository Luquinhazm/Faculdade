using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("digite a sua velocidade");
        int velocidade = int.Parse(Console.ReadLine());
        if (velocidade > 70)
        {
            Console.Write("multado");
        }
        else
        {
            Console.Write("Muito Bem. Voccê está no limte de velocidade");
        }
    }
}