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
        public Knuckle(int GetLenght)
        {
            this.ArrOfKnuckles = new int[GetLenght, GetLenght];
            this.ArrOfKnuckles = ArrOfKnuckle(GetLenght);
            RandomGen();
            PrintOfKnuckles();
        }

        public int[,] ArrOfKnuckle(int GetLenght)
        {
            int[,] mas = new int[GetLenght, GetLenght];
            int x = 0;
            for (int i = 0; i < GetLenght; i++)
            {
                for (int j = 0; j < GetLenght; j++)
                {
                    mas[i, j] = x;
                    x++;
                }
            }
            return mas;
        }
        public void PrintOfKnuckles()
        {
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(0); j++)
                {

                    if (this.ArrOfKnuckles[i, j] == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("\t{0}", this.ArrOfKnuckles[i, j]);

                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\t{0}", this.ArrOfKnuckles[i, j]);
                    }
                }
                Console.WriteLine();
            }
            MovingTheKnuckles();
        }
        public int[,] MovingTheKnuckles()
        {
            int q = 0;
            do
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Какую костяшку, по отношению к нулю, передвинуть ");
                Console.ForegroundColor = ConsoleColor.White;
                q = Convert.ToInt32(Console.ReadLine());

            } while (CheckTheKnuckles(q) != true);

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
                                    Console.Clear();
                                    ArrOfKnuckles[i, j] = 0;
                                    ArrOfKnuckles[n, k] = q;
                                    PrintOfKnuckles();
                                }
                            }
                        }
                    }
                }
            }
            return ArrOfKnuckles;
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






















                        
                        //------------------
                        if (ArrOfKnuckles[1, 0] == 0)
                        {
                            if ((ArrOfKnuckles[1, 0 + 1] == q || ArrOfKnuckles[1 + 1, 0] == q || ArrOfKnuckles[1 - 1, 0] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[1, 3] == 0)
                        {
                            if ((ArrOfKnuckles[1, 3 - 1] == q || ArrOfKnuckles[1 - 1, 3] == q || ArrOfKnuckles[1 + 1, 3] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }

                        if (ArrOfKnuckles[2, 0] == 0)
                        {
                            if ((ArrOfKnuckles[2, 0 + 1] == q || ArrOfKnuckles[2 + 1, 0] == q || ArrOfKnuckles[2 - 1, 0] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[2, 3] == 0)
                        {
                            if ((ArrOfKnuckles[2, 3 - 1] == q || ArrOfKnuckles[2 - 1, 3] == q || ArrOfKnuckles[2 + 1, 3] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }

                        if (ArrOfKnuckles[3, 2] == 0)
                        {
                            if ((ArrOfKnuckles[3 - 1, 2] == q || ArrOfKnuckles[3, 2 + 1] == q || ArrOfKnuckles[3, 2 - 1] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[0, 2] == 0)
                        {
                            if ((ArrOfKnuckles[0 + 1, 2] == q || ArrOfKnuckles[0, 2 + 1] == q || ArrOfKnuckles[0, 2 - 1] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }

                        if (ArrOfKnuckles[3, 1] == 0)
                        {
                            if ((ArrOfKnuckles[3 - 1, 1] == q || ArrOfKnuckles[3, 1 + 1] == q || ArrOfKnuckles[3, 1 - 1] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[0, 1] == 0)
                        {
                            if ((ArrOfKnuckles[0 + 1, 1] == q || ArrOfKnuckles[0, 1 - 1] == q || ArrOfKnuckles[0, 1 + 1] == q))
                            {
                                x++;
                                break;
                            }
                            break;
                        }

                        //------------------
                        if (ArrOfKnuckles[1, 1] == 0)
                        {
                            if (ArrOfKnuckles[1, 1 - 1] == q || ArrOfKnuckles[1, 1 + 1] == q || ArrOfKnuckles[1 - 1, 1] == q || ArrOfKnuckles[1 + 1, 1] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[1, 2] == 0)
                        {
                            if (ArrOfKnuckles[1, 2 - 1] == q || ArrOfKnuckles[1, 2 + 1] == q || ArrOfKnuckles[1 - 1, 2] == q || ArrOfKnuckles[1 + 1, 2] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[2, 1] == 0)
                        {
                            if (ArrOfKnuckles[2, 1 - 1] == q || ArrOfKnuckles[2, 1 + 1] == q || ArrOfKnuckles[2 - 1, 1] == q || ArrOfKnuckles[2 + 1, 1] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        if (ArrOfKnuckles[2, 2] == 0)
                        {
                            if (ArrOfKnuckles[2, 2 - 1] == q || ArrOfKnuckles[2, 2 + 1] == q || ArrOfKnuckles[2 - 1, 2] == q || ArrOfKnuckles[2 + 1, 2] == q)
                            {
                                x++;
                                break;
                            }
                            break;
                        }
                        //------
                        break;
                    }
                }
            }
            if (x > 0) return true;
            else return false;
        }
        public void RandomGen()
        {
            Random gen = new Random();
            int x = 0, z = 0, c = 0;
            for (int i = 0; i < ArrOfKnuckles.GetLength(0); i++)
            {
                for (int j = 0; j < ArrOfKnuckles.GetLength(1); j++)
                {

                    z = gen.Next(0, (ArrOfKnuckles.GetLength(0) - 1));
                    c = gen.Next(0, (ArrOfKnuckles.GetLength(1) - 1));


                    x = ArrOfKnuckles[i, j];
                    ArrOfKnuckles[i, j] = ArrOfKnuckles[z, c];
                    ArrOfKnuckles[z, c] = x;

                }
            }
        }
    }
}