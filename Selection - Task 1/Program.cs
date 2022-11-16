using System;

namespace Selection___Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            int age;

            Console.WriteLine("Are you in Education");
            userInput = Console.ReadLine();

            if (userInput == "Yes")//Students
            {
                Console.WriteLine("10% Discount");
            }

            else
            {
                Console.WriteLine("No Education Discount");
            }

            Console.WriteLine("Please enter your age?");
            age = int.Parse(Console.ReadLine());
            
            if (age < 18 && age > 5)//Teenagers and preteens
            {
                Console.WriteLine("15% Discount");
            }

            if (age >= 70)//Elders
            {
                Console.WriteLine("Free Travel");
            }

            if (age < 5)//Toddlers
            {
                Console.WriteLine("50% Discount");
            }

            if (age > 18 && age < 25)//Young adults
            {
                Console.WriteLine("5% Discount");
            }
        }
    }
}
