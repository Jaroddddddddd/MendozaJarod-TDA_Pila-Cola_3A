using System;
using System.Collections.Generic;
using System.Text;

namespace TareaPilaCola
{
    class Nodo
    {
        int dato;
        Nodo frente;
        Nodo siguiente;
        Nodo cima;

        public Nodo(int dato)
        {
            this.dato = dato;
            this.siguiente = null;
        }

        public static Nodo Crear(Nodo pilacola)
        {
            Console.WriteLine("Ingrese elemento a guardar");
            int valor = int.Parse(Console.ReadLine());
            pilacola = new Nodo(valor);
            pilacola.frente = pilacola.cima = pilacola;
           
            return pilacola;
        }
        public static Nodo APilarEncolar(Nodo pilacola)
        {

            if (pilacola == null)
            {
                Console.WriteLine("La estructura de datos no ha sido creada, escoja opción 1");
                return pilacola;
            }


            Console.WriteLine("Ingrese elemento a guardar");
            int valor = int.Parse(Console.ReadLine());
            Nodo nodoNuevo = new Nodo(valor);

            Nodo aux = pilacola;
            for (; aux.siguiente != null; aux = aux.siguiente) ;
            aux.siguiente = nodoNuevo;
            pilacola.cima = nodoNuevo;

            return pilacola;
        }
        public static Nodo DesapilarDesencolar(Nodo pilacola, int opciongenaral)
        {
            if (pilacola == null)
            {
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
                return pilacola;
            }
            if (pilacola.siguiente == null)
            {
                Console.WriteLine("Elemento: " + pilacola.dato);
                return pilacola.siguiente;
            }

            if (opciongenaral == 2)
            {
                if (pilacola == null)
                {
                    Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
                    return pilacola;
                }

                Console.WriteLine("Elemento: " + pilacola.dato);
                pilacola = pilacola.siguiente;

                return pilacola;


            }
            else
            {

                Nodo aux = pilacola;
                for (; aux.siguiente.siguiente != null; aux = aux.siguiente) ;
                Console.WriteLine("Elemento: " + aux.siguiente.dato);
                aux.siguiente = aux.siguiente.siguiente;
                pilacola.cima = aux;
                return pilacola;

            }

        }

        public static void Imprimir(Nodo miPila)
        {
            if (miPila == null)
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
            for (Nodo aux = miPila; aux != null; aux = aux.siguiente)
                Console.WriteLine("Dato:" + aux.dato + "\n");
        }

        public static void ImprimirCima(Nodo miPila)
        {
            if (miPila == null)
                Console.WriteLine("La estructura de datos no ha sido creada... escoja opción 1");
            else

                Console.WriteLine("Cima: " + miPila.cima.dato + "\n");


        }


        public static void estaVacia(Nodo miPila)
        {
            if (miPila == null)
                Console.WriteLine("La estructura de datos esta vacia");
            else
                Console.WriteLine("La estructura de datos no esta vacia");
        }
    }
}
