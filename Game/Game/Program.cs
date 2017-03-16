using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {




            //do
            //{
                Knuckle game = new Knuckle(Reader.Readerr("d:\\MasOfKnuckle.txt"));
                Print.PrintMasOfKnuckle(game);
                Print.PrintQ();
                game.MovingTheKnuckles(4);
            //} while (game.CheckWin == false);
            
            Console.ReadKey();
        }
    }
}
