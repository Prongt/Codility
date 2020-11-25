namespace CodilityLessonsCSharp
{
    internal class CountDivSolution
    {
        public int solution(int A, int B, int K)
        {
            // write your code in C# 6.0 with .NET 4.5 (Mono)
            if (A % K == 0)
            {
                return 1 + (B + A % K - A) / K;
            }

            return (B + A % K - A) / K;
        }
    }
}