namespace _01.EvenNumbersThread
{
    using System;
    using System.Threading;

    public class StartUp
    {
        public static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            Thread evens = new Thread(() => PrintEvenNumbers(startNum, endNum));
            evens.Start();
            evens.Join();
            Console.WriteLine("Thread finished work!");
        }

        private static void PrintEvenNumbers(int startNum, int endNum)
        {
            for (int i = startNum; i <= endNum; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i); 
                }
            }
        }
    }
}
