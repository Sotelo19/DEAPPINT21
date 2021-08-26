using System;

namespace p03_areatriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            float labase, laaltura, elarea;
            labase=laaltura=elarea=0;
            Console.WriteLine("calculando el area de un triangulo\n");
            Console.WriteLine("dame la base: ");
            labase=float.Parse(Console.ReadLine());
            Console.Write("dame la altura: ");
            laaltura=float.Parse(Console.ReadLine());
            elarea=(labase*laaltura)/2;
            Console.WriteLine($"el area del triangulo es {elarea}");
        }
    }
}
