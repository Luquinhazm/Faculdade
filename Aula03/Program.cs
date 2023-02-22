using System;

class ProgramIdade
{
    static void Main(string[] args)
    {
        Console.Write("Olá Digite sua idade em Anos = ");
        int anos = int.Parse(Console.ReadLine());
        Console.Write("Agora digite sua idade em Meses = ");
        int meses = int.Parse(Console.ReadLine());
        Console.Write("Por ultimo digite os Dias:");
        int dias = int.Parse(Console.ReadLine());
        int idadeDias = anos * 365 +meses * + dias;
        Console.WriteLine("idade em dias = {0}", idadeDias);
    }
}