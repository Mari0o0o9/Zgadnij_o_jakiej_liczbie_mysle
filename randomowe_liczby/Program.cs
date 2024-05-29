using System;

namespace randomNumber
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Zgadnij o jakiej liczbie myślę!!! (1-100)");
            
            var random = new Random();
            var number = random.Next(1, 101);
            var userInput = 0;
            
            while (userInput != number)
            {
                userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput > number)
                {
                    Console.WriteLine("Moja liczba jest mniejsza :3");
                }
                if (userInput < number)
                {
                    Console.WriteLine("Moja liczba jest wieksza :3");
                }
                if (userInput == number) 
                {
                    Console.WriteLine("Udało ci sie odgadnąć :3!!!");
                }
            }
        }
    }
}
