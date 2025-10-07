using System;
using mis_ejercicios_ivelisse;

namespace ProyectoJeramell
{
    class Launcher
    {
        static void Main()
        {
            int opcion = -1;

            do
            {
                try
                {
                    Console.Clear();
                    MostrarEncabezado();

                    // Mostrar opciones
                    for (int i = 1; i <= 20; i++)
                        Console.WriteLine($"{i}. Ejecutar Ejercicio {i}");

                    Console.WriteLine("\n0. Finalizar programa");
                    Console.Write("\n👉 Elija una opción: ");

                    // Validar entrada numérica
                    if (!int.TryParse(Console.ReadLine(), out opcion))
                    {
                        MostrarError("Entrada no válida. Ingrese un número del menú.");
                        continue;
                    }

                    if (opcion == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("\n👋 ¡Gracias por usar el programa! Hasta luego.");
                        Console.ResetColor();
                        break;
                    }

                    // 🔹 Limpiar la consola antes de ejecutar el ejercicio
                    Console.Clear();

                    // Ejecutar el ejercicio seleccionado
                    EjecutarEjercicio(opcion);

                    Console.WriteLine("\nPresione cualquier tecla para regresar al menú...");
                    Console.ReadKey(true);
                }
                catch (Exception ex)
                {
                    MostrarError($"Ocurrió un error: {ex.Message}");
                }

            } while (opcion != 0);
        }

        // 🔹 Método para mostrar encabezado
        static void MostrarEncabezado()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("╔════════════════════════════════════════╗");
            Console.WriteLine("║     MENÚ PRINCIPAL - EJERCICIOS 💻     ║");
            Console.WriteLine("╚════════════════════════════════════════╝\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Hecho por: Jeramell Jose Feliz Ulloa\n");
            Console.ResetColor();
        }

        // 🔹 Método para ejecutar el ejercicio según la opción
        static void EjecutarEjercicio(int opcion)
        {
            switch (opcion)
            {
                case 1: Ejercicio1.Ejecutar(); break;
                case 2: Ejercicio2.Ejecutar(); break;
                case 3: Ejercicio3.Ejecutar(); break;
                case 4: Ejercicio4.Ejecutar(); break;
                case 5: Ejercicio5.Ejecutar(); break;
                case 6: Ejercicio6.Ejecutar(); break;
                case 7: Ejercicio7.Ejecutar(); break;
                case 8: Ejercicio8.Ejecutar(); break;
                case 9: Ejercicio9.Ejecutar(); break;
                case 10: Ejercicio10.Ejecutar(); break;
                case 11: Ejercicio11.Ejecutar(); break;
                case 12: Ejercicio12.Ejecutar(); break;
                case 13: Ejercicio13.Ejecutar(); break;
                case 14: Ejercicio14.Ejecutar(); break;
                case 15: Ejercicio15.Ejecutar(); break;
                case 16: Ejercicio16.Ejecutar(); break;
                case 17: Ejercicio17.Ejecutar(); break;
                case 18: Ejercicio18.Ejecutar(); break;
                case 19: Ejercicio19.Ejecutar(); break;
                case 20: Ejercicio20.Ejecutar(); break;
                default: MostrarError("Opción fuera de rango. Intente nuevamente."); break;
            }
        }

        // 🔹 Método auxiliar para mostrar errores con color
        static void MostrarError(string mensaje)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\n❌ {mensaje}");
            Console.ResetColor();
            Console.WriteLine("\nPresione cualquier tecla para continuar...");
            Console.ReadKey(true);
        }
    }
}
