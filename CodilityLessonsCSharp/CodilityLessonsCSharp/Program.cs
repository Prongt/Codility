using System;

namespace CodilityLessonsCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            RunBinaryGapSolution();
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
    }
}