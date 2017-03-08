using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Print
    {
        public static void PrintMasOfKnuckle(int[,] mas)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
            {
                for (int j = 0; j < mas.GetLength(0); j++)
                {

                    if (mas[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t{0}", mas[i, j]);
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t{0}", mas[i, j]);
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
