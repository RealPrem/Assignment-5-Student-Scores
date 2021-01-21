using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_5_Student_Scores
{
    class Student
    {
        private string Name;
        private int Year;
        private int[] Scores = new int[5];

        public Student(string Name, int Year, int S1, int S2, int S3, int S4, int S5)
        {
            this.Name = Name;
            this.Year = Year;
            Scores[0] = S1;
            Scores[1] = S2;
            Scores[2] = S3;
            Scores[3] = S4;
            Scores[4] = S5;
        }
        public Student(string Name, int Year, int[] Scores)
        {
            this.Name = Name;
            this.Year = Year;
            this.Scores = Scores;
        }
        public double FindAverage()
        {
            int Total = 0;
            for(int i = 0; i < Scores.Length; i += 1)
            {
                Total = Total + Scores[i];
            }
            double Average = (double) Total / Scores.Length;
            return Average;
        }
        public int GetHighest()
        {
            int Highest = Scores[0];
            for(int i = 0; i < Scores.Length; i += 1)
            {
                if (Scores[i] > Highest) Highest = Scores[i];
            }
            return Highest;
        }
        public int GetLowest()
        {
            int Lowest = Scores[0];
            for(int i = 0; i < Scores.Length; i += 1)
            {
                if (Scores[i] < Lowest) Lowest = Scores[i];
            }
            return Lowest;
        }
        public int[] GetScores()
        {
            return Scores;
        }
    }
}
