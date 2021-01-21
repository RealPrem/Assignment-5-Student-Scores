using System;

namespace Assignment_5_Student_Scores
{
    class Program
    {
        static void Main(string[] args)
        {
            Student Prem = new Student("Prem", 12, 5, 5, 5, 6, 4);
            int[] PremScores = Prem.GetScores();
            for (int i = 0; i < PremScores.Length; i += 1)
            {
                Console.WriteLine(PremScores[i]);
            }
            int[] InnScores = { 1, 2, 2, 1, 3 };
            Student Inn = new Student("Inn", 12, InnScores);
            Console.WriteLine(Inn.GetHighest());
        }
    }
}
