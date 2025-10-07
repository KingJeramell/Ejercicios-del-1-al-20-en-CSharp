using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio10
    {
        public static void Ejecutar()
        { 
              Console.Clear();
            Console.WriteLine("Ejercicio 10 - Clasificación de ángulos");
            Console.Write("Ingrese el ángulo en grados (0-180): ");
            if (!double.TryParse(Console.ReadLine(), out double g))
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            string tipo;
            // Usamos Math.Abs y 1e-9 para manejar la comparación de punto flotante
            if (g < 0 || g > 180)
            {
                tipo = "Fuera de rango";
            }
            else if (Math.Abs(g - 180) < 1e-9)
            { // 180°
                tipo = "Llano";
            }
            else if (g > 90)
            { // > 90° y < 180°
                tipo = "Obtuso";
            }
            else if (Math.Abs(g - 90) < 1e-9)
            { // 90°
                tipo = "Recto";
            }
            else
            { // < 90°
                tipo = "Agudo";
            }

            Console.WriteLine($"El ángulo es: {tipo}");

            // Switch
            switch (tipo)
            {
                case "Agudo":
                case "Recto":
                case "Obtuso":
                case "Llano":
                    Console.WriteLine($"Switch: Ángulo clasificado con éxito.");
                    break;
                default:
                    Console.WriteLine("Switch: El ángulo no pertenece a la clasificación estándar o está fuera de rango.");
                    break;
            }
        }
    }
}