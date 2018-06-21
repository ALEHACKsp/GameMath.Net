using System;
using System.Runtime.CompilerServices;

namespace GameMath
{
    public static class MathEx
    {
        private static Random rng = new Random();

        public static readonly float DEG_2_RAD = (float)(Math.PI / 180f);
        public static readonly float RAD_2_DEG = (float)(180.0f / Math.PI);

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Clamp(float value, float min, float max)
        {
            if (value < min) return min;
            if (value > max) return max;
            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float DegreesToRadians(float deg) { return (deg * DEG_2_RAD); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Normalize(float value, float min, float max)
        {
            float norm = max < 0.0f ? max * -1.0f : max;

            while (value < min)
                value += norm;
            while (value > max)
                value -= norm;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float Normalize(float value, float min, float max, float norm)
        {
            while (value < min)
                value += norm;
            while (value > max)
                value -= norm;

            return value;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RadiansToDegrees(float rad) { return (rad * RAD_2_DEG); }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static float RandomFloat(float min, float max)
        {
            return ((float)rng.NextDouble() * (max - min)) + min;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static int RandomInt(int min, int max)
        {
            return rng.Next(min, max);
        }
    }
}
