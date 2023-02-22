using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Salário; ");
        double salario = double.Parse(Console.ReadLine());
        double salarioReajustado;
        if (salario <= 300)
        {
            salarioReajustado = salario * 1.15;
        }
        else
        {
            salarioReajustado = salario * 1.075;
        }
        Console.WriteLine("novo salario = R$ {0:N2}", salarioReajustado);
    }
}