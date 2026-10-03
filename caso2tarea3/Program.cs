using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caso2tarea3
{
    internal class Program
    {
        // Variables globales
        static int precio = 0;
        static int cantidad = 0;

    
        // Calcula el 10% de descuento si el subtotal es mas de ₡25 000
        static int calculardescuento(int subtotal)
        {
            if (subtotal > 25000)
            {
                return (subtotal * 10) / 100;
            }
            return 0;
        }

        //Esto es funcion para procesar la compra, calcular el subtotal, descuento y total a pagar
        static void procesarcompra()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("=======================================");
            Console.WriteLine("         PRECIO DE UNA COMPRA                                                                     :) ");
            Console.WriteLine("=======================================");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Ingrese el precio del producto: ");
            precio = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la cantidad a comprar: ");
            cantidad = int.Parse(Console.ReadLine());

            // Validación de valores mayores a cero
            if (precio <= 0 || cantidad <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: El precio y la cantidad deben ser mayores a cero.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                int subtotal = precio * cantidad;

                // Llamada a la función con retorno y parámetro
                int descuento = calculardescuento(subtotal);
                int totalPagar = subtotal - descuento;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("------ Última Linea ------");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" Subtotal:       {subtotal}");

                if (descuento > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($" Descuento(10%): -{descuento}");
                }
                else
                {
                    Console.WriteLine(" Descuento: 0 ");
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($" Total a Pagar: {totalPagar}");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("-----------------------------------");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }

        //Salida del programa, retorna un mensaje de despedida
        static string salida()
        {
            return "Gracias por usar el programa";
        }

        static void menu()
        {
            int opcion = 0;
            //do while para que el menu se repita hasta que el usuario elija salir
            do
            {
                Console.WriteLine("--- MENÚ ---");
                Console.WriteLine("1. Calcular Compra");
                Console.WriteLine("2. Salir");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Ingrese una opción: ");
                opcion = int.Parse(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.White;
                // Validación de la opción ingresada
                switch (opcion)
                {
                    case 1:
                        procesarcompra();
                        break;
                    case 2:
                        string mensaje = salida();
                        Console.WriteLine(mensaje);
                        break;
                    default:
                        Console.WriteLine("Opción inválida, inténtalo de nuevo.");
                        break;
                }

            } while (opcion != 2);
        }
        // Función principal, aquí se llama al menú
        static void Main(string[] args)
        {
            menu();
        }
    }
}