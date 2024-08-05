using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int peopleCount = 0;

            double gr1 = 0;
            double gr2 = 0;
            double gr3 = 0;
            double gr4 = 0;
            double gr5 = 0;

            for (int i = 1; i <= n; i++)
            {
                int group = int.Parse(Console.ReadLine());
                peopleCount += group;

                if (group <= 5)
                {
                    gr1 += group;
                }
                else if (group <= 12)
                {
                    gr2 += group;

                }
                else if (group <= 25)
                {
                    gr3 += group;

                }
                else if (group <= 40)
                {
                    gr4 += group;

                }
                else
                {
                    gr5 += group;

                }
            }

            gr1 = gr1 / peopleCount * 100;
            gr2 = gr2 / peopleCount * 100;
            gr3 = gr3 / peopleCount * 100;
            gr4 = gr4 / peopleCount * 100;
            gr5 = gr5 / peopleCount * 100;


            Console.WriteLine($"{gr1:F2}%");
            Console.WriteLine($"{gr2:F2}%");
            Console.WriteLine($"{gr3:F2}%");
            Console.WriteLine($"{gr4:F2}%");
            Console.WriteLine($"{gr5:F2}%");

        }
    }
}