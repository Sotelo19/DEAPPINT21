using System;

namespace p04_pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
           string nombre, salida;
           int horas;
           float pago,pagobruto,impuesto,pagoneto;
           const float TASA=0.3f;
           Console.WriteLine("calculando el pago del trabajador\n");
           Console.WriteLine("dame tu nombre: "); nombre= Console.ReadLine();
           Console.WriteLine("horas trabajadas: "); horas= int.Parse(Console.ReadLine());
           Console.WriteLine("pago en horas: "); pago= float.Parse(Console.ReadLine());
           pagobruto= horas*pago;
           impuesto=pagobruto*TASA;
           pagoneto=pagobruto-impuesto;

           salida = $"el trabajador {nombre}. trabajo {horas}, con un pago de {pago} \n"+
           $"pago bruto: {pagobruto} \n impuesto: {impuesto}\n pago neto: {pagoneto}";

           Console.WriteLine(salida);
        }
    }
}
