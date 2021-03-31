using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.prectice1
{
    class Program
    {
        static int GetHigestScore(int[] score)
        {
            int maxValue = 0;
            foreach (int scores in score)
            {
                if (maxValue<= scores)
                {
                    maxValue = scores;
                }
            }
            return maxValue;
        }
        static int GetAverageScore(int[] score)
        {
            int AverageValue = 0;

            foreach (int scores in score)
            {
                AverageValue += scores;
            }
            if (score.Length == 0)
            {
                return 0;
            }
            AverageValue = AverageValue / score.Length;

            return AverageValue;
        }

        static int GetIndexof(int[] score, int value)
        {
            
            for (int i = 0; i < score.Length; i++)
            {
                if (score[i]==value)
                {
                    return i;
                }
            }
            return -1;
        }

        static void Sort(int[] Score)
        {
            for (int i = 0; i < Score.Length; i++)
            {
                //i~sores.length-1 까지 제일 작은 숫자의 index를 찾는다.
                int minIndex = i;
                for (int j = i; j < Score[minIndex]; j++)
                {
                    if (Score[j]<Score[minIndex])
                    {
                        minIndex = j;
                    }
                    
                }
                //swap
                int temp = Score[i];
                Score[i] = Score[minIndex];
                Score[minIndex] = temp;

            }
        }

        static void Main(string[] args)
        {
            int[] scores = new int[5] { 10, 50, 30, 40, 20 };

            Console.WriteLine(GetHigestScore(scores));

            GetIndexof(scores, 20);
        }
    }
}
