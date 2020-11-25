using System.Collections.Generic;

namespace CodilityLessonsCSharp
{
    internal class DominatorSolution
    {
        public int solution(int[] A)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            Dictionary<int, int> commonOccurrences = new Dictionary<int, int>();

            foreach (int i in A)
                if (commonOccurrences.ContainsKey(i))
                    commonOccurrences[i]++;
                else
                    commonOccurrences.Add(i, 1);

            int mostCommonValue = 0;
            int highestCount = 0;
            foreach (KeyValuePair<int, int> pair in commonOccurrences)
                if (pair.Value > highestCount)
                {
                    mostCommonValue = pair.Key;
                    highestCount = pair.Value;
                }


            for (int i = 0; i < A.Length; i++)
                if (A[i] == mostCommonValue)
                    return i;

            return -1;
        }
    }
}