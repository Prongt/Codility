using System;
using System.Collections.Generic;
using System.Linq;

namespace CodilityLessonsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //RunBinaryGapSolution();
            //RunCyclicRotationSolution();
            //RunOddOccurrencesInArraySolution();
            RunFrogJumpSolution();
        }

        private static void RunFrogJumpSolution()
        {
            FrogJumpSolution s = new FrogJumpSolution();
            Console.WriteLine(s.solution(10, 85, 30));
        }

        private static void RunCyclicRotationSolution()
        {
            Console.WriteLine("Cyclic Rotation Solution ");
            CyclicRotationSolution s = new CyclicRotationSolution();
            int[] arr = new int[] {3, 8, 9, 7, 6};
            var result = s.solution(arr, 3);

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
            int[] arr = new int[] {9, 3, 9, 3, 9, 7, 9};
            Console.WriteLine(s.solution(arr));

        }
    }
}