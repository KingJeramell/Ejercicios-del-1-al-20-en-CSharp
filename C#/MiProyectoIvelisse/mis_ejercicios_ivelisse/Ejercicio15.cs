using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio15
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 15 - Comparación de tres longitudes (Triángulo)");
            Console.Write("Lado A: "); if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Lado B: "); if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Lado C: "); if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0) { Console.WriteLine("Entrada inválida."); return; }

            string resultado;
            // Para formar un triángulo, la suma de dos lados debe ser mayor que el tercero.
            if (a + b > c && a + c > b && b + c > a)
            {
                resultado = "Sí pueden formar un triángulo.";
            }
            else
            {
                resultado = "No pueden formar un triángulo.";
            }

            Console.WriteLine(resultado);

            // Switch
            bool puedeFormar = a + b > c && a + c > b && b + c > a;
            switch (puedeFormar)
            {
                case true: Console.WriteLine("Switch: La desigualdad triangular se cumple."); break;
                case false: Console.WriteLine("Switch: La desigualdad triangular no se cumple."); break;
            }
        }
    }
}