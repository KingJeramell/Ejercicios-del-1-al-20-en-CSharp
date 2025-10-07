using System;

namespace mis_ejercicios_ivelisse
{
    public class Ejercicio4
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 4 - Múltiplo de 5");
            Console.Write("Ingrese un número: ");
            if (!double.TryParse(Console.ReadLine(), out double n)) { Console.WriteLine("Entrada inválida."); return; }

            string resultado;
            if (n % 5 == 0)
            {
                resultado = "Es múltiplo de 5";
            }
            else
            {
                resultado = "No es múltiplo de 5";
            }

            Console.WriteLine(resultado);

            // Switch
            switch (resultado)
            {
                case "Es múltiplo de 5": Console.WriteLine("Switch: Divisible por 5."); break;
                default: Console.WriteLine("Switch: No divisible por 5."); break;
            }
        }
    }
}