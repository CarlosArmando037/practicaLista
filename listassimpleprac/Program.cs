using listassimpleprac.Clases;
using listassimpleprac.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listassimpleprac
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ListaSimple lista = new ListaSimple();
            PersonaModel modelo = new PersonaModel();

            Console.WriteLine("1._ imprimir");
            Console.WriteLine("2._ insertar datos al inicio");
            Console.WriteLine("3._ insertar datos al medio /{}/");
            Console.WriteLine("4._ insertar datos al final /{}/");
            Console.WriteLine("5._ insertar datos al final /{}/");

            Console.WriteLine("6._ ordenar elemento metodo burbuja /{}/");
            Console.WriteLine("7._mostrar longitud de la lista");
            Console.WriteLine("8._ Salir");
            int opcion = Convert.ToInt32(Console.ReadLine());

            while(opcion != 8)
            {
                switch (opcion)
                {
                    case 2:
                        Console.WriteLine("ingrese el nombre de la persona");
                        modelo.Nombre = Console.ReadLine();
                        Console.WriteLine("ingrese la edad de la persona");
                        modelo.Edad = Convert.ToInt32(Console.ReadLine());
                        lista.InsertarInicio(modelo);
                        break;
                    case 1:
                        lista.imprimir();
                        break;
                    
                    case 6:
                        lista.OrdenarElementos();
                        lista.imprimir();
                        break;
                    case 7:
                        lista.longitudLista();
                        break;

                }
                Console.WriteLine("seleccione otra accion");
                opcion = Convert.ToInt32(Console.ReadLine());

            }


        }
    }
}
