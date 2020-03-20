using System;
/**
 * Autor:Jaime Sánchez Ortiz
 * Curso:1DAM
 * Asignacion: pintar consola
 * */
namespace Pintar_cosola
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            ConsoleColor[] colors = (ConsoleColor[])ConsoleColor.GetValues(typeof(ConsoleColor));
            ConsoleColor currentBackground = Console.BackgroundColor;
            ConsoleColor currentForeground = Console.ForegroundColor;
            for (int i = 0; i < 24; i++)
            {
                for (int j = 0; j < 80; j++)
                {

                    char[] caracter = { 'a', 'b', 'c', 'd' };

                    foreach (var color in colors)
                    {
                        if (color == currentBackground) continue;

                        Console.ForegroundColor = color;
                        Console.SetCursorPosition(rnd.Next(80), rnd.Next(24));
                        Console.WriteLine(caracter[rnd.Next(4)]);
                    }
                }
                Console.SetCursorPosition(81, 25);

            }
        }
    }
}
