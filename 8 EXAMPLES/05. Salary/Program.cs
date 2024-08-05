using System;

namespace _05._Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            //Четем брой отворени табове
            int n = int.Parse(Console.ReadLine());
            //Четем заплата
            int salary = int.Parse(Console.ReadLine());

            string site = string.Empty;
            //Пускаме цикъл, който да се върти от 1вия отворен таб до последния (вкл.)
            for (int i = 1; i <= n; i++)
            {
                //     => за всеки отворен таб => четем името на сайт, който е отворен в таба
                site = Console.ReadLine();

                //=> ако сайта е "Facebook" =  глоба = 150лв.
                if (site == "Facebook")
                {
                    salary -= 150;
                }
                // => ако сайта е "Instagram" =  глоба = 100лв.
                else if (site == "Instagram")
                {
                    salary -= 100;
                }
                // => ако сайта е "Reddit" =  глоба = 50лв.
                else if (site == "Reddit")
                {
                    salary -= 50;
                }
                //     => след начислена глоба проверяваме
                //      => aко глобата стане >= заплатата => спираме да четем повече сайтове и отпечатваме, че заплатата е свършила

                if (salary <= 0)
                {
                    Console.WriteLine("You have lost your salary.");
                    break;
                }

            }

            //Проверяваме дали е останала заплата
            //      => ако е: на конзолата се изписва остатъкът от заплатата (да се изпише като цяло число).
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
        }
    }
}
