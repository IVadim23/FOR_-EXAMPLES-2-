using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double firstPonts = double.Parse(Console.ReadLine());
            double points = 0;
            int wonCount = 0;

            for (int i = 1; i <= n; i++)
            {
                string stage = Console.ReadLine();

                if (stage == "W")
                {
                    points += 2000;
                    wonCount += 1;
                }
                else if (stage == "F")
                {
                    points += 1200;
                }
                else
                {
                    points += 720;
                }
            }

            double averagePoints = (double)points / n;
            double wonPercentage = ((double)wonCount / n) * 100;

            Console.WriteLine($"Final points: {points + firstPonts}");
            Console.WriteLine($"Average points: {Math.Floor(averagePoints)}");
            Console.WriteLine($"{wonPercentage:F2}%");
        }
    }
}
