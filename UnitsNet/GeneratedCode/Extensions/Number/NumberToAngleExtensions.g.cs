﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyUnit.extra.cs files to add code to generated quantities.
//     Add Extensions\MyUnitExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyUnit.json and run GeneratUnits.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
// https://github.com/angularsen/UnitsNet
// 
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
// 
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;

// Windows Runtime Component does not support extension methods and method overloads: https://msdn.microsoft.com/en-us/library/br230301.aspx
#if !WINDOWS_UWP
namespace UnitsNet.Extensions.NumberToAngle
{
    public static class NumberToAngleExtensions
    {
        #region Arcminute

        /// <inheritdoc cref="Angle.FromArcminutes(double)"/>
        public static Angle Arcminutes(this int value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double?)"/>
        public static Angle? Arcminutes(this int? value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double)"/>
        public static Angle Arcminutes(this long value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double?)"/>
        public static Angle? Arcminutes(this long? value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double)"/>
        public static Angle Arcminutes(this double value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double?)"/>
        public static Angle? Arcminutes(this double? value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double)"/>
        public static Angle Arcminutes(this float value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double?)"/>
        public static Angle? Arcminutes(this float? value) => Angle.FromArcminutes(value);

        /// <inheritdoc cref="Angle.FromArcminutes(double)"/>
        public static Angle Arcminutes(this decimal value) => Angle.FromArcminutes(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromArcminutes(double?)"/>
        public static Angle? Arcminutes(this decimal? value) => Angle.FromArcminutes(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Arcsecond

        /// <inheritdoc cref="Angle.FromArcseconds(double)"/>
        public static Angle Arcseconds(this int value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double?)"/>
        public static Angle? Arcseconds(this int? value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double)"/>
        public static Angle Arcseconds(this long value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double?)"/>
        public static Angle? Arcseconds(this long? value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double)"/>
        public static Angle Arcseconds(this double value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double?)"/>
        public static Angle? Arcseconds(this double? value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double)"/>
        public static Angle Arcseconds(this float value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double?)"/>
        public static Angle? Arcseconds(this float? value) => Angle.FromArcseconds(value);

        /// <inheritdoc cref="Angle.FromArcseconds(double)"/>
        public static Angle Arcseconds(this decimal value) => Angle.FromArcseconds(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromArcseconds(double?)"/>
        public static Angle? Arcseconds(this decimal? value) => Angle.FromArcseconds(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Centiradian

        /// <inheritdoc cref="Angle.FromCentiradians(double)"/>
        public static Angle Centiradians(this int value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double?)"/>
        public static Angle? Centiradians(this int? value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double)"/>
        public static Angle Centiradians(this long value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double?)"/>
        public static Angle? Centiradians(this long? value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double)"/>
        public static Angle Centiradians(this double value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double?)"/>
        public static Angle? Centiradians(this double? value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double)"/>
        public static Angle Centiradians(this float value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double?)"/>
        public static Angle? Centiradians(this float? value) => Angle.FromCentiradians(value);

        /// <inheritdoc cref="Angle.FromCentiradians(double)"/>
        public static Angle Centiradians(this decimal value) => Angle.FromCentiradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromCentiradians(double?)"/>
        public static Angle? Centiradians(this decimal? value) => Angle.FromCentiradians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Deciradian

        /// <inheritdoc cref="Angle.FromDeciradians(double)"/>
        public static Angle Deciradians(this int value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double?)"/>
        public static Angle? Deciradians(this int? value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double)"/>
        public static Angle Deciradians(this long value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double?)"/>
        public static Angle? Deciradians(this long? value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double)"/>
        public static Angle Deciradians(this double value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double?)"/>
        public static Angle? Deciradians(this double? value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double)"/>
        public static Angle Deciradians(this float value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double?)"/>
        public static Angle? Deciradians(this float? value) => Angle.FromDeciradians(value);

        /// <inheritdoc cref="Angle.FromDeciradians(double)"/>
        public static Angle Deciradians(this decimal value) => Angle.FromDeciradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromDeciradians(double?)"/>
        public static Angle? Deciradians(this decimal? value) => Angle.FromDeciradians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Degree

        /// <inheritdoc cref="Angle.FromDegrees(double)"/>
        public static Angle Degrees(this int value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double?)"/>
        public static Angle? Degrees(this int? value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double)"/>
        public static Angle Degrees(this long value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double?)"/>
        public static Angle? Degrees(this long? value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double)"/>
        public static Angle Degrees(this double value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double?)"/>
        public static Angle? Degrees(this double? value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double)"/>
        public static Angle Degrees(this float value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double?)"/>
        public static Angle? Degrees(this float? value) => Angle.FromDegrees(value);

        /// <inheritdoc cref="Angle.FromDegrees(double)"/>
        public static Angle Degrees(this decimal value) => Angle.FromDegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromDegrees(double?)"/>
        public static Angle? Degrees(this decimal? value) => Angle.FromDegrees(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gradian

        /// <inheritdoc cref="Angle.FromGradians(double)"/>
        public static Angle Gradians(this int value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double?)"/>
        public static Angle? Gradians(this int? value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double)"/>
        public static Angle Gradians(this long value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double?)"/>
        public static Angle? Gradians(this long? value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double)"/>
        public static Angle Gradians(this double value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double?)"/>
        public static Angle? Gradians(this double? value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double)"/>
        public static Angle Gradians(this float value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double?)"/>
        public static Angle? Gradians(this float? value) => Angle.FromGradians(value);

        /// <inheritdoc cref="Angle.FromGradians(double)"/>
        public static Angle Gradians(this decimal value) => Angle.FromGradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromGradians(double?)"/>
        public static Angle? Gradians(this decimal? value) => Angle.FromGradians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microdegree

        /// <inheritdoc cref="Angle.FromMicrodegrees(double)"/>
        public static Angle Microdegrees(this int value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double?)"/>
        public static Angle? Microdegrees(this int? value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double)"/>
        public static Angle Microdegrees(this long value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double?)"/>
        public static Angle? Microdegrees(this long? value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double)"/>
        public static Angle Microdegrees(this double value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double?)"/>
        public static Angle? Microdegrees(this double? value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double)"/>
        public static Angle Microdegrees(this float value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double?)"/>
        public static Angle? Microdegrees(this float? value) => Angle.FromMicrodegrees(value);

        /// <inheritdoc cref="Angle.FromMicrodegrees(double)"/>
        public static Angle Microdegrees(this decimal value) => Angle.FromMicrodegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMicrodegrees(double?)"/>
        public static Angle? Microdegrees(this decimal? value) => Angle.FromMicrodegrees(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Microradian

        /// <inheritdoc cref="Angle.FromMicroradians(double)"/>
        public static Angle Microradians(this int value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double?)"/>
        public static Angle? Microradians(this int? value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double)"/>
        public static Angle Microradians(this long value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double?)"/>
        public static Angle? Microradians(this long? value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double)"/>
        public static Angle Microradians(this double value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double?)"/>
        public static Angle? Microradians(this double? value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double)"/>
        public static Angle Microradians(this float value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double?)"/>
        public static Angle? Microradians(this float? value) => Angle.FromMicroradians(value);

        /// <inheritdoc cref="Angle.FromMicroradians(double)"/>
        public static Angle Microradians(this decimal value) => Angle.FromMicroradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMicroradians(double?)"/>
        public static Angle? Microradians(this decimal? value) => Angle.FromMicroradians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Millidegree

        /// <inheritdoc cref="Angle.FromMillidegrees(double)"/>
        public static Angle Millidegrees(this int value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double?)"/>
        public static Angle? Millidegrees(this int? value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double)"/>
        public static Angle Millidegrees(this long value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double?)"/>
        public static Angle? Millidegrees(this long? value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double)"/>
        public static Angle Millidegrees(this double value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double?)"/>
        public static Angle? Millidegrees(this double? value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double)"/>
        public static Angle Millidegrees(this float value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double?)"/>
        public static Angle? Millidegrees(this float? value) => Angle.FromMillidegrees(value);

        /// <inheritdoc cref="Angle.FromMillidegrees(double)"/>
        public static Angle Millidegrees(this decimal value) => Angle.FromMillidegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMillidegrees(double?)"/>
        public static Angle? Millidegrees(this decimal? value) => Angle.FromMillidegrees(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Milliradian

        /// <inheritdoc cref="Angle.FromMilliradians(double)"/>
        public static Angle Milliradians(this int value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double?)"/>
        public static Angle? Milliradians(this int? value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double)"/>
        public static Angle Milliradians(this long value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double?)"/>
        public static Angle? Milliradians(this long? value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double)"/>
        public static Angle Milliradians(this double value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double?)"/>
        public static Angle? Milliradians(this double? value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double)"/>
        public static Angle Milliradians(this float value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double?)"/>
        public static Angle? Milliradians(this float? value) => Angle.FromMilliradians(value);

        /// <inheritdoc cref="Angle.FromMilliradians(double)"/>
        public static Angle Milliradians(this decimal value) => Angle.FromMilliradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromMilliradians(double?)"/>
        public static Angle? Milliradians(this decimal? value) => Angle.FromMilliradians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanodegree

        /// <inheritdoc cref="Angle.FromNanodegrees(double)"/>
        public static Angle Nanodegrees(this int value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double?)"/>
        public static Angle? Nanodegrees(this int? value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double)"/>
        public static Angle Nanodegrees(this long value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double?)"/>
        public static Angle? Nanodegrees(this long? value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double)"/>
        public static Angle Nanodegrees(this double value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double?)"/>
        public static Angle? Nanodegrees(this double? value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double)"/>
        public static Angle Nanodegrees(this float value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double?)"/>
        public static Angle? Nanodegrees(this float? value) => Angle.FromNanodegrees(value);

        /// <inheritdoc cref="Angle.FromNanodegrees(double)"/>
        public static Angle Nanodegrees(this decimal value) => Angle.FromNanodegrees(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNanodegrees(double?)"/>
        public static Angle? Nanodegrees(this decimal? value) => Angle.FromNanodegrees(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Nanoradian

        /// <inheritdoc cref="Angle.FromNanoradians(double)"/>
        public static Angle Nanoradians(this int value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double?)"/>
        public static Angle? Nanoradians(this int? value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double)"/>
        public static Angle Nanoradians(this long value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double?)"/>
        public static Angle? Nanoradians(this long? value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double)"/>
        public static Angle Nanoradians(this double value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double?)"/>
        public static Angle? Nanoradians(this double? value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double)"/>
        public static Angle Nanoradians(this float value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double?)"/>
        public static Angle? Nanoradians(this float? value) => Angle.FromNanoradians(value);

        /// <inheritdoc cref="Angle.FromNanoradians(double)"/>
        public static Angle Nanoradians(this decimal value) => Angle.FromNanoradians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromNanoradians(double?)"/>
        public static Angle? Nanoradians(this decimal? value) => Angle.FromNanoradians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Radian

        /// <inheritdoc cref="Angle.FromRadians(double)"/>
        public static Angle Radians(this int value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double?)"/>
        public static Angle? Radians(this int? value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double)"/>
        public static Angle Radians(this long value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double?)"/>
        public static Angle? Radians(this long? value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double)"/>
        public static Angle Radians(this double value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double?)"/>
        public static Angle? Radians(this double? value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double)"/>
        public static Angle Radians(this float value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double?)"/>
        public static Angle? Radians(this float? value) => Angle.FromRadians(value);

        /// <inheritdoc cref="Angle.FromRadians(double)"/>
        public static Angle Radians(this decimal value) => Angle.FromRadians(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromRadians(double?)"/>
        public static Angle? Radians(this decimal? value) => Angle.FromRadians(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Revolution

        /// <inheritdoc cref="Angle.FromRevolutions(double)"/>
        public static Angle Revolutions(this int value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double?)"/>
        public static Angle? Revolutions(this int? value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double)"/>
        public static Angle Revolutions(this long value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double?)"/>
        public static Angle? Revolutions(this long? value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double)"/>
        public static Angle Revolutions(this double value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double?)"/>
        public static Angle? Revolutions(this double? value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double)"/>
        public static Angle Revolutions(this float value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double?)"/>
        public static Angle? Revolutions(this float? value) => Angle.FromRevolutions(value);

        /// <inheritdoc cref="Angle.FromRevolutions(double)"/>
        public static Angle Revolutions(this decimal value) => Angle.FromRevolutions(Convert.ToDouble(value));

        /// <inheritdoc cref="Angle.FromRevolutions(double?)"/>
        public static Angle? Revolutions(this decimal? value) => Angle.FromRevolutions(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
