using System;
using System.Runtime.InteropServices;

namespace GameMath
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix4x4
    {
        public float M11;

        public float M12;

        public float M13;

        public float M14;

        public float M21;

        public float M22;

        public float M23;

        public float M24;

        public float M31;

        public float M32;

        public float M33;

        public float M34;

        public float M41;

        public float M42;

        public float M43;

        public float M44;

        public Vector2 WorldToScreen(Vector3 vec, Vector2 screenSize)
        {
            return WorldToScreen(vec, screenSize.X, screenSize.Y);
        }

        public Vector2 WorldToScreen(Vector3 vec, float sizeX, float sizeY)
        {
            Vector2 returnVector = new Vector2(0, 0);
            float w = M41 * vec.X + M42 * vec.Y + M43 * vec.Z + M44;
            if (w >= 0.01f)
            {
                float inverseX = 1f / w;
                returnVector.X =
                    (sizeX / 2f) +
                    (0.5f * (
                    (M11 * vec.X + M12 * vec.Y + M13 * vec.Z + M14)
                    * inverseX)
                    * sizeX + 0.5f);
                returnVector.Y =
                    (sizeY / 2f) -
                    (0.5f * (
                    (M21 * vec.X + M22 * vec.Y + M23 * vec.Z + M24)
                    * inverseX)
                    * sizeY + 0.5f);
            }
            return returnVector;
        }

        public Vector3 GetLeft()
        {
            return GetRight() * (-1f);
        }

        public Vector3 GetRight()
        {
            return new Vector3(M11, M21, M31);
        }

        public Vector3 GetUp()
        {
            return new Vector3(M12, M22, M33);
        }

        public Vector3 GetDown()
        {
            return GetUp() * (-1f);
        }

        public Vector3 GetForward()
        {
            return GetBackward() * (-1f);
        }

        public Vector3 GetBackward()
        {
            return new Vector3(M13, M23, M33);
        }
    }
}
