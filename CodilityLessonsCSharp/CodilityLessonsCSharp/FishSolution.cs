using System.Collections.Generic;

namespace CodilityLessonsCSharp
{
    internal class FishSolution
    {
        public int solution(int[] A, int[] B)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)

            int deadFish = 0;
            Stack<int> fishStack = new Stack<int>();

            for (int i = 0; i < A.Length; i++)
                if (B[i] == 1)
                    fishStack.Push(i);
                else
                    while (fishStack.Count > 0)
                    {
                        deadFish++;

                        if (A[i] > A[fishStack.Peek()])
                            fishStack.Pop();
                        else
                            break;
                    }

            return A.Length - deadFish;
        }
    }
}