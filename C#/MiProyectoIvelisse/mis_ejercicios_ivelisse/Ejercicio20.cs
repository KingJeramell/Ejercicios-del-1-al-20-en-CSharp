using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio20
    {
        public static void Ejecutar()
        {     
              Console.Clear();    
            Console.WriteLine("Ejercicio 20 - Clasificación de IMC");
            Console.Write("Ingrese el peso en kilogramos (kg): ");
            if (!double.TryParse(Console.ReadLine(), out double peso) || peso <= 0) { Console.WriteLine("Entrada inválida."); return; }
            Console.Write("Ingrese la altura en metros (m): ");
            if (!double.TryParse(Console.ReadLine(), out double altura) || altura <= 0) { Console.WriteLine("Entrada inválida."); return; }

            double imc = peso / (altura * altura);
            Console.WriteLine($"Su Índice de Masa Corporal (IMC) es: {imc:F2}");

            string clasificacion;
            if (imc < 18.5) {
                clasificacion = "Bajo peso";
            } else if (imc <= 24.9) {
                clasificacion = "Normal";
            } else if (imc <= 29.9) {
                clasificacion = "Sobrepeso";
            } else { // 30 o más
                clasificacion = "Obesidad";
            }

            Console.WriteLine($"Clasificación: {clasificacion}");

            // Switch
            switch (clasificacion) {
                case "Bajo peso":
                case "Sobrepeso":
                case "Obesidad":
                    Console.WriteLine("Switch: Es recomendable revisar la dieta y la actividad física.");
                    break;
                case "Normal":
                    Console.WriteLine("Switch: ¡El peso es saludable!");
                    break;
            }
        }
    }
}