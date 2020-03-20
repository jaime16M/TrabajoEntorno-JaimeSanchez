using System;
/**
 * Autor:Jaime Sánchez Ortiz
 * Curso:1DAM
 * Asignacion: condiciones compuestas
 * */
namespace Ejercicio_de_condiciones_compuestas
{
    class Program
    {
        static void Main(string[] args)
        {

            byte dia;
            string mes;
            int año;
            string linea;
            Console.WriteLine("Dime el dia:");
            linea = Console.ReadLine();
            dia = byte.Parse(linea);
            Console.WriteLine("Dime el mes:");
            mes = Console.ReadLine();
            Console.WriteLine("Dime el aÃ±o:");
            linea = Console.ReadLine();
            año = int.Parse(linea);

            if (mes.Equals("enero") || mes.Equals("febrero") || mes.Equals("marzo"))
            {
                Console.WriteLine("pertenece al primer trimestre");

            }
        }
}
