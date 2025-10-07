using System; 
namespace mis_ejercicios_ivelisse
 {
    public class Ejercicio1
    { public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 1 - Número positivo, negativo o cero");
            Console.Write("Ingrese un número: ");
            if (!double.TryParse(Console.ReadLine(), out double n)) { Console.WriteLine("Entrada inválida."); return; }

            string resultado;
            if (n > 0) {
                resultado = "Positivo";
            } else if (n < 0) {
                resultado = "Negativo";
            } else {
                resultado = "Cero";
            }

            Console.WriteLine($"Resultado: {resultado}");

            // Switch
            switch (resultado) {
                case "Positivo": Console.WriteLine("Switch: El número es mayor que 0."); break;
                case "Negativo": Console.WriteLine("Switch: El número es menor que 0."); break;
                default: Console.WriteLine("Switch: El número es exactamente 0."); break;
            }
        }
    }
}