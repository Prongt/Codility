namespace CodilityLessonsCSharp
{
    internal class CyclicRotationSolution
    {
        public int[] solution(int[] A, int K)
        {
            int temp;

            for (int j = 0; j < K; j++)
            for (int i = 0; i < A.Length - 1; i++)
            {
                temp = A[0];
                A[0] = A[i + 1];
                A[i + 1] = temp;
            }

            return A;
        }
    }
}