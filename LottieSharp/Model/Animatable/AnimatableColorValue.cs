﻿using System.Collections.Generic;
using System.Drawing;
using LottieSharp.Value;
using LottieSharp.Animation.Keyframe;

namespace LottieSharp.Model.Animatable
{
    public class AnimatableColorValue : BaseAnimatableValue<Color?, Color?>
    {
        public AnimatableColorValue(List<Keyframe<Color?>> keyframes) : base(keyframes)
        {
        }

        public override IBaseKeyframeAnimation<Color?, Color?> CreateAnimation()
        {
            return new ColorKeyframeAnimation(Keyframes);
        }
    }
}