﻿// <auto-generated>
// Do not edit this file yourself!
//
// This code was generated by Xenko Shader Mixin Code Generator.
// To generate it yourself, please install Xenko.VisualStudio.Package .vsix
// and re-save the associated .xkfx.
// </auto-generated>

using System;
using Xenko.Core;
using Xenko.Rendering;
using Xenko.Graphics;
using Xenko.Shaders;
using Xenko.Core.Mathematics;
using Buffer = Xenko.Graphics.Buffer;

namespace Xenko.Rendering.Voxels.Debug
{
    public static partial class VoxelVisualizationViewShaderKeys
    {
        public static readonly ValueParameterKey<Vector4> background = ParameterKeys.NewValue<Vector4>();
        public static readonly ValueParameterKey<Matrix> view = ParameterKeys.NewValue<Matrix>();
        public static readonly ValueParameterKey<Matrix> viewInv = ParameterKeys.NewValue<Matrix>();
    }
}
