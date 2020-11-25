using System.Collections.Generic;

namespace CodilityLessonsCSharp
{
    internal class MissingIntegerSolution
    {
        public int solution(int[] A)
        {
            int minValidInt = 1;
            HashSet<int> hashSet = new HashSet<int>();

            for (int i = 0; i < A.Length; i++)
            {
                if (hashSet.Contains(A[i])) continue;

                hashSet.Add(A[i]);

                if (A[i] == minValidInt)
                    while (hashSet.Contains(++minValidInt))
                    {
                    }
            }

            return minValidInt;
        }
    }
}