using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace miPrimerProyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Uso de funciones...
            Console.WriteLine("La suma de 10+5={0}", suma());
            //ejercicio encontrar la media aritmetica y la desviacion tipica de una seria de numeros.

            Console.Write("Num 1: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Num 2: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("La suma de {0}+{1}={2}", num1, num2, suma(num1, num2));
            int[] serie = new int[] { 1, 2, 3, 4, 5 };
            Console.WriteLine("La media aritmetica es: {0}, y la desviacion tipica es: {1}", media(serie), tipica(serie));

            Console.ReadLine();
        }
        static int suma()
        {
            int respuesta = 10 + 5;
            return respuesta;
            static double media(int[] serie)
            {
                double media = 0;
                foreach (int num in serie)
                {
                    media += num;
                }
                return media / serie.Length;
            }
            static int suma(int a, int b)
            {
                int respuesta = a + b;
                return respuesta;
                static double tipica(int[] serie)
                {
                    double tipica = 0,
                            m = media(serie);
                    foreach (int num in serie)
                    {
                        tipica += Math.Pow(num - m, 2);
                    }
                    tipica = Math.Sqrt(tipica / serie.Length);
                    return Math.Round(tipica, 2);
                }
            }
        }