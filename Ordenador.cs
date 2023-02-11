using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ordenador_Herramientas_II_
{
    internal class Ordenador
    {
        private int tamaño_disco = 233;
        private int tamaño_disco_max = 500;
        private bool ordenador_encendido = false;

        public void añadirDatos(int datos)
        {
            int totalAñadido = datos + tamaño_disco;
            int tamañoDisponible = tamaño_disco_max - tamaño_disco;
           if (ordenador_encendido)
            {
                if (tamaño_disco < tamaño_disco_max && totalAñadido <= tamaño_disco_max)
                {
                    tamaño_disco = totalAñadido;
                    Console.WriteLine($"Los datos fueron añadidos con exito, se añadieron: {datos}-GB, total tamaño disco {totalAñadido}-GB");
                }
                else
                {
                    Console.WriteLine($"No se pueden añadir los datos socilitados, el tamaño disponible es de {tamañoDisponible}-GB y el dato introduccido pesa ({datos})-GB. se sobre pasa el tamaño del disco duro({tamaño_disco_max})-GB");
                }
            }
           else
            {
                Console.WriteLine("El ordenador esta apagado, no se pueden añadir datos al disco!");
            }
        }
        public void eliminarDatos(int datos)
        {
            int tamañoOcupado = tamaño_disco - datos;
            int tamañoTotal = tamaño_disco_max - tamañoOcupado;
            if (ordenador_encendido)
            {
                if (datos > tamaño_disco)
                {
                    Console.WriteLine($"¡No puedes eliminar mas datos de los que hay! total espacio ocupado: {tamaño_disco}-GB. estas queriendo eliminar: {datos}-GB");
                }
                else
                {
                    if (tamañoOcupado <= 0)
                    {
                        tamaño_disco = 0;
                        Console.WriteLine($"El disco quedo vacio por completo! Espacio total {tamaño_disco_max}-GB se vaciaron {datos}-GB");
                    }
                    else
                    {
                        tamaño_disco = tamañoOcupado;
                        Console.WriteLine($"Se vaciaron los datos con exito, total eliminados {datos}-GB. Espacio ocupado: {tamañoOcupado}-GB. Espacio total {tamañoTotal}-GB");

                    }
                }
            }
            else
            {
                Console.WriteLine("El ordenador esta apagado, no se pueden eliminar datos del disco");
            }
        }

        public void Encender()
        {
            ordenador_encendido = true;
        }
        public void Apagar()
        {
            ordenador_encendido = false;
        }
    }
}
