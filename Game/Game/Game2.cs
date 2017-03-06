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
        public int[,] MasOfKnuckles()
        {
            int x = 0;
            for (int i = 0; i < MasOfKnuckle.GetLength(0); i++)
            {
                for (int j = 0; j < MasOfKnuckle.GetLength(1); j++)
                {
                    MasOfKnuckle[i, j] = x;
                    x++;
                }
            }
            return MasOfKnuckle;
        }
    }
}
