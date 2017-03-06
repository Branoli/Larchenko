using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Knuckle
    {
        public int[,] ArrOfKnuckles;

        public int MovingTheKnuckles()
        {
            int q = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Какую костяшку ПО ОНОШЕНИЮ ---К НУЛЮ---, передвинуть ");
                Console.ForegroundColor = ConsoleColor.White;
                q = Convert.ToInt32(Console.ReadLine());

            } while (CheckTheKnuckles(q) != true);
            int x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    if (ArrOfKnuckles[i, j] == q)
                    {
                        for (int n = 0; n < ArrOfKnuckles.GetLength(0); n++)
                        {
                            for (int k = 0; k < ArrOfKnuckles.GetLength(1); k++)
                            {
                                if (ArrOfKnuckles[n, k] == 0)
                                {
                                    
                                    ArrOfKnuckles[i, j] = 0;
                                    ArrOfKnuckles[n, k] = q;
                                    x++;
                                    break;
                                }
                            }
                            if (x == 1) break;
                        }
                        if (x == 1) break;
                    }
                    if (x == 1) break;
                }
                if (x == 1) break;
            }
            return q;
        }
        public bool CheckTheKnuckles(int q)
        {
            int x = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {
                    if (ArrOfKnuckles[i, j] == 0)
                    {
                        //----------------===
                        if (ArrOfKnuckles[0, 0] == 0)
                        {
                            if ((ArrOfKnuckles[0, 0 + 1] == q || ArrOfKnuckles[0 + 1, 0] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[0, ArrOfKnuckles.GetLength(1) - 1] == 0)
                        {
                            if (ArrOfKnuckles[0, (ArrOfKnuckles.GetLength(1) - 1) - 1] == q || ArrOfKnuckles[0 + 1, (ArrOfKnuckles.GetLength(1) - 1)] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if ((ArrOfKnuckles[(ArrOfKnuckles.GetLength(0) - 1), 0]) == 0)
                        {
                            if (ArrOfKnuckles[(ArrOfKnuckles.GetLength(0) - 1), 0 + 1] == q || ArrOfKnuckles[(ArrOfKnuckles.GetLength(0) - 1) - 1, 0] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[(ArrOfKnuckles.GetLength(0) - 1), (ArrOfKnuckles.GetLength(1) - 1)] == 0)
                        {
                            if (ArrOfKnuckles[(ArrOfKnuckles.GetLength(0) - 1), (ArrOfKnuckles.GetLength(1) - 1) - 1] == q || ArrOfKnuckles[(ArrOfKnuckles.GetLength(0) - 1) - 1, (ArrOfKnuckles.GetLength(1) - 1)] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        //----------------===
                        if (ArrOfKnuckles[0, j] == 0)
                        {
                            if (ArrOfKnuckles[0, 0] != 0 || ArrOfKnuckles[0, ArrOfKnuckles.GetLength(1) - 1] != 0)
                            {
                                if (ArrOfKnuckles[i + 1, j] == q || ArrOfKnuckles[i, j + 1] == q || ArrOfKnuckles[i, j - 1] == q)
                                {
                                    x++;
                                    break;
                                }
                                break;
                            }
                        }
                        if (ArrOfKnuckles[i, 0] == 0)
                        {
                            if (ArrOfKnuckles[i, 0] != 0 || ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, 0] != 0)
                            {
                                if (ArrOfKnuckles[i, j + 1] == q || ArrOfKnuckles[i + 1, j] == q || ArrOfKnuckles[i - 1, j] == q)
                                {
                                    x++;
                                    break;
                                }
                                break;
                            }
                        }
                        if (ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, j] == 0)
                        {
                            if (ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, j] != 0 || ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, ArrOfKnuckles.GetLength(1) - 1] != 0)
                            {
                                if (ArrOfKnuckles[i - 1, j] == q || ArrOfKnuckles[i, j + 1] == q || ArrOfKnuckles[i, j - 1] == q)
                                {
                                    x++;
                                    break;
                                }
                                break;
                            }
                        }
                        if (ArrOfKnuckles[i, ArrOfKnuckles.GetLength(1) - 1] == 0)
                        {
                            if (ArrOfKnuckles[i, ArrOfKnuckles.GetLength(1) - 1] != 0 || ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, ArrOfKnuckles.GetLength(1) - 1] != 0)
                            {
                                if (ArrOfKnuckles[i - 1, j] == q || ArrOfKnuckles[i + 1, j] == q || ArrOfKnuckles[i, j - 1] == q)
                                {
                                    x++;
                                    break;
                                }
                            }
                            break;
                        }
                        //------------------
                        if (ArrOfKnuckles[0, j] != 0 || ArrOfKnuckles[i, 0] != 0 || ArrOfKnuckles[ArrOfKnuckles.GetLength(0) - 1, j] != 0 || ArrOfKnuckles[i, ArrOfKnuckles.GetLength(1) - 1] != 0)
                        {
                            if (ArrOfKnuckles[i, j - 1] == q || ArrOfKnuckles[i, j + 1] == q || ArrOfKnuckles[i - 1, j] == q || ArrOfKnuckles[i + 1, j] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        //------------------
                        break;
                    }
                }
                if (x > 0)
                {
                    break;
                }
            }
            if (x > 0) return true;
            else return false;
        }
    }
}