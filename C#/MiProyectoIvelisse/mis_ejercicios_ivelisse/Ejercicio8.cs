using System;

namespace mis_ejercicios_ivelisse
{
    public class Ejercicio8
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 8 - Número mayor entre dos");
            Console.Write("Ingrese el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1)) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Ingrese el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2)) { Console.WriteLine("Entrada inválida."); return; }

            string resultado;
            if (num1 > num2) {
                resultado = $"El número {num1} es mayor que {num2}.";
            } else if (num2 > num1) {
                resultado = $"El número {num2} es mayor que {num1}.";
            } else {
                resultado = "Los números son iguales.";
            }

            Console.WriteLine(resultado);

            // Switch (usando etiquetas para clasificar la comparación)
            int comparacion = num1.CompareTo(num2); // -1 si num1 < num2, 0 si son iguales, 1 si num1 > num2
            switch (comparacion) {
                case 1: Console.WriteLine("Switch: El primer número es dominante."); break;
                case -1: Console.WriteLine("Switch: El segundo número es dominante."); break;
                case 0: Console.WriteLine("Switch: Hay un empate."); break;
            }
        }
    }
}