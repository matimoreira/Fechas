using System;

namespace Fechas
{
    class Program
    {
        static void Main(string[] args)
        {
            var fecha1 = new DateTime();
            var fecha2 = new DateTime();
            int diferenciaSemanas = 0, diferenciaDias= 0;

            Console.Write("Ingresar una fecha: ");
            fecha1 = DateTime.Parse(Console.ReadLine());
            Console.Write("Ingresar otra fecha: ");
            fecha2 = DateTime.Parse(Console.ReadLine());

            Console.WriteLine(fecha2.ToString("dddd, dd MMMM yyyy"));
            Console.WriteLine(fecha1.ToString("dddd, dd MMMM yyyy"));
            if (DateTime.Compare(fecha1, fecha2) < 0)
            {
                diferenciaDias = fecha2.Subtract(fecha1).Days;
            }
            else
            {
                diferenciaDias = fecha1.Subtract(fecha2).Days;
            } ;
            
            diferenciaSemanas = diferenciaDias / 7;
            Console.WriteLine("Diferencia en dias: " + diferenciaDias.ToString());
            Console.WriteLine("Diferencia en semanas: " + diferenciaSemanas.ToString());
            
        }
    }
}
