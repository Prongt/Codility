﻿using System;

namespace CodilityLessonsCSharp
{
    internal class FrogJumpSolution
    {
        public int solution(int X, int Y, int D)
        {
            return (int) Math.Ceiling((double) (Y - X) / D);
        }
    }
}