using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Operation(string option) 
        {
            Console.WriteLine("Ingrese el primer número");
            double a = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Ingrese el segundo número");
            double b = Convert.ToDouble(Console.ReadLine());

            if (option == "1") {
                Console.WriteLine("La suma de {0} + {1} es {2}", a, b, a + b);
            }
            else if (option == "2") {
                Console.WriteLine("La resta de {0} - {1} es {2}", a, b, a - b);
            }
            else if (option == "3") {
                Console.WriteLine("La multiplicación de {0} x {1} es {2}", a, b, a * b);
            }
            else if (option == "4") {
                Console.WriteLine("La división de {0} / {1} es {2}", a, b, a / b);
            }
        }

        static void SquareRoot()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}",i,Math.Sqrt(i));
            }
        }

        static void PrimeNumbers()
        {
            int cont = 0;
            for (int i = 2; i <= 30; i++){
                for (int j = 1; j <= i; j++) {
                    if (i % j == 0){ 
                        cont = cont + 1;
                    }
                }

                if (cont <= 2) {
                Console.WriteLine(i);
                }
                cont = 0;
            }
        }

        static double FahrenheitToCelsius(double temperature)
        {
            Double celsius = 5 * (temperature - 32) / 9;
            return celsius;
        }

        static double CelsiusToFahrenheit(double temperature)
        {
            Double fahrenheit = ((9 * temperature) / 5) + 32;
            return fahrenheit;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string option;
            do
            {
                Console.Clear();
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Resta de dos números");
                Console.WriteLine("[3] Multiplicación de dos números");
                Console.WriteLine("[4] División de dos números");
                Console.WriteLine("[5] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[6] Imprimir los 10 primeros números primos");
                Console.WriteLine("[7] Convertir temperatura de Fahrenheit a Celsius");
                Console.WriteLine("[8] Convertir temperatura de Celsius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                
                option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        Operation(option);
                        Console.ReadKey();
                        break;
                    
                    case "2":
                        Operation(option);
                        Console.ReadKey();
                        break;
                    
                    case "3":
                        Operation(option);
                        Console.ReadKey();
                        break;
                    
                    case "4":
                        Operation(option);
                        Console.ReadKey();
                        break;

                    case "5":
                        SquareRoot();
                        Console.ReadKey();
                        break;
                    
                    case "6":
                        PrimeNumbers();
                        Console.ReadKey();
                        break;

                    case "7":
                        Console.WriteLine("Ingrese la temperatura en Fahrenheit");
                        double temperatureF = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La conversión de Fahrenheit ({0}) a Celsius es: {1}", temperatureF, FahrenheitToCelsius(temperatureF));
                        Console.ReadKey();
                        break;
                    
                    case "8":
                        Console.WriteLine("Ingrese la temperatura en Celsius");
                        double temperatureC = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La conversión de Celsius ({0}) a Fahrenheit es: {1}", temperatureC, CelsiusToFahrenheit(temperatureC));
                        Console.ReadKey();
                        break;
                }
            } while (!option.Equals("0"));
        }
    }
}
