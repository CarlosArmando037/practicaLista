using listassimpleprac.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Remoting.Proxies;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace listassimpleprac.Clases
{
    public class ListaSimple
    {
        public Nodo primero;
        public Nodo ultimo;

        public ListaSimple()
        {
            primero = ultimo = null;
        }

        //Metodos

        
        public bool EsVacio()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void InsertarInicio(PersonaModel persona)
        {
            if (EsVacio())
            {
                primero = ultimo = new Nodo(persona);
                Console.WriteLine("elemento agregado correctamente");
            }
            else 
            {
                primero = new Nodo(persona,primero);
                Console.WriteLine("elemento agregado correctamente");
            }
        }
        
        public void insertarMedio(PersonaModel persona)
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                int medio = longitudLista() / 2;
                int contador = 0;
                Nodo actual = primero;
                Nodo anterio = null;

                while (actual != null)
                {
                    if (contador == medio)
                    {
                        actual.siguiente = new Nodo(persona);
                        new Nodo(persona).siguiente = actual;
                    }
                    anterio = actual;
                    actual = actual.siguiente;
                    contador++;
                }
            }
        }
        
        public void InsertarFinal(PersonaModel persona)
        {
            if (EsVacio())
            {
                primero = ultimo = new Nodo(persona);
                Console.WriteLine("se agrego con exito");
            }
            else
            {
                ultimo = ultimo.siguiente = new Nodo(persona);
            }
        }
        public void OrdenarElementos()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo menor=primero;
                Nodo actual = primero.siguiente;
                while (menor != actual)
                {
                    //menor = actual;
                    while (actual != null )
                    {
                        if (menor._DatosPersona.Edad < actual.siguiente._DatosPersona.Edad)
                        {
                            Nodo Temp = menor;
                            menor = actual;
                            actual = Temp;
                        }
                        else
                        {
                            menor = actual;
                            actual = actual.siguiente;
                        }
                    }
                }
            }
        }

        // busqeuda binaria no lo estudiare
        /*
        public bool BuscarElemento()
        {
            PersonaModel persona = new PersonaModel();
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Console.WriteLine("inserte el elemento que quiere buscar: ");
                string objetivo = Console.ReadLine();
                int izquierda = 0;
                int centro = 0;
                Nodo actual = primero;
                int derecha = longitudLista();
                bool bandera = false;
                while (izquierda <= derecha)
                {
                    centro = longitudLista() / 2;
                    if (objetivo == persona.Nombre)
                    {
                        bandera = true;
                    }
                    else if ()
                    {

                    }
                }
            }
        }
        */
        public int longitudLista()
        {
            int contador = 0;
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
                return contador = 0;
            }
            else
            {
                if(primero!= null && primero.siguiente != null)
                {
                    Nodo actual = primero;
                    while (actual != null)
                    {
                        actual = primero.siguiente;
                        contador++;
                    }
                }
                else
                {
                    contador = 1;
                }
            }
            return contador;
        }

        public void imprimir()
        {
            if (EsVacio())
            {
                Console.WriteLine("la lista esta vacia");
            }
            else
            {
                Nodo actual = primero;
                while(actual != null)
                {
                    Console.WriteLine($"los datos del nodo {actual} son : {actual._DatosPersona.Nombre} y {actual._DatosPersona.Edad}");
                    actual = primero.siguiente;

                }
            }
        }


    }
}
