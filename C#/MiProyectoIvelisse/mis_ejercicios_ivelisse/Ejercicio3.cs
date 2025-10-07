using System;

namespace mis_ejercicios_ivelisse
 {
    public class Ejercicio3
    { public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 3 - Mayor de edad");
            Console.Write("Ingrese la edad: ");
            if (!int.TryParse(Console.ReadLine(), out int edad) || edad < 0) {
                Console.WriteLine("Entrada inválida o edad negativa.");
                return;
            }

            string resultado;
            if (edad >= 18) {
                resultado = "Mayor de edad";
            } else {
                resultado = "Menor de edad";
            }

            Console.WriteLine(resultado);

            // Switch
            switch (resultado) {
                case "Mayor de edad": Console.WriteLine("Switch: Puede realizar trámites legales."); break;
                case "Menor de edad": Console.WriteLine("Switch: Requiere acompañamiento de un adulto."); break;
            }
        }

    }
 }