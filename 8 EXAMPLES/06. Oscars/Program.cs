using System;

namespace _06._Oscars
{
    class Program
    {
        static void Main(string[] args)
        {
            //четем име на актьор
            string actorName = Console.ReadLine();
            //четем първоначалните точки
            double points = double.Parse(Console.ReadLine());
            //четем броя на оценяващите
            int n = int.Parse(Console.ReadLine());

            string assessorName = string.Empty; //Ще пазим името на моментния оценяващ
            double assessorPoints = 0; //Ще пазим точките на моментния оценяващ

            //пускаме цикъл, който да се върти от 1вия оценяващ до последния (вкл.)
            for (int i = 1; i <= n; i++)
            {
                // за всеки оценяващ четем име на оценяващия и точки, който дава
                assessorName = Console.ReadLine();
                assessorPoints = double.Parse(Console.ReadLine());

                //към първоначалните точки добавяме сегашните => т. = (дължината на името на оц.*броя точки, които е дал)/2
                points += assessorName.Length * assessorPoints / 2;

                //проверяваме дали е достигнал 1250.5т. => спираме цикъла и отпечатваме поздравления
                if (points >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorName} got a nominee for leading role with {points:f1}!");
                    break;
                }
            }

            //Проверяваме дали точките са по-малко от необходимото
            //  => ако са по-малко => отпечатваме колко точки не му достигат
            if (points < 1250.5)
            {
                Console.WriteLine($"Sorry, {actorName} you need {1250.5 - points:f1} more!");
            }
        }
    }
}