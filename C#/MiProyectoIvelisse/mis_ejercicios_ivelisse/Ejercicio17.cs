using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio17
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 17 - Tipo de triángulo");
            Console.Write("Lado A: "); if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Lado B: "); if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Lado C: "); if (!double.TryParse(Console.ReadLine(), out double c) || c <= 0) { Console.WriteLine("Entrada inválida."); return; }

            string tipo;
            if (!(a + b > c && a + c > b && b + c > a))
            {
                tipo = "No es un triángulo válido.";
            }
            else if (Math.Abs(a - b) < 1e-9 && Math.Abs(b - c) < 1e-9)
            {
                tipo = "Equilátero (3 lados iguales)";
            }
            else if (Math.Abs(a - b) < 1e-9 || Math.Abs(a - c) < 1e-9 || Math.Abs(b - c) < 1e-9)
            {
                tipo = "Isósceles (2 lados iguales)";
            }
            else
            {
                tipo = "Escaleno (Ningún lado igual)";
            }

            Console.WriteLine($"El triángulo es: {tipo}");

            // Switch
            switch (tipo)
            {
                case "Equilátero (3 lados iguales)":
                case "Isósceles (2 lados iguales)":
                case "Escaleno (Ningún lado igual)":
                    Console.WriteLine($"Switch: El triángulo es clasificado por sus lados.");
                    break;
                default:
                    Console.WriteLine("Switch: Falló la verificación triangular.");
                    break;
            }
        }
    }
}