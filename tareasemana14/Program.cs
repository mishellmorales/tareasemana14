using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaSemana14;

namespace Ejemplo_de_arbol_binario
{
    // Clase principal del programa
    class Program
    {
        static void Main()
        {
            ArbolBinario arbol = new ArbolBinario();  // Crea una instancia del árbol binario
            bool salir = false;  // Variable para controlar cuándo salir del bucle del menú

            // Bucle para mostrar el menú hasta que el usuario elija salir
            while (!salir)
            {
                // Mostrar menú de opciones
                Console.WriteLine("..................................");
                Console.WriteLine("   Menú de Árbol Binario:  ");
                Console.WriteLine("1. Ingese el valor");
                Console.WriteLine("2. Buscar valor");
                Console.WriteLine("3. Mostrar recorrido Inorden");
                Console.WriteLine("4. Mostrar recorrido Preorden");
                Console.WriteLine("5. Mostrar recorrido Postorden");
                Console.WriteLine("6. Salir");
                Console.WriteLine("....................................");
                Console.Write("Seleccione una opción:   ");  // Solicita una opción al usuario
                string opcion = Console.ReadLine();  // Captura la opción ingresada

                // Evalúa la opción seleccionada por el usuario
                switch (opcion)
                {
                    case "1":  // Caso para insertar un valor en el árbol
                        Console.Write("Ingrese un valor a insertar: ");  // Solicita al usuario que ingrese un valor
                        int valorInsertar = int.Parse(Console.ReadLine());  // Convierte la entrada de texto a un número entero
                        arbol.Insertar(valorInsertar);  // Inserta el valor en el árbol
                        Console.WriteLine("Valor insertado.");  // Informa al usuario que el valor fue insertado
                        break;

                    case "2":  // Caso para buscar un valor en el árbol
                        Console.Write("Ingrese el valor a buscar: ");  // Solicita el valor a buscar
                        int valorBuscar = int.Parse(Console.ReadLine());  // Convierte la entrada de texto a un número entero
                        if (arbol.Buscar(valorBuscar))  // Llama al método para buscar el valor en el árbol
                            Console.WriteLine("Valor encontrado.");  // Si lo encuentra, muestra un mensaje
                        else
                            Console.WriteLine("Valor no encontrado.");  // Si no lo encuentra, muestra otro mensaje
                        break;

                    case "3":  // Caso para mostrar el recorrido inorden
                        Console.WriteLine("Recorrido Inorden:");  // Imprime el título del recorrido
                        arbol.Inorden();  // Llama al método para mostrar el recorrido inorden
                        Console.WriteLine();  // Salto de línea para mejor presentación
                        break;

                    case "4":  // Caso para mostrar el recorrido preorden
                        Console.WriteLine("Recorrido Preorden:");  // Imprime el título del recorrido
                        arbol.Preorden();  // Llama al método para mostrar el recorrido preorden
                        Console.WriteLine();  // Salto de línea para mejor presentación
                        break;

                    case "5":  // Caso para mostrar el recorrido postorden
                        Console.WriteLine("Recorrido Postorden:");  // Imprime el título del recorrido
                        arbol.Postorden();  // Llama al método para mostrar el recorrido postorden
                        Console.WriteLine();  // Salto de línea para mejor presentación
                        break;

                    case "6":  // Caso para salir del programa
                        salir = true;  // Cambia la variable `salir` a true para salir del bucle
                        break;

                    default:  // Caso para opciones inválidas
                        Console.WriteLine(" Opción no válida intente nuevamente ");  // Mensaje para opción inválida
                        break;
                }
            }
        }
    }
}