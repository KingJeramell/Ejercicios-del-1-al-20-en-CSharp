using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio13
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 13 - Verificación de año bisiesto");
            Console.Write("Ingrese un año: ");
            if (!int.TryParse(Console.ReadLine(), out int year) || year < 1)
            {
                Console.WriteLine("Año inválido.");
                return;
            }

            string resultado;
            // Lógica de año bisiesto: (Divisible por 4 Y no por 100) O (Divisible por 400)
            bool esBisiesto = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

            if (esBisiesto)
            {
                resultado = "Es un año bisiesto";
            }
            else
            {
                resultado = "No es un año bisiesto";
            }

            Console.WriteLine(resultado);

            // Switch
            switch (esBisiesto)
            {
                case true: Console.WriteLine("Switch: El año tiene 366 días."); break;
                case false: Console.WriteLine("Switch: El año tiene 365 días."); break;
            }
        }
    }
}