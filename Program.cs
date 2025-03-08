using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaCalculadoraAppTec;

namespace CalculadoraAppTec
{
    class Program
    {
        private static double num1 = 0, num2 = 0, num0 = 0;

        static void Main(string[] args)
        {
            bool Salir = false;

            while (!Salir)
            {
                try
                {
                    Console.WriteLine(" - - - - - - - - - - MENU- - - - - - - - -");
                    Console.WriteLine("1. Sumar");
                    Console.WriteLine("2. Restar");
                    Console.WriteLine("3. Multiplicar");
                    Console.WriteLine("4. Dividir");
                    Console.WriteLine("5. Raiz Cuadrada");
                    Console.WriteLine("6. Potencia");
                    Console.WriteLine("7. Porcentaje");
                    Console.WriteLine("8. Fraccion");
                    Console.WriteLine("9. Salir");
                    Console.WriteLine("------------------------------------------");
                    Console.WriteLine("Elige una de las opciones");
                    int opcion = Convert.ToInt32(Console.ReadLine());

                    switch (opcion)
                    {
                        case 1:
                            teclado1();
                            Console.WriteLine("El resultado de la suma es: " + BibliotecaCalculadoraAppTec.Class1.Sumar(num1, num2));
                            break;
                        case 2:
                            teclado1();
                            Console.WriteLine("El resultado de la Resta es: " + BibliotecaCalculadoraAppTec.Class1.Restar(num1, num2));
                            break;
                        case 3:
                            teclado1();
                            Console.WriteLine("El resultado de la Multiplicacion es: " + BibliotecaCalculadoraAppTec.Class1.Multiplicar(num1, num2));
                            break;
                        case 4:
                            teclado1();
                            Console.WriteLine("El resultado de la Division es: " + BibliotecaCalculadoraAppTec.Class1.Dividir(num1, num2));
                            break;
                        case 5:
                            teclado0();
                            Console.WriteLine("El resultado de la Raiz cuadrada es: " + BibliotecaCalculadoraAppTec.Class1.RaizCuadrada(num0));
                            break;
                        case 6:
                            teclado2();
                            Console.WriteLine("El resultado de la Potencia es: " + BibliotecaCalculadoraAppTec.Class1.Potencia(num1, num2));
                            break;
                        case 7:
                            teclado3();
                            Console.WriteLine("El resultado del porcentaje es: " + BibliotecaCalculadoraAppTec.Class1.Porcentaje(num1, num2));
                            break;
                        case 8:
                            teclado0();
                            Console.WriteLine("El resultado de la fraccion es: " + BibliotecaCalculadoraAppTec.Class1.Fraccion(num0));
                            break;
                        case 9:
                            Console.WriteLine("Has elegido salir de la aplicación");
                            Environment.Exit(1);
                            Salir = true;
                            break;
                        default:
                            Console.WriteLine("Elige una opcion entre 1 y 9");
                            break;
                    }

                }
                catch (FormatException e)
                {
                    Console.WriteLine("Error al ingresar!!");
                }
            }
        }

        private static void teclado0()
        {
            Console.WriteLine("Introduzca un numero");
            num0 = double.Parse(Console.ReadLine());
        }
        private static void teclado1()
        {
            Console.WriteLine("Introduzca el primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el segundo numero");
            num2 = double.Parse(Console.ReadLine());
        }
        private static void teclado2()
        {
            Console.WriteLine("Introduzca el numero que va a ser elevado a una potencia");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor de la potencia (Exponente)");
            num2 = double.Parse(Console.ReadLine());
        }
        private static void teclado3()
        {
            Console.WriteLine("Introduzca el valor parcial");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca el valor total");
            num2 = double.Parse(Console.ReadLine());
        }

    }
}

