using System.Collections.Generic;

namespace CodilityLessonsCSharp
{
    internal class DistinctSolution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            HashSet<int> distinctHashSet = new HashSet<int>();

            for (int i = 0; i < A.Length; i++) distinctHashSet.Add(A[i]);

            return distinctHashSet.Count;
        }
    }
}