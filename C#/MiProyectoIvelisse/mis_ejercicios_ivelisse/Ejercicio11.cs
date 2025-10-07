using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio11
    {
        public static void Ejecutar()
        {
              Console.Clear();
            Console.WriteLine("Ejercicio 11 - Cálculo de impuestos");
            Console.Write("Ingrese su salario mensual: ");
            if (!double.TryParse(Console.ReadLine(), out double salario) || salario < 0)
            {
                Console.WriteLine("Entrada inválida.");
                return;
            }

            double tasaImpuesto;
            if (salario < 10000)
            {
                tasaImpuesto = 0.0;
            }
            else if (salario >= 10000 && salario <= 30000)
            {
                tasaImpuesto = 0.10;
            }
            else
            { // Más de 30,000
                tasaImpuesto = 0.20;
            }

            double impuesto = salario * tasaImpuesto;
            Console.WriteLine($"Tasa de Impuesto aplicada: {tasaImpuesto * 100}%");
            Console.WriteLine($"Impuesto a pagar: {impuesto:C}");
            Console.WriteLine($"Salario neto estimado: {(salario - impuesto):C}");

            // Switch (usando patrón de rango)
            string categoria;
            switch (salario)
            {
                case double s when s < 10000:
                    categoria = "Baja";
                    break;
                case double s when s <= 30000:
                    categoria = "Media";
                    break;
                default:
                    categoria = "Alta";
                    break;
            }
            Console.WriteLine($"Switch: Categoría salarial - {categoria}");
        }
    }
}