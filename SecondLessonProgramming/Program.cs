using System;

namespace SecondLessonProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            byte var1;
            byte var2;

            var2 = byte.Parse(Console.ReadLine());
            var1 = 45;

            int sum = var1 + var2;
            Console.WriteLine(sum);

            Console.ReadLine();
        }
    }
}
