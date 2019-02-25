using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Ejemplo
{
    public static void Main(string[] args)
    {

        //Codigo para calculadora
        //Se declaran variables como double
        double a;
        double b;
        double resultado;
        string operacion;

        //Se lee valor a
        Console.WriteLine("Ingresa un valor (a)");

        //Se convierte double
        a = Convert.ToDouble(Console.ReadLine());

        //Se lee valor b
        Console.WriteLine("Ingresa otro valor (b)");

        //Se convierte a double
        b = Convert.ToDouble(Console.ReadLine());

        //Se lee operacion
        Console.WriteLine("Ingresa operacion (suma,resta,multiplicacion,division,residuo)");
        operacion = Console.ReadLine();

        if (operacion == "suma")
        {
            //Opera con suma
            resultado = a + b;
            //Muestra resultado
            Console.WriteLine("El dato resultado es {0}", resultado);
            Console.ReadLine();
        }
        if (operacion == "resta")
        {
            //Opera con resta
            resultado = a - b;
            //Muestra resultado
            Console.WriteLine("El dato resultado es {0}", resultado);
            Console.ReadLine();
        }
        if (operacion == "multiplicacion")
        {
            //Opera con multiplicacion
            resultado = a * b;
            //Muestra resultado
            Console.WriteLine("El dato resultado es {0}", resultado);
            Console.ReadLine();
        }
        if (operacion == "division")
        {
            //Opera con division
            resultado = a / b;
            //Muestra resultado
            Console.WriteLine("El dato resultado es {0}", resultado);
            Console.ReadLine();
        }
        if (operacion == "residuo")
        {
            //Opera con residuo
            resultado = a % b;
            Console.WriteLine("El dato residuo es: " + resultado);
            Console.ReadLine();
        }
    }
}
