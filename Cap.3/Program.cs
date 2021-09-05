using System;

namespace Cap._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            do
            {
                Console.WriteLine("Seleccione una opcion: ");
                Console.WriteLine("1) Ejercicio 1");
                Console.WriteLine("2) Ejercicio 4");
                Console.WriteLine("3) Salir ");

                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        ParoImpar();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        diaSemana();
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

        public static void ParoImpar()
        {
            int numero = 0;

            Console.WriteLine(" Digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine($"El numero {numero} es Par. ");
            }
            else
            {
                Console.WriteLine($"El numero {numero} es Impar. ");
            }
        }


        public static void diaSemana()
        {
            int numero = 0;

            Console.WriteLine("Digite un numero del 1 al 7: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("LUNES.");
                    break;
                case 2:
                    Console.WriteLine("MARTES.");
                    break;
                case 3:
                    Console.WriteLine("MIERCOLES.");
                    break;
                case 4:
                    Console.WriteLine("JUEVES.");
                    break;
                case 5:
                    Console.WriteLine("VIERNES.");
                    break;
                case 6:
                    Console.WriteLine("SABADO.");
                    break;
                case 7:
                    Console.WriteLine("DOMINGO.");
                    break;
            }
        }
    }
}
