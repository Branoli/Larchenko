using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    static class Print
    {
        public static void PrintMasOfKnuckle(Knuckle game)
        {
            Console.Clear();
            for (int i = 0; i < game.Size; i++)
            {
                for (int j = 0; j < game.Size; j++)
                {

                    if (game[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t{0}", game[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t{0}", game[i, j]);
                    }
                }
                Console.WriteLine();
            }
        }
        public static void PrintQ()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("Какую костяшку ПО ОНОШЕНИЮ ---К НУЛЮ---, передвинуть ");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public static void PrintExseption(int[,] mas)
        {
            Console.WriteLine("В ВАШЕМ ФАЙЛЕ ДОЛЖНЫ БЫТЬ ---ТОЛЬКО--- УНИКАЛЬНЫЕ ЗНАЧЕНИЯЮ, ----ТОЛЬКО--- ЦИФРЫ");
        }
    }
}
