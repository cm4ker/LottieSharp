﻿//   Copyright 2018 yinyue200.com

//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.
using System;
using SkiaSharp;

namespace LottieUWP
{
    public static class RectExt
    {
        public static void Set(ref SKRect rect, float left, float top, float right, float bottom)
        {
            rect.Left = left;
            rect.Top = top;
            rect.Size = new SKSize(Math.Abs(right - left), Math.Abs(bottom - top));
        }

        public static void Set(ref SKRect rect, SKRect newRect)
        {
            rect.Left = newRect.Left;
            rect.Top = newRect.Top;
            rect.Size = new SKSize( newRect.Width, newRect.Height);
        }
    }
}
