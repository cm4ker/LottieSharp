using System.Drawing;
using System.Numerics;
using System.Runtime.InteropServices.WindowsRuntime;
using SharpDX.Mathematics.Interop;

namespace LottieSharp
{
    public static class CastHelper
    {
        public static RawVector2 ToRaw(this Vector2 vector2)
        {
            return new RawVector2(vector2.X, vector2.Y);
        }

        public static RawRectangleF ToRaw(this RectangleF rect)
        {
            return new RawRectangleF(rect.Left, rect.Top, rect.Right, rect.Bottom);
        }

        public static RawColor4 ToRaw(this Color rect)
        {
            return new RawColor4(rect.R, rect.G, rect.B, rect.A);
        }
    }
}