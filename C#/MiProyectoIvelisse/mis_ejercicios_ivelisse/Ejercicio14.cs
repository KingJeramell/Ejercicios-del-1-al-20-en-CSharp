using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio14
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 14 - Conversión de calificaciones");
            Console.Write("Ingrese la calificación numérica (0-100): ");
            if (!int.TryParse(Console.ReadLine(), out int nota) || nota < 0 || nota > 100)
            {
                Console.WriteLine("Calificación fuera de rango (0-100).");
                return;
            }

            string letra;
            if (nota >= 90)
            {
                letra = "A";
            }
            else if (nota >= 80)
            {
                letra = "B";
            }
            else if (nota >= 70)
            {
                letra = "C";
            }
            else if (nota >= 60)
            {
                letra = "D";
            }
            else
            {
                letra = "F";
            }

            Console.WriteLine($"Calificación en letra: {letra}");

            // Switch
            switch (letra)
            {
                case "A": Console.WriteLine("Switch: Excelente rendimiento."); break;
                case "B": Console.WriteLine("Switch: Buen rendimiento."); break;
                case "C": Console.WriteLine("Switch: Rendimiento satisfactorio."); break;
                case "D": Console.WriteLine("Switch: Rendimiento mínimo."); break;
                case "F": Console.WriteLine("Switch: Rendimiento insuficiente."); break;
            }
        }
    }
}