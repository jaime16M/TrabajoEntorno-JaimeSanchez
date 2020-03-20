using System;
/**
 * Autor:Jaime Sánchez Ortiz
 * Curso:1DAM
 * Asignacion: try catch
 * */
namespace Try_catch_con_ficheros
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
            new System.IO.StreamReader(@"C:\Users\cenec\PC514despues.txt");
            try
            {

                while ((line = file.ReadLine()) != null)
                {
                    System.Console.WriteLine(line);
                    counter++;
                }
            }
            finally
            {
                file.Close();
                System.Console.WriteLine("There were {0} lines.", counter);
                // Suspend the screen.
                System.Console.ReadLine();
            }
            int cant = 5;
            Console.WriteLine("VECTOR de " + cant + " nÃºmeros ordenados");
            int[] numeros;
            string linea;
            numeros = new int[cant];
            // llena un vector de numeros por pantalla
            Boolean cargando = true;
            int i = 0;
            while (cargando)
            {

                try
                {
                    while (i < numeros.Length)
                    {
                        Console.Write("Ingrese el " + (i + 1) + "Âº nÃºmero:");
                        linea = Console.ReadLine();
                        numeros[i] = Convert.ToInt32(linea);
                        i++;
                    }
                    cargando = false;
                }

                catch (OverflowException errnum)
                {
                    Console.WriteLine("MAL. El nro. debe ser menor que 100");
                    Console.WriteLine(errnum.Message);
                }
                catch (Exception errfatal)
                {
                    Console.WriteLine("PEOR. FATAL. REMAL. El programa finaliza aquÃ­.");
                    Console.WriteLine(errfatal.Message);
                    Environment.Exit(2);
                }
            }
            Array.Sort(numeros);
            foreach (int j in numeros)
            {
                System.Console.Write("{0} ", j);
            }
            Console.Write("Presione una tecla para finalizar");
            linea = Console.ReadLine();

        }
    }
}
