using System;

namespace mis_ejercicios_ivelisse
{
    public class Ejercicio7
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 7 - Día de la semana");
            Console.Write("Ingrese un número del 1 al 7 (1 es Lunes): ");
            if (!int.TryParse(Console.ReadLine(), out int d) || d < 1 || d > 7)
            {
                Console.WriteLine("Entrada inválida o fuera de rango.");
                return;
            }

            string dia;
            // If/Else If para determinar el día
            if (d == 1) { dia = "Lunes"; }
            else if (d == 2) { dia = "Martes"; }
            else if (d == 3) { dia = "Miércoles"; }
            else if (d == 4) { dia = "Jueves"; }
            else if (d == 5) { dia = "Viernes"; }
            else if (d == 6) { dia = "Sábado"; }
            else { dia = "Domingo"; }

            Console.WriteLine($"El día es: {dia}");

            // Switch para clasificar
            switch (d)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("Switch: Es un día laborable.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Switch: Es fin de semana.");
                    break;
            }
        }
    }
}