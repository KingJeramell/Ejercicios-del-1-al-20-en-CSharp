using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio18
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 18 - Evaluación de temperatura");
            Console.Write("Ingrese la temperatura en Celsius (°C): ");
            if (!double.TryParse(Console.ReadLine(), out double temp))
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            string mensaje;
            if (temp < 0)
            {
                mensaje = "Hace mucho frío. Alerta de congelamiento.";
            }
            else if (temp <= 20)
            {
                mensaje = "Clima fresco. Ideal para actividades ligeras.";
            }
            else if (temp <= 30)
            {
                mensaje = "Clima agradable. Típico día de verano.";
            }
            else
            { // Más de 30°C
                mensaje = "Hace mucho calor. Hidratarse es vital.";
            }

            Console.WriteLine(mensaje);

            // Switch (usando patrón de rango)
            string categoria;
            switch (temp)
            {
                case double t when t <= 0:
                    categoria = "Frío Extremo";
                    break;
                case double t when t <= 30:
                    categoria = "Templado";
                    break;
                default:
                    categoria = "Calor Extremo";
                    break;
            }
            Console.WriteLine($"Switch: La categoría del clima es {categoria}.");
        }
    }
}