using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Class1
    {
        private Random random = new Random();

        public int[] GenerarNumeros(int cantidad)
        {
            int[] numeros = new int[cantidad];
            for (int i = 0; i < cantidad; i++)
            {
                numeros[i] = random.Next(1, 100);
            }
            return numeros;
        }
        public void Mostrarnumeros(int[] numeros)
        {
            Console.WriteLine(string.Join(",", numeros));
        }

        //Primera opcion
        public void MostrarNumerosAlCubo(int[] arreglo)
        {
            Console.WriteLine("Elementos elevados a la tercera potencia:");
            for (int i = 0; i < arreglo.Length; i++)
            {
                Console.Write(Math.Pow(arreglo[i], 3) + " ");
            }
            Console.WriteLine();
        }
        //segunda opcion
        public void Burbuja(int[] numeros)
        {
            int num = numeros.Length;

            for (int i = 0; i < num - 1; i++)
            {
                for (int j = 0; j < num - i - 1; j++)
                {
                    if (numeros[j] < numeros[j + 1])
                    {
                        // Intercambiar correctamente
                        int aux = numeros[j];
                        numeros[j] = numeros[j + 1];
                        numeros[j + 1] = aux;
                    }
                }
            }
        }
        //tercera opcion
        public int[] Eliminar(int[] eliminado, int indice)
        {
            if (indice < 0 || indice >= eliminado.Length)
            {
                Console.WriteLine("Opción no válida.Índice no existente");
                Console.WriteLine();
                return eliminado;
            }

            int[] gruponuevo = new int[eliminado.Length - 1];
            int j = 0;

            for (int i = 0; i < eliminado.Length; i++)
            {
                if (i == indice) continue; // continue, investigado//para saltar el indice eliminado y que no se digite
                gruponuevo[j] = eliminado[i];
                j++;
            }

            Console.WriteLine("Elemento eliminado. Los números son:");
            Console.WriteLine();
            Mostrarnumeros(gruponuevo);

            return gruponuevo;
        }
        //cuarta opncion
        public void ModificarPorValor(int[] arreglo, int valorActual, int nuevoValor)
        {
            bool encontrado = false;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] == valorActual)
                {
                    arreglo[i] = nuevoValor;
                    encontrado = true;
                }
            }

            if (encontrado)
            {
                Console.WriteLine("Elemento modificado. Nueva lista:");
                Mostrarnumeros(arreglo);
            }
            else
            {
                Console.WriteLine("Valor no encontrado en el arreglo.");
            }
        }
    }
}
