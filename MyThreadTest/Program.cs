using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MyThreadTest
{
    class Program
    {
        static Mutex resetEvent = new Mutex();
        static void Main(string[] args)
        {
            Thread threadFactorial = new Thread(Factorial);
            threadFactorial.Name = "Факториал";
            threadFactorial.Priority = ThreadPriority.Highest;
            threadFactorial.Start();

            Thread threadSum = new Thread(Sum);
            threadSum.Name = "Сумма чисел";
            threadSum.Priority = ThreadPriority.Lowest;
            threadSum.Start();
        }


        public static void Factorial()
        {
            resetEvent.WaitOne();
            Console.Write("Введите число факториала: ");
            int num = int.Parse(Console.ReadLine());

            int length = num;
            for (int i = 1; i < length; i++)
            {
                num *= i;
            }
            Console.WriteLine("Результат факториала = {0}", num);
            resetEvent.ReleaseMutex();
        }


        public static void Sum()
        {
            resetEvent.WaitOne();
            Console.Write("Введите число, до которого производить сумму: ");
            int length = int.Parse(Console.ReadLine());

            int result = 0;
            for (int i = 0; i <= length; i++)
            {
                result += i;
            }
            Console.WriteLine("Результат = {0}", result);
            resetEvent.ReleaseMutex();
        }
    }
}
