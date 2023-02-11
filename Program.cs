using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_ordenador_Herramientas_II_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ordenador ordenador1 = new Ordenador();
            ordenador1.Encender(); // --> Si se comenta esta linea, no eliminan ni añaden datos.
            ordenador1.añadirDatos(4); //
            ordenador1.eliminarDatos(2); // Si se ejecutan alguno de estos dos metodos antes de prender el ordenador, va lanzar un mensaje de error!
            Console.ReadKey();
        }
    }
}
