using System;
using System.Collections.Generic;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list
            List<int> randomNumList = new List<int>();

            // Populate the list with 20 random integers between 1 and 50
            Random random = new Random();
            for (int i = 1; i <= 20; i++)
            {
                var randomGenNumber = random.Next(1, 50);
                randomNumList.Add(randomGenNumber);
            }
            string randomNums = string.Join(", ", randomNumList.ToArray());
            Console.WriteLine(randomNums);

            // Populate new list with squared numbers from above
            List<int> squaredRandomNums = new List<int>();
            foreach (var randomNum in randomNumList)
            {
                var squaredNum = randomNum * randomNum;
                squaredRandomNums.Add(squaredNum);
            }
            string squaredNums = string.Join(", ", squaredRandomNums.ToArray());
            Console.WriteLine(squaredNums);

            // Remove odd numbers from final squared numbers list
            squaredRandomNums.RemoveAll(i => i % 2 != 0);
            string evenSquaredNums = string.Join(", ", squaredRandomNums.ToArray());
            Console.WriteLine(evenSquaredNums);
        }
    }
}
