using System;
using System.Runtime.InteropServices;

namespace GameMath
{
    [StructLayout(LayoutKind.Sequential)]
    public struct Matrix3x4
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
