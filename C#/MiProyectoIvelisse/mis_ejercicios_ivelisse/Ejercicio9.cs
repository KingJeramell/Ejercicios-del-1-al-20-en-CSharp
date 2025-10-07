using System;

namespace mis_ejercicios_ivelisse
{
    public class Ejercicio9
    {
        public static void Ejecutar()

        {
              Console.Clear();
            Console.WriteLine("Ejercicio 9 - Mayor entre tres números");
            Console.Write("Ingrese A: "); if (!double.TryParse(Console.ReadLine(), out double a)) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Ingrese B: "); if (!double.TryParse(Console.ReadLine(), out double b)) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Ingrese C: "); if (!double.TryParse(Console.ReadLine(), out double c)) { Console.WriteLine("Entrada inválida."); return; }

            double mayor;
            if (a >= b && a >= c)
            {
                mayor = a;
            }
            else if (b >= c)
            {
                mayor = b;
            }
            else
            {
                mayor = c;
            }

            Console.WriteLine($"El número mayor es: {mayor}");

            // Switch (usando la función de Math.Max anidada, que simplifica el if/else)
            double mayorSwitch = Math.Max(a, Math.Max(b, c));

            switch (mayorSwitch)
            {
                case double result when result == a && result != b && result != c:
                    Console.WriteLine("Switch: El mayor es A.");
                    break;
                case double result when result == b && result != a && result != c:
                    Console.WriteLine("Switch: El mayor es B.");
                    break;
                case double result when result == c && result != a && result != b:
                    Console.WriteLine("Switch: El mayor es C.");
                    break;
                default:
                    Console.WriteLine("Switch: Hay un empate entre dos o tres números.");
                    break;
            }
        }
    }
}
