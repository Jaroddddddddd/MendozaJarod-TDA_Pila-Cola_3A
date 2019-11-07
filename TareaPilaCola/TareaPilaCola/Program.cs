using System;

namespace TareaPilaCola
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;

            Nodo pilacola = null;

            Console.WriteLine("Escoja La estructura de datos a usar\n"
                        + "(1) Pila  \n"
                        + "(2) Cola \n");
            int opgeneral = int.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("Ingrese opción \n" + 
                    "(1) Crear  \n" + 
                    "(2) Apilar/Encolar \n" + 
                    "(3) Desapilar/Desencolar\n" + 
                    "(4) Cima\n" +
                    "(5) Preguntar si la estructura de datos esta vacia \n" +
                    "(6) Imprimir Toda la estructura de datos \n" + 
                    "(7) Salir \n");
                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        pilacola = Nodo.Crear(pilacola);
                        break;
                    case 2:
                        pilacola = Nodo.APilarEncolar(pilacola);
                        break;
                    case 3:
                        pilacola = Nodo.DesapilarDesencolar(pilacola, opgeneral);
                        break;
                    case 4:
                        Nodo.ImprimirCima(pilacola);
                        break;
                    case 5:
                        Nodo.estaVacia(pilacola);
                        break;
                    case 6:
                        Nodo.Imprimir(pilacola);
                        break;

                }
            } while (opcion != 7);

        }
    }
    }