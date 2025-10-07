using System;
namespace mis_ejercicios_ivelisse
{
    public class Ejercicio19
    {
        public static void Ejecutar()
        {       
              Console.Clear();
            Console.WriteLine("Ejercicio 19 - Conversión de horas a turnos");
            Console.Write("Ingrese la hora (0-23): ");
            if (!int.TryParse(Console.ReadLine(), out int hora) || hora < 0 || hora > 23)
            {
                Console.WriteLine("Hora inválida o fuera de rango (0-23).");
                return;
            }

            string turno;
            if (hora >= 6 && hora <= 11)
            {
                turno = "Mañana";
            }
            else if (hora >= 12 && hora <= 17)
            {
                turno = "Tarde";
            }
            else if (hora >= 18 && hora <= 23)
            {
                turno = "Noche";
            }
            else
            { // 0 a 5
                turno = "Madrugada";
            }

            Console.WriteLine($"La hora {hora}:00 corresponde al turno de {turno}.");

            // Switch
            switch (hora)
            {
                case int h when h >= 6 && h <= 17:
                    Console.WriteLine("Switch: Es un turno diurno (día).");
                    break;
                default:
                    Console.WriteLine("Switch: Es un turno nocturno (noche).");
                    break;
            }
        }
    }
}