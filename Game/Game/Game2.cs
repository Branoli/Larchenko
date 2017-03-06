using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Game2 : Knuckle
    {
        private int[,] MasOfKnuckle;

        public Game2(int GetLenght)
        {
            this.MasOfKnuckle = new int[GetLenght, GetLenght];
        }
    }
}
