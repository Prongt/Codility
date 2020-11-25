using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityLessonsCSharp
{
    internal class BinaryGapSolution
    {
        public int solution(int N)
        {
            if (N == 0) return 0;

            string binary = Convert.ToString(N, 2);
            string[] gapsArray = binary.Split('1');
            List<string> gapsList = new List<string>();

            foreach (string currentString in gapsArray)
                if (!string.IsNullOrWhiteSpace(currentString))
                    gapsList.Add(currentString);

            if (binary[binary.Length - 1] != '1') gapsList.RemoveAt(gapsList.Count - 1);

            if (gapsList.Count == 0) return 0;

            return gapsList.Max(currentString => currentString.Length);
        }
    }
}