using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskTest
{
    class MyMatrix
    {
        static Random rnd = new Random();

        public static void RandMatrix(ref int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = rnd.Next(0, 9);
                }
            }
        }

        public static void IncreaseMatrix(ref int[,] mass, int increase)
        {
            int[,] newMass = new int[mass.GetLength(0) * increase, mass.GetLength(1) * increase];

            RandMatrix(ref newMass);

            mass = newMass;
        }

        public static void PrintMatrix(int[,] mass)
        {
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    Console.Write(mass[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
