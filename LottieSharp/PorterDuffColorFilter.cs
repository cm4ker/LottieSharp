﻿using System.Drawing;
using LottieSharp.Animation.Content;
using Brush = SharpDX.Direct2D1.Brush;

namespace LottieSharp
{
    public abstract class PorterDuffColorFilter : ColorFilter
    {
        public Color Color { get; }
        public PorterDuff.Mode Mode { get; }

        protected PorterDuffColorFilter(Color color, PorterDuff.Mode mode)
        {
            Color = color;
            Mode = mode;
        }

        public override Brush Apply(BitmapCanvas dst, Brush brush)
        {
            //var originalColor = Colors.White;
            //if (brush is CompositionColorBrush compositionColorBrush)
            //    originalColor = compositionColorBrush.Color;
            //TODO
            return brush;
        }
    }
}