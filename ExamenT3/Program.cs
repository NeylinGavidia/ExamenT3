using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Biblioteca;

namespace ExamenT3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int op;
            Class1 acciones = new Class1();

            Console.WriteLine("Hola, ¿Cuántos números deseas generar?");
            Console.WriteLine();
            int cantidad = int.Parse(Console.ReadLine());
            int[] numeros = acciones.GenerarNumeros(cantidad);
            Console.WriteLine();

            Console.WriteLine("Los números generados son: ");
            Console.WriteLine();
            acciones.Mostrarnumeros(numeros);
            Console.WriteLine();
            Console.WriteLine("Gracias por generar los números, presione ENTER para continuar");
            Console.ReadKey();
            Console.Clear();

            do
            {
                Console.WriteLine("Bienvendx al menú");
                Console.WriteLine();
                Console.WriteLine("1. Tercera potencia");
                Console.WriteLine("2. Ordenar de manera descendente");
                Console.WriteLine("3. Eliminar elemento");
                Console.WriteLine("4. Modificar elemento");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                op = int.Parse(Console.ReadLine());
                Console.Clear();
                Console.WriteLine();
                switch (op)
                {
                    case 1:
                        acciones.MostrarNumerosAlCubo(numeros);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Ordenando...");
                        Thread.Sleep(500);
                        Console.Clear();
                        Console.WriteLine("Orden descendente:");
                        Console.WriteLine();
                        acciones.Burbuja(numeros);
                        acciones.Mostrarnumeros(numeros);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 3:
                        Console.WriteLine("¿Qué posición deseas eliminar?");
                        Console.WriteLine();
                        int indice = int.Parse(Console.ReadLine());
                        Console.WriteLine();
                        numeros = acciones.Eliminar(numeros, indice);
                        Thread.Sleep(2000);
                        Console.Clear();
                        break;
                    case 4:
                        Console.WriteLine("¿Qué número deseas modificar?");
                        Console.WriteLine();
                        int actual = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        Console.WriteLine("¿Por qué número lo deseas reemplazar?");
                        Console.WriteLine();
                        int nuevo = int.Parse(Console.ReadLine());
                        Console.WriteLine();

                        acciones.ModificarPorValor(numeros, actual, nuevo);
                        Thread.Sleep(2500);
                        Console.Clear();
                        break;
                    case 0:
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Opción no válida");
                        Console.WriteLine();
                        break;
                }
            }
            while (true);
        }
    }
}
