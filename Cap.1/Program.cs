using System;

namespace Cap._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            do {
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1) Ejercicio 1");
                Console.WriteLine("2) Ejercicio 5");
                Console.WriteLine("3) Salir ");

                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menu){
                    case 1:
                        Console.WriteLine("Reny Diaz");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.WriteLine("Reny Diaz");
                        Console.WriteLine("Estudiante de Ingenieria en Sistemas");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Numero Digitado Invalido....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (menu != 3);
        }
    }
}
