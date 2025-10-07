using System;

namespace mis_ejercicios_ivelisse
{
    public class Ejercicio6
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 6 - Calificación aprobatoria");
            Console.Write("Ingrese la calificación (0-100): ");
            if (!double.TryParse(Console.ReadLine(), out double nota) || nota < 0 || nota > 100)
            {
                Console.WriteLine("Entrada inválida o fuera de rango (0-100).");
                return;
            }

            string estado;
            if (nota >= 60)
            {
                estado = "Aprobado";
            }
            else
            {
                estado = "Reprobado";
            }

            Console.WriteLine(estado);

            // Switch
            switch (estado)
            {
                case "Aprobado": Console.WriteLine("Switch: Puedes pasar a la siguiente materia."); break;
                case "Reprobado": Console.WriteLine("Switch: Debes tomar el examen de recuperación."); break;
            }
        }
    }
}