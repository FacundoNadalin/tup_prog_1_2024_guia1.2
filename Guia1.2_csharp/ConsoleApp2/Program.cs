using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio 2) Truco!
             Un trío de truco desea repartir el premio obtenido en un campeonato de la siguiente manera:
            -El 50 % del premio se reparte en partes iguales entre los 3 integrantes.
            - El 50 % restante se distribuye proporcionalmente de acuerdo a los puntos obtenidos en los mano a mano del campeonato.
            Desarrolle un diagrame de flujo que ingresando el importe total del premio y los puntos obtenidos individualmente muestren cuanto le corresponde a cada jugador.*/
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black ;
            Console.Clear();
            int  puntos1, puntos2, puntos3;
            double mitad, proporcion, premio1, premio2, premio3, premiototal;
            Console.WriteLine("ingrese el total del premio: ");
            premiototal=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de puntos del primer jugador: ");
            puntos1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de puntos del segundo jugador: ");
            puntos2= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad de puntos del tercer jugador: ");
            puntos3 = Convert.ToInt32(Console.ReadLine());
            mitad=premiototal/2;
            proporcion=mitad/(puntos1+puntos2+puntos3);
            premio1=mitad/3+proporcion*puntos1;
            premio2=mitad/3+proporcion*puntos2;
            premio3=mitad/3+proporcion*puntos3;
            Console.WriteLine("al jugador 1 le corresponde {0:c2}",premio1);
            Console.WriteLine($"al jugador 2 le corresponde {premio2:c2}");
            Console.WriteLine("al jugador 3 le corresponde {0:c2}", premio3);
            Console.ReadKey();

        }
    }
}
