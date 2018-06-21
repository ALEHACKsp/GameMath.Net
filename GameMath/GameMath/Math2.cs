using System;
using System.Runtime.CompilerServices;

namespace GameMath
{
    public static class Math2
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static double DistanceInCircle(Vector2 point, Vector2 circleCenter)
        {
            return Math.Sqrt(((circleCenter.X - point.X) * (circleCenter.X - point.X)) + ((circleCenter.Y - point.Y) * (circleCenter.Y - point.Y)));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DistanceOnScreen(float X, float Y, Vector2 screen)
        {
            return (float)Math.Sqrt(Math.Pow((Y - screen.Y / 2), 2) + Math.Pow((X - screen.X / 2), 2));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool IsPointInCircle(Vector2 point, Vector2 circleCenter, int radius)
        {
            return Math.Sqrt(((circleCenter.X - point.X) * (circleCenter.X - point.X)) + ((circleCenter.Y - point.Y) * (circleCenter.Y - point.Y))) < radius;
        }
    }
}
