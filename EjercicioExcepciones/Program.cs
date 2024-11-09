using EjercicioExcepciones;
using System;
class Program
{
    static void Main()
    {
        Operaciones operaciones = new Operaciones();
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Seleccione una opción: ");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Salir");

            string opcion = Console.ReadLine();
            double num1, num2;
            switch (opcion)
            {
                case "1":
                    Console.WriteLine("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultado: " + operaciones.Sumar(num1, num2));
                    break;

                case "2":
                    Console.WriteLine("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultado: " + operaciones.Restar(num1, num2));
                    break;

                case "3":
                    Console.WriteLine("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Resultado: " + operaciones.Multiplicar(num1, num2));
                    break;

                case "4":
                    Console.WriteLine("Ingrese el primer número: ");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Ingrese el segundo número: ");
                    num2 = Convert.ToDouble(Console.ReadLine());
                    try
                    {
                        Console.WriteLine("Resultado: " + operaciones.Dividir(num1, num2));
                    }
                    catch (DivideByZeroException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    break;

                case "5":
                    continuar = false;
                    break;

                default:
                    Console.WriteLine();
                    break;
            }
            Console.WriteLine();
        }
        Console.WriteLine("¡Programa Finalizado!");
    }
}