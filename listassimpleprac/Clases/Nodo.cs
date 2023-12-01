using listassimpleprac.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listassimpleprac.Clases
{
    public class Nodo
    {
        public PersonaModel _DatosPersona;
        public Nodo _Siguiente;

        public Nodo(PersonaModel Datos)
        {
            _DatosPersona = Datos;
            _Siguiente = null;
        }
        public Nodo(PersonaModel Datos, Nodo siguiente)
        {
            _DatosPersona = Datos;
            _Siguiente = siguiente;
        }

        public PersonaModel Datos { get { return _DatosPersona; } set { _DatosPersona = value; } }
        public Nodo siguiente { get { return _Siguiente; } set { _Siguiente = value; } }

    }
}
