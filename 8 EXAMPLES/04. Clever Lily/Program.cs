using System;

namespace _04._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем възрастта на Лили
            int age = int.Parse(Console.ReadLine());
            //цената пералнята
            double washingMachine = double.Parse(Console.ReadLine());
            //цената на всяка от играчките
            double toyPrice = double.Parse(Console.ReadLine());

            double money = 0;

            //пускаме цикъл, който ще се върти от 1вия РД на Лили до последния (вкл.)
            for (int i = 1; i <= age; i++)
            {
                // => за всеки РД => проверяваме дали е получила пари или играчка
                if (i % 2 == 0)
                {
                    //   => ако РД е четен => получава пари => възраста*5 - 1; ( 1 - парите, които брат й взима) 
                    money += i * 5 - 1;
                }
                else
                {
                    //   => ако РД е нечетен => получава играчка 
                    money += toyPrice;
                }
            }

            //Проверяваме дали парите са достатъчно за пералнята
            if (money >= washingMachine)
            {
                Console.WriteLine($"Yes! {money - washingMachine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washingMachine - money:f2}");

            }
        }
    }
}