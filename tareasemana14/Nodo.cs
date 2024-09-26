using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tareaSemana14
{
    // Clase Nodo que representa un nodo de un árbol binario
    class Nodo
    {
        public int valor;  // Valor almacenado en el nodo
        public Nodo izquierda, derecha;  // Referencias a los nodos hijo izquierdo y derecho

        // Constructor para inicializar un nodo con un valor específico
        public Nodo(int item)
        {
            valor = item;  // Asigna el valor al nodo
            izquierda = derecha = null;  // Inicialmente, los hijos son nulos (no hay subárboles)
        }
    }
}