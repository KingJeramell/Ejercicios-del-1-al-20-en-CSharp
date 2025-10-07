
using System;

namespace mis_ejercicios_ivelisse
 {
    public class Ejercicio2
    { public static void Ejecutar()
        {
            Console.Clear();
            Console.WriteLine("Ejercicio 2 - Par o impar");
            Console.Write("Ingrese un número entero: ");
            if (!long.TryParse(Console.ReadLine(), out long n)) { Console.WriteLine("Entrada inválida."); return; }

            string resultado;
            if (n % 2 == 0) {
                resultado = "Par";
            } else {
                resultado = "Impar";
            }

            Console.WriteLine($"El número es: {resultado}");

            // Switch
            switch (resultado) {
                case "Par": Console.WriteLine("Switch: Es divisible por 2."); break;
                case "Impar": Console.WriteLine("Switch: No es divisible por 2."); break;
            }
        }
    }
 }