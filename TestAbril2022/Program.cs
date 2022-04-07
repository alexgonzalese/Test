using System;

namespace TestAbril2022
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] Arra1;
            int[] Arra2;
            Arra1 = new[] { 1, 2, 3, 4, 5, 6 };
            Arra2 = new[] { 1, 2, 3, 4, 5, 6 };

            var Status = testArray.SumArray(Arra1, Arra2);

            Console.WriteLine(Status);

        }
    }
}
