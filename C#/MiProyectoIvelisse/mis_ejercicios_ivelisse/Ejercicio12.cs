using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio12
    {
        public static void Ejecutar()
        {
              Console.Clear();
             Console.WriteLine("Ejercicio 12 - Clasificación de tres números");
            Console.Write("Ingrese N1: "); if (!double.TryParse(Console.ReadLine(), out double n1)) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Ingrese N2: "); if (!double.TryParse(Console.ReadLine(), out double n2)) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Ingrese N3: "); if (!double.TryParse(Console.ReadLine(), out double n3)) { Console.WriteLine("Entrada inválida."); return; }

            string clasificacion;

            bool hayCero = (n1 == 0 || n2 == 0 || n3 == 0);
            bool todosPositivos = (n1 > 0 && n2 > 0 && n3 > 0);
            bool todosNegativos = (n1 < 0 && n2 < 0 && n3 < 0);

            if (hayCero)
            {
                clasificacion = "Contiene uno o más ceros";
            }
            else if (todosPositivos)
            {
                clasificacion = "Todos son positivos";
            }
            else if (todosNegativos)
            {
                clasificacion = "Todos son negativos";
            }
            else
            {
                clasificacion = "Mixtos (positivos y negativos)";
            }

            Console.WriteLine($"Clasificación: {clasificacion}");

            // Switch (usando booleanos como base)
            switch (clasificacion)
            {
                case "Todos son positivos":
                case "Todos son negativos":
                    Console.WriteLine("Switch: Los números tienen el mismo signo.");
                    break;
                default:
                    Console.WriteLine("Switch: Hay una mezcla de signos o ceros.");
                    break;
            }
        }
    }
}