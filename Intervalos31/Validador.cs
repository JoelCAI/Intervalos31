using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalos31
{
    public class Validador
    {
        public static void Despedida()
        {

            Console.WriteLine("\n Gracias por usar nuestro Sistema presione cualquier teclar para finalizar");
            Console.ReadKey();
        }


        public static string ValidarString(string mensaje)
        {

            string opcion;
            bool valido = false;
            string mensajeValidador = "";
            string mensajeError = "\n Por favor ingrese un valor no vacio para que pueda continuar. ";

            do
            {

                Console.WriteLine(mensaje);
                Console.WriteLine(mensajeValidador);

                opcion = Console.ReadLine();

                if (opcion == "")
                {
                    Console.Clear();
                    Console.WriteLine("\n");
                    Console.WriteLine(mensajeError);
                }
                else
                {
                    valido = true;
                }

            } while (!valido);

            return opcion;
        }

        public static void Bienvenida()
        {
            Console.WriteLine("\n Bienvenido al Programa");
        }
    }
}
