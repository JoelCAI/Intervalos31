using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalos31
{
    public class Sistema
    {
        public void MenuPrincipal()
        {
            Validador.Bienvenida();
            Console.WriteLine("\n Recuerde seguir las instrucciones. Presione cualquier tecla para continuar");
            

            string fecha = Validador.ValidarString("\n Para saber si lo ingresado es un intervalo de tiempo ingrese" +
                                                   " los días y horas en este formato." +
                                                   "\n *dddd:hh:mm:ss* ");

         

            bool timeSpanCorrecto = TimeSpan.TryParse(fecha, out TimeSpan fechaIngresada);

            if (timeSpanCorrecto)
            {
                Console.Clear();
                Console.WriteLine("\n La fecha ingresada SI es un intervalo de tiempo: \n" 
                                  + " " + fechaIngresada.Days + " días, "
                                  + fechaIngresada.Hours + " horas, "
                                  + fechaIngresada.Minutes + " minutos, "
                                  + fechaIngresada.Seconds + " segundos. ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("\n La fecha ingresada NO es un intervalo de tiempo" +
                                  "\n Usted no ingreso este formato *dddd:hh:mm:ss* ");
            }
           


            Validador.Despedida();
        }

        public void Iniciar()
        {
            MenuPrincipal();
        }
    }
}
