using System;

namespace mis_ejercicios_ivelisse
{
    public class Ejercicio5
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 5 - Descuento por edad");
            Console.Write("Ingrese su edad: ");
            if (!int.TryParse(Console.ReadLine(), out int edad) || edad < 0) {
                Console.WriteLine("Edad inválida.");
                return;
            }

            bool aplicaDescuento;
            if (edad > 60) {
                aplicaDescuento = true;
            } else {
                aplicaDescuento = false;
            }

            if (aplicaDescuento) Console.WriteLine("¡Aplica descuento del 50%!");
            else Console.WriteLine("No aplica descuento.");

            // Switch
            switch (aplicaDescuento) {
                case true: Console.WriteLine("Switch: Se aplica la tarifa de la tercera edad."); break;
                case false: Console.WriteLine("Switch: Se aplica la tarifa regular."); break;
            }
        }
    }
}