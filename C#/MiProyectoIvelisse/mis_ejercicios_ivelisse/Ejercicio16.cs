using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio16
    {
        public static void Ejecutar()
        {           
              Console.Clear(); 
            Console.WriteLine("Ejercicio 16 - Calculadora de descuentos");
            Console.Write("Ingrese el precio del producto: $");
            if (!double.TryParse(Console.ReadLine(), out double precio) || precio < 0)
            {
                Console.WriteLine("Precio inválido.");
                return;
            }

            double descuento;
            if (precio < 50)
            {
                descuento = 0.0; // Sin descuento
            }
            else if (precio >= 50 && precio <= 100)
            {
                descuento = 0.05; // 5%
            }
            else
            { // Más de $100
                descuento = 0.10; // 10%
            }

            double precioFinal = precio * (1 - descuento);

            Console.WriteLine($"Descuento aplicado: {descuento * 100}%");
            Console.WriteLine($"Precio final: {precioFinal:C}");

            // Switch (usando rango para mostrar la categoría)
            string categoria;
            switch (precio)
            {
                case double p when p < 50:
                    categoria = "Monto bajo";
                    break;
                case double p when p <= 100:
                    categoria = "Monto medio";
                    break;
                default:
                    categoria = "Monto alto";
                    break;
            }
            Console.WriteLine($"Switch: La compra está en la categoría de {categoria}.");
        }
    }
}