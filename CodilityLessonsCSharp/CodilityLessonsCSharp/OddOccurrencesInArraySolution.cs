using System;

namespace CodilityLessonsCSharp
{
    internal class OddOccurrencesInArraySolution
    {
        public int solution(int[] A)
        {
            Console.WriteLine("Odd Occurrences In Array Solution");
            int numberToReturn = 0;

            for (int i = 0; i < A.Length; i++) numberToReturn ^= A[i];

            return numberToReturn;
        }
    }
}