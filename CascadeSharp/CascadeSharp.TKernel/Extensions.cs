using System;

namespace CascadeSharp.TKernel
{
    public static class Extensions
    {
        public static double Sqrt(this double d)
        {
            if (d < 0)
                throw new ArithmeticException("Illegal argument in Sqrt");
            return Math.Sqrt(d);
        }
        public static double Log(this double d)
        {
            if (d < 0)
                throw new ArithmeticException("Illegal argument in Log");
            return Math.Log(d);
        }
        public static double Abs(this double d)
        {
            return Math.Abs(d);
        }
    }
}
