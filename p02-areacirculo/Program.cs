using System;

namespace p02_areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double area=0;
            float radio=0;
            Console.WriteLine("Calcular e area de un circulo");
            Console.WriteLine("dame el radio?");
            radio= float.Parse (Console.ReadLine());
            area=Math.PI*Math.Pow(radio,2);
            Console.WriteLine($"el area del circulo es {area}");

        }
    }
}
