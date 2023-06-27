using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_Ordenamiento
{
    internal class Nodo
    {
        public string Valor { get; set; }
        public Nodo Enlace { get; set; }

        public Nodo(string valor = "", Nodo enlace = null)
        {
            Valor = valor;
            Enlace = enlace;
        }
    }
}
