using System;
using System.Linq;

namespace CodilityLessonsCSharp
{
    class MissingElementSolution
    {
        public int solution(int[] A)
        {
            Array.Sort(A);

            int[] orderedArray = new int [A.Length +1];

            for (int i = 0; i < orderedArray.Length; i++)
            {
                orderedArray[i] = i + 1;
            }
            return orderedArray.Except(A).ToArray()[0];
        }
        
    }
}