using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoratectlaxiaco
{
    public class Class1
    {
        public static double Sumar(double uno, double dos)
        {
            return uno + dos;
        }

        public static double Multiplicar(double uno, double dos)
        {
            return uno * dos;
        }

        public static double Restar(double uno, double dos)
        {
            return uno - dos;
        }

        public static double Dividir(double numerador, double denominador)
        {
            try
            {
                if (denominador == 0)
                {
                    throw new DivideByZeroException();
                }
                double result = numerador / denominador;
                Console.WriteLine("El resultado de la division es: " + result);
                return result;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                Console.WriteLine("Detalles del error: " + ex.Message);
                return double.NaN;
            }
        }

        public static double RaizCuadrada(double n)
        {
            return Math.Sqrt(n);
        }

        public static double Potencia(double num, double exponente)
        {
            return Math.Pow(num, exponente);
        }

        public static double Porcentaje(double num1, double total)
        {
            return (num1 / total) * 100;
        }

        public static double Fraccion(double num)
        {
            return 1 / num;
        }

        public static double LogaritmoNatural(double num)
        {
            if (num <= 0)
            {
                Console.WriteLine("Error: No se puede calcular el logaritmo de un número menor o igual a cero.");
                return double.NaN;
            }
            return Math.Log(num);
        }
    }
}
