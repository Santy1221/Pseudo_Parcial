using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Pseudo_Parcial
{
    internal class Program
    {


        static void Main(string[] args)
        {
            double h, r, g, v, a;

            Console.WriteLine("Codigo para sacar el volumen y area de un cono en C#");

            do
            {

                g = PedirDouble("ingrese el valor de la generatriz:");

                h = PedirDouble("ingrese el valor de la altura: ");

                r = PedirDouble("ingrese el valor rel radio: ");



            } while (verificarDatos(g, h, r));

            if (verificarCono(h, r, g))
            {

                a = Math.PI * r * (r + g);
                v = (Math.PI * Math.Pow(r, 2) * h) / 3;

                a = Math.Truncate(a);
                v = Math.Truncate(v);

                Console.Write($"El area del cono es: {a} y el volumen del cono es: {v} ");

                Console.ReadKey();

            }
            else
            {
                Console.WriteLine("Numeros mal ingresados");
            }
        }

        private static bool verificarCono(double h, double r, double g)
        {
            Boolean result;
            result = (Math.Pow(h, 2) + Math.Pow(r, 2) == Math.Pow(g, 2));
            return result;
        }

        private static bool verificarDatos(double g, double h, double r)
        {
            Boolean result=true;
            if (g >= h || g >= r)
            {
                result = false;
            }
            else
            {
                Console.WriteLine("Los datos ingresados no forman un cono (la generatriz no puede ser mayor o igual a la altura o el radio)");
                
            }
            return result;  
        }

        private static double PedirDouble(string mensaje)
        {
            double nro = 0;
            do
            {
                Console.WriteLine(mensaje);
                string strConsola = Console.ReadLine();
                if (!double.TryParse(strConsola, out nro))
                {
                    Console.WriteLine("Numero mal ingresado");
                }
                else
                {
                    break;
                }

            } while (true);
            return nro;
        }
    }
}
