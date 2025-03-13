using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadoratectlaxiaco
{
    public class Class1
    {
        public static double Sumar(double uno, double dos)//Método para la suma de dos números
        {
            return uno + dos;
        }

        public static double Multiplicar(double uno, double dos)//Método para la multiplicación de dos números
        {
            return uno * dos;
        }

        public static double Restar(double uno, double dos)//Método para la resta de dos números
        {
            return uno - dos;
        }

        public static double Dividir(double numerador, double denominador)//Método para la división de dos números
        {
            try
            {
                if (denominador == 0)
                {
                    throw new DivideByZeroException();//Agregamos una excepción en casos donde el denominador sea 0 y evitar errores
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

        public static double RaizCuadrada(double n)//Método para el calculo de la raiz cuadrada de un número por medio de la función math.sqrt
        {
            return Math.Sqrt(n);
        }

        public static double Potencia(double num, double exponente)//Método para elevar un número a una potencia
        {
            return Math.Pow(num, exponente);
        }

        public static double Porcentaje(double num1, double total)//Método para calcular el porcenjate de un numero dependiendo de otro
        {
            return (num1 / total) * 100;
        }

        public static double Fraccion(double num)//Método para el calculo de una fracción dependiendo de un número
        {
            return 1 / num;
        }

        public static double LogaritmoNatural(double num) //Método para el calculo de un logaritmo natural de un numero 
        {
            if (num <= 0)
            {
                Console.WriteLine("Error: No se puede calcular el logaritmo de un número menor o igual a cero.");
                return double.NaN;
            }
            return Math.Log(num);
        }
        public static double Exp(double num, double exp) //Método para multiplicar un número *10 elevado a un exponente 
        {
            return num * Math.Pow(10, exp); //Se utilizó la función math.pow para multiplicarlo por el numero ingresado 
        }
        public static double Cuadrado(double num) // Metodo para poner un numero al cuadrado
        {
            return num * num;
        }
        public static double RaizCubica(double uno)//metodo para calcular raiz cubica
        {
            return Math.Pow(uno, 1.0 / 3.0);
        }
    }
}
