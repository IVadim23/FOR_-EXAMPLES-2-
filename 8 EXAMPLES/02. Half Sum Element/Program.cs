using System;

namespace _02._Half_Sum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            //Четем колко числа ще получим от потребителя
            int n = int.Parse(Console.ReadLine());

            //Ще пазим сумата на всички числа, които се въвеждат от потребителя
            int sum = 0;
            //Ще пазим най-голямото число, което е въведено
            int maxNum = int.MinValue; // първоначална стойност: -2147483648
            //Ще пазим числото, което е въведено на момента
            int num;

            //Пускаме цикъл, който да се върти от 1вото до последното число (n)
            for (int i = 1; i <= n; i++)
            {
                //Всеки път четем число от конзолата
                num = int.Parse(Console.ReadLine());

                //Проверявваме дали моментното число не е най-голямото въведено до момента
                if (num > maxNum)
                {
                    //ако е - нашето maxNum = моментното число
                    maxNum = num;
                }

                //Добавяме моментното число към сбора на всички числа
                sum = sum + num;
            }

            //Проверяваме дали най-голямото число е = на сбора на всички ОСТАНАЛИ
            sum = sum - maxNum; //сбор на всички останали числа

            if (sum == maxNum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {maxNum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(sum - maxNum)}");
            }

        }
    }
}