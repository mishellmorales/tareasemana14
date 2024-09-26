using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tareaSemana14;

namespace tareaSemana14
{
    // Clase que define el Árbol Binario y sus operaciones
    class ArbolBinario
    {
        public Nodo raiz;  // Nodo raíz del árbol

        // Constructor que inicializa el árbol vacío (raíz nula)
        public ArbolBinario()
        {
            raiz = null;  // Al iniciar, el árbol está vacío
        }

        // Método para insertar un nuevo valor en el árbol
        public void Insertar(int valor)
        {
            raiz = InsertarRecursivo(raiz, valor);  // Llama al método recursivo para insertar el valor, comenzando desde la raíz
        }

        // Método recursivo que inserta un valor en el lugar adecuado
        Nodo InsertarRecursivo(Nodo raiz, int valor)
        {
            // Si el árbol está vacío (nodo nulo), crea un nuevo nodo con el valor
            if (raiz == null)
            {
                raiz = new Nodo(valor);  // Crea un nuevo nodo con el valor dado
                return raiz;  // Devuelve el nuevo nodo como parte del árbol
            }

            // Si el valor a insertar es menor que el valor del nodo actual, ve al subárbol izquierdo
            if (valor < raiz.valor)
                raiz.izquierda = InsertarRecursivo(raiz.izquierda, valor);  // Inserta en el subárbol izquierdo
                                                                            // Si el valor a insertar es mayor que el valor del nodo actual, ve al subárbol derecho
            else if (valor > raiz.valor)
                raiz.derecha = InsertarRecursivo(raiz.derecha, valor);  // Inserta en el subárbol derecho

            return raiz;  // Retorna el nodo raíz modificado
        }

        // Método para buscar un valor en el árbol
        public bool Buscar(int valor)
        {
            return BuscarRecursivo(raiz, valor);  // Llama al método recursivo para buscar el valor, comenzando desde la raíz
        }

        // Método recursivo para buscar un valor en el árbol
        bool BuscarRecursivo(Nodo raiz, int valor)
        {
            // Si el nodo actual es nulo, significa que el valor no está en el árbol
            if (raiz == null)
                return false;  // Valor no encontrado

            // Si el valor del nodo actual es igual al valor buscado, entonces lo ha encontrado
            if (raiz.valor == valor)
                return true;  // Valor encontrado

            // Si el valor a buscar es menor, busca en el subárbol izquierdo
            if (valor < raiz.valor)
                return BuscarRecursivo(raiz.izquierda, valor);  // Busca en el subárbol izquierdo
            else
                return BuscarRecursivo(raiz.derecha, valor);  // Si es mayor, busca en el subárbol derecho
        }

        // Método para realizar un recorrido inorden del árbol
        public void Inorden()
        {
            InordenRecursivo(raiz);  // Llama al método recursivo de recorrido inorden, comenzando desde la raíz
        }

        // Método recursivo para realizar el recorrido inorden
        void InordenRecursivo(Nodo raiz)
        {
            if (raiz != null)  // Si el nodo no es nulo
            {
                InordenRecursivo(raiz.izquierda);  // Recorre el subárbol izquierdo
                Console.Write(raiz.valor + " ");  // Imprime el valor del nodo
                InordenRecursivo(raiz.derecha);  // Recorre el subárbol derecho
            }
        }

        // Método para realizar un recorrido preorden del árbol
        public void Preorden()
        {
            PreordenRecursivo(raiz);  // Llama al método recursivo de recorrido preorden, comenzando desde la raíz
        }

        // Método recursivo para realizar el recorrido preorden
        void PreordenRecursivo(Nodo raiz)
        {
            if (raiz != null)  // Si el nodo no es nulo
            {
                Console.Write(raiz.valor + " ");  // Imprime el valor del nodo
                PreordenRecursivo(raiz.izquierda);  // Recorre el subárbol izquierdo
                PreordenRecursivo(raiz.derecha);  // Recorre el subárbol derecho
            }
        }

        // Método para realizar un recorrido postorden del árbol
        public void Postorden()
        {
            PostordenRecursivo(raiz);  // Llama al método recursivo de recorrido postorden, comenzando desde la raíz
        }

        // Método recursivo para realizar el recorrido postorden
        void PostordenRecursivo(Nodo raiz)
        {
            if (raiz != null)  // Si el nodo no es nulo
            {
                PostordenRecursivo(raiz.izquierda);  // Recorre el subárbol izquierdo
                PostordenRecursivo(raiz.derecha);  // Recorre el subárbol derecho
                Console.Write(raiz.valor + " ");  // Imprime el valor del nodo
            }
        }
    }
}