﻿using System.Numerics;
using LottieSharp.Animation.Content;
using LottieSharp.Model.Animatable;
using LottieSharp.Model.Layer;

namespace LottieSharp.Model.Content
{
    public class CircleShape : IContentModel
    {
        public CircleShape(string name, IAnimatableValue<Vector2?, Vector2?> position, AnimatablePointValue size, bool isReversed)
        {
            Name = name;
            Position = position;
            Size = size;
            IsReversed = isReversed;
        }

        internal string Name { get; }

        public IAnimatableValue<Vector2?, Vector2?> Position { get; }

        public AnimatablePointValue Size { get; }

        public bool IsReversed { get; }

        public IContent ToContent(LottieDrawable drawable, BaseLayer layer)
        {
            return new EllipseContent(drawable, layer, this);
        }
    }
}