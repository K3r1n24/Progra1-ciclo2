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
            //estructuras de control.
            //1. if. ejercicio. pedir al usuario la edad si es mayor de edad que le diga bienvenido.
            Console.Write("Edad: ");
            int edad = int.Parse(Console.ReadLine());
            string continuar = "s";
            while (continuar == "s")
            {
                Console.Write("Edad: ");
                int Edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
                }
                else
                {
                    Console.WriteLine("Eres un adolescente, disfruta de la vida.");
                    if (edad < 0)
                    {
                        Console.WriteLine("Edad incorrecta.");
                    }
                    else if (edad <= 2)
                    {
                        Console.WriteLine("Eres un bebe");
                    }
                    else if (edad < 12)
                    {
                        Console.WriteLine("Eres un niño");
                    }
                    else if (edad < 18)
                    {
                        Console.WriteLine("Eres un adolescente.");
                    }
                    else if (edad <= 65)
                    {
                        Console.WriteLine("Bienvenido al mundo de las reposabilidades.");
                    }
                    else if (edad <= 80)
                    {
                        Console.WriteLine("Eres un adulto mayor");
                    }
                    else
                    {
                        Console.WriteLine("Larga vida");
                    }
                    Console.Write("Desea continuar presione s, sino cualquier tecla.");
                    continuar = Console.ReadLine();
                }
                //Pausa.
                Console.ReadLine();
            }
        }
    }
}