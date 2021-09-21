using System;

namespace Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Здравствуйте, вас приветствует математическая программа.");
            Console.WriteLine("Пожалуйста введите число. ");

            string userData = Console.ReadLine();

            int number;
            bool result = int.TryParse(userData, out number);

            if (!result)
            {
                Console.WriteLine("Неверный формат введенных данных");
                Console.ReadLine();
                return;
            }
            
            int factorial = 1; 
            int sum = 0;
            int previousEvenNumber = 0;

            for (int i = 1; i <= number; i++)
            {
                factorial = factorial * i;
                sum = sum + i;
                if (i % 2 == 0)
                {
                    previousEvenNumber = i;
                }
            }
            Console.WriteLine("Факториал равен " + factorial); 
            Console.WriteLine("Сумма от 1 до N равна " + sum);
            Console.WriteLine("Максимальное четное число меньше N равно " + previousEvenNumber);
            Console.ReadLine();
        }
    }
}
