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
            //obtener la secuencia fibonacci
            int a = 0, b = 1, c = 1;
            /*
             a+b=c
             0+1=1
             1+0=1
             1+1=2
             2+1=3
             3+2=5
             5+3=8
             8+5=13
            ...
             */
            while (c < 100)
            {
                Console.WriteLine("{0}+{1}={2}", a, b, c);
                b = a;
                a = c;
                c = a + b;
                //determinar si cada numero de la serie es para o impar.
                int[] serie = new int[] { 5, 9, 4, 6, 3, 2 };
                foreach (int num in serie)
                {
                    Console.WriteLine("El num {0} es {1}", num, num % 2 == 0 ? "Par" : "Impar");
                }
                Console.ReadLine();
            }
        }
    }