using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaAppCalculadora
{
    public class Class1
    {
        public static double Sumar(double uno, double dos) //Mètodo para la suma de dos nùmeros 
        {
            return uno + dos;
        }

        public static double Multiplicar(double uno, double dos) //Método para la multiplicación de dos números 
        {
            return uno * dos;
        }

        public static double Restar(double uno, double dos) // Método para la resta de dos números
        {
            return uno - dos;
        }

        public static double Dividir(double numerador, double denominador) //Método para división 
        {
            try
            {
                if (denominador == 0) //Si el denominador = 0
                {
                    throw new DivideByZeroException(); //Se realiza la exepción 
                }
                double result = numerador / denominador;
                return result;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: No se puede dividir por cero.");
                Console.WriteLine("Detalles del error: " + ex.Message);
                return double.NaN; // Retorna "Not a Number" si ocurre la división por cero
            }
        }
        public static double RaizCuadrada(double n) //Método para calcular la raiz cuadrada de un numero
        {
            return Math.Sqrt(n); //Función que nos ayuda a calcular la raiz cuadrada 
        }

        public static double Potencia(double num, double exponente) //Método para elevar un numero a una potencia
        {
            return Math.Pow(num, exponente); //Función que en base a dos numeros nos devuelve el resultado de un numero elevado a un exponente 
        }

        public static double Porcentaje(double num1, double total) //Método para calcular el porcentaje de un valor dependiendo de otro
        {
            return (num1 / total) * 100; //num 1 es la parcialidad de total, por lo cual se calcula que porcentaje representa num1 de total 
        }
        public static double Fraccion(double num) //Método fraccional 
        {
            return 1 / num; // 1 dividido entre un numero dado da como resultado su valor fraccional 
        }
    }
}
