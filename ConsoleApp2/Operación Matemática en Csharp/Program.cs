using System;
/**
 * Autor:Jaime Sánchez Ortiz
 * Curso:1DAM
 * Asignacion: operaciones matematicas
 * */
namespace Operación_Matemática_en_Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            string linea;
            string op;
            do
            {
                Console.WriteLine("dime a el primer numero");
                linea = Console.ReadLine();
            } while (Int32.TryParse(linea, out num1));
            Console.WriteLine("dime el operador");
            op = Console.ReadLine();
            Console.WriteLine("dime el segundo operador");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);
            switch (op)
            {
                case "+":
                    Console.WriteLine(num1 + "+" + num2 + "=" + (num1 + num2));
                    break;
                case "-":
                    Console.WriteLine(num1 + "-" + num2 + "=" + (num1 - num2));
                    break;
                case "*":
                    Console.WriteLine(num1 + "*" + num2 + "=" + (num1 * num2));
                    break;
                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("no se puede dividir por 0");
                    }
                    else
                    {
                        Console.WriteLine(num1 + "/" + num2 + "=" + (num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("El operador que has elegido no es valido");
                    break;
            }

        }
    }
}
