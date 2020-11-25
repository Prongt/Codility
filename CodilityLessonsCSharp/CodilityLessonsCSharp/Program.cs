using System;

namespace CodilityLessonsCSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //RunBinaryGapSolution();
            //RunCyclicRotationSolution();
            //RunOddOccurrencesInArraySolution();
            //RunFrogJumpSolution();
            //RunMissingElementSolution();
            //RunMissingIntegerSolution();
            //RunCountDivSolution();
            RunDistinctSolution();
        }

        private static void RunDistinctSolution()
        {
            int[] arr = {2, 1, 1, 2, 3, 1};
            DistinctSolution s = new DistinctSolution();
            Console.WriteLine(s.solution(arr));
        }

        private static void RunCountDivSolution()
        {
            CountDivSolution s = new CountDivSolution();
            Console.WriteLine(s.solution(6, 11, 2));
        }

        private static void RunMissingIntegerSolution()
        {
            int[] arr = {1, 3, 6, 4, 1, 2};
            MissingIntegerSolution s = new MissingIntegerSolution();
            Console.WriteLine(s.solution(arr));
        }

        private static void RunMissingElementSolution()
        {
            Console.WriteLine("Missing Element Solution");
            int[] arr = {2, 3, 1, 5};
            MissingElementSolution s = new MissingElementSolution();
            Console.WriteLine(s.solution(arr));
        }

        private static void RunFrogJumpSolution()
        {
            Console.WriteLine("Frog Jump Solution");
            FrogJumpSolution s = new FrogJumpSolution();
            Console.WriteLine(s.solution(10, 85, 30));
        }

        private static void RunCyclicRotationSolution()
        {
            Console.WriteLine("Cyclic Rotation Solution ");
            CyclicRotationSolution s = new CyclicRotationSolution();
            int[] arr = {3, 8, 9, 7, 6};
            int[] result = s.solution(arr, 3);

            //Input [3, 8, 9, 7, 6] Result [9, 7, 6, 3, 8]
            Console.WriteLine("[{0}]", string.Join(", ", result));
        }

        private static void RunBinaryGapSolution()
        {
            Console.WriteLine("Binary gap solution");
            BinaryGapSolution s = new BinaryGapSolution();
            Console.WriteLine("Expected: 1 Result: " + s.solution(20));
            Console.WriteLine("Expected: 2 Result: " + s.solution(9));
            Console.WriteLine("Expected: 4 Result: " + s.solution(529));
            Console.WriteLine("Expected: 4 Result: " + s.solution(51272));
            Console.WriteLine("Expected: 0 Result: " + s.solution(15));
            Console.WriteLine("Expected: 1 Result: " + s.solution(53));
            Console.WriteLine("Expected: 0 Result: " + s.solution(2147483647));
            Console.WriteLine("Expected: 0 Result: " + s.solution(0));
            Console.WriteLine("Expected: 0 Result: " + s.solution(-1));
            Console.WriteLine("Expected: 0 Result: " + s.solution(32));
        }

        private static void RunOddOccurrencesInArraySolution()
        {
            OddOccurrencesInArraySolution s = new OddOccurrencesInArraySolution();
            int[] arr = {9, 3, 9, 3, 9, 7, 9};
            Console.WriteLine(s.solution(arr));
        }
    }
}