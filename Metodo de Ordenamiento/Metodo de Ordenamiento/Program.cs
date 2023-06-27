using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_de_Ordenamiento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();

            lista.AgregarNodo("C");
            lista.AgregarNodo("A");
            lista.AgregarNodo("B");

            Console.WriteLine("Lista antes del ordenamiento:");
            Console.WriteLine(lista.RecorrerLista());

            lista.OrdenamientoBurbuja();

            Console.WriteLine("Lista después del ordenamiento:");
            Console.WriteLine(lista.RecorrerLista());
            Console.ReadLine(); 
            
        }
    }
}
