using System;

namespace Medidas_De_La_Pecera
{
    class Program
    {
        static void Main(string[] args)
        {
            double a;
            double c;
            double b;
            int op = 1;

            Operaciones opr = new Operaciones();
            while (op == 1)
            {
                Console.WriteLine("________________________________________");
                Console.WriteLine("Ingresa las medidas de la pecera en cm:");
                Console.Write("Largo: ");
                a = double.Parse(Console.ReadLine());
                Console.Write("Ancho: ");
                b = double.Parse(Console.ReadLine());
                Console.Write("Altura o Profundidad: ");
                c = double.Parse(Console.ReadLine());
                Console.WriteLine("________________________________________");
                Console.WriteLine("El volumen es: " + opr.Volumen(a, b, c) + "cm³");
                Console.WriteLine("________________________________________");
                Console.WriteLine("Desea Ingresar Otras medidads 1.Si 2.No");
                op = int.Parse(Console.ReadLine());
                Console.Clear();

            }
            Console.WriteLine("-------Creditos-------");
            Console.WriteLine("Adinson Melvin David Morales Pineda");
            Console.WriteLine("Pedro Javier Serrano Ramírez");
        }
    }
}
