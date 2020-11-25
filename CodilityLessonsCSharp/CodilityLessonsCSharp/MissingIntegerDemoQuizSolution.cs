using System;
using System.Collections.Generic;

namespace CodilityLessonsCSharp
{
    internal class MissingIntegerDemoQuizSolution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            Array.Sort(A);

            int highestValue = A[A.Length - 1];
            int result = 1;

            HashSet<int> hashSet = new HashSet<int>();
            foreach (int i in A) hashSet.Add(i);

            for (int i = 1; i < highestValue + 2; i++)
                if (!hashSet.Contains(i))
                    return i;

            return result;
        }
    }
}