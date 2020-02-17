using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTaskTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstArray = new int[5, 5];
            int[,] secondArray = new int[10, 10];

            MyMatrix.RandMatrix(ref firstArray);

            MyMatrix.PrintMatrix(firstArray);


            Console.WriteLine();


            MyMatrix.RandMatrix(ref secondArray);

            MyMatrix.PrintMatrix(secondArray);



            Console.WriteLine();



            Task taskFirstArray = new Task(() => MyMatrix.IncreaseMatrix(ref firstArray, 2));
            Task taskSecondArray = new Task(() => MyMatrix.IncreaseMatrix(ref firstArray, 2));
            taskSecondArray.Start();
            taskFirstArray.Start();
            taskSecondArray.Wait();
            taskFirstArray.Wait();



            MyMatrix.PrintMatrix(firstArray);

            Console.WriteLine();

            MyMatrix.PrintMatrix(secondArray);

            Console.ReadKey();
        }
    }
}
