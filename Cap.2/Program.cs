using System;

namespace Cap._2
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
                Console.WriteLine("2) Ejercicio 3");
                Console.WriteLine("3) Ejercicio 4");
                Console.WriteLine("4) Ejercicio 5");
                Console.WriteLine("5) Salir ");

                menu = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (menu)
                {
                    case 1:
                        Poligono();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Radianes();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        gradosFahrenheit();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        CambiodelDia();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Numero Digitado Invalido....");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }

            } while (menu != 5);
        }

        public static void Poligono()
        {
            float a = 0.00f;
            int b = 0;
            float perimetro = 0.00f;

            Console.WriteLine("Ingrese cantidad de lados del poligono: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de uno de sus lados: ");
            a = Convert.ToSingle(Console.ReadLine());

            perimetro = a * b;

            Console.WriteLine($"El Resultado del poligono es {perimetro}. ");
        }


        public static void Radianes()
        {
            float grados = 0.00f;
            double radianes = 0.00f;

            Console.WriteLine("Ingrese la cantidad de grados: ");
            grados = Convert.ToSingle(Console.ReadLine());

            radianes = (grados * Math.PI) / 180f;

            Console.WriteLine($"La cantidad de Radianes es {radianes}.");
        }

        public static void gradosFahrenheit()
        {
            float centigrados = 0.00f;
            float fahrenheit = 0.00f;

            Console.WriteLine("Ingrese la cantidad de centigrados: ");
            centigrados = Convert.ToSingle(Console.ReadLine());

            fahrenheit = (centigrados * 9 /5) + 32;
            Console.WriteLine($"La cantidad es {fahrenheit}  grados farenheit.");
        }

        public static void CambiodelDia()
        {
            float dolares = 0.00f;
            float euros = 0.00f;
            int opcion = 0;
            float totalDolares = 0.00f, totalEuros = 0.00f;

            Console.WriteLine("Digite 1 para cambio de Dolares a Euros: ");
            Console.WriteLine("Digite 2 para cambio de Euros a Dolar: ");
            opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 1)
            {
                Console.WriteLine("Ingrese la cantidad de Dolares: ");
                dolares = Convert.ToSingle(Console.ReadLine());

                totalEuros = dolares * 0.84f;
                Console.WriteLine($"La cantidad en Euros es {totalEuros}. ");
            }

            if(opcion == 2)
            {
                Console.WriteLine("Ingrese la cantidad de Euros: ");
                euros = Convert.ToSingle(Console.ReadLine());

                totalDolares = euros * 1.19f;
                Console.WriteLine($"La cantidad en Dolares es {totalDolares}. ");
            }
        }
    }
}
