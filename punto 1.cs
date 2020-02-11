using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main()
        {
            Console.Write("ingrese su salario: ");
            Double salario = double.Parse(Console.ReadLine());
            Console.Write("ingrese 1 si es dependiente o 2 si es independiente: ");
            int depOInt = int.Parse(Console.ReadLine());
            Double smmlv = 877803;


            double baseCotizacion = (salario * 0.4);

            if (baseCotizacion < smmlv)
            {
                baseCotizacion = smmlv;
            }

            switch (depOInt)
            {
                case 1:
                    double eps = baseCotizacion * 0.04;
                    //Console.WriteLine(eps);
                    double pension = baseCotizacion * 0.04;
                    //Console.WriteLine(pension);
                    double salarioReal = salario - eps - pension;
                    Console.WriteLine("su salario mensual real es: " + salarioReal);
                    double salarioAnual = (salarioReal * 12) + salario;
                    Console.WriteLine("su salario anual es: " + salarioAnual);
                    break;
            
                case 2:
                    double riesgo = 0;
                    Console.WriteLine("ingrese su clase de riesgo (numero de 1 a 5): ");
                    int tipoDeRiesgo = int.Parse(Console.ReadLine());
                    eps = baseCotizacion * 0.125;
                    //Console.WriteLine(eps);
                    pension = baseCotizacion * 0.16;
                    //Console.WriteLine(pension);

                    switch (riesgo)
                    {
                        case 1:
                            riesgo = 0.00522 * baseCotizacion;
                            break;

                        case 2:
                            riesgo = 0.01044 * baseCotizacion;
                            break;
                        case 3:
                            riesgo = 0.02436 * baseCotizacion;
                            break;
                        case 4:
                            riesgo = 0.04350 * baseCotizacion;
                            break;
                        case 5:
                            riesgo = 0.06960 * baseCotizacion;
                            break;
                    }

                    salarioReal = salario - eps - pension - riesgo;
                    Console.WriteLine("su salario mensual real es: " + salarioReal);
                    Console.WriteLine("su salario anual es: " + salarioReal * 12);
                    break;
            }
        }
    }
}
