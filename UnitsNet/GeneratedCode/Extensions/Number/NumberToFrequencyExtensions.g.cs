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
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add Extensions\MyQuantityExtensions.cs to decorate quantities with new behavior.
//     Add UnitDefinitions\MyQuantity.json and run GeneratUnits.bat to generate new units or quantities.
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
namespace UnitsNet.Extensions.NumberToFrequency
{
    public static class NumberToFrequencyExtensions
    {
        #region CyclePerHour

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double)"/>
        public static Frequency CyclesPerHour(this int value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double?)"/>
        public static Frequency? CyclesPerHour(this int? value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double)"/>
        public static Frequency CyclesPerHour(this long value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double?)"/>
        public static Frequency? CyclesPerHour(this long? value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double)"/>
        public static Frequency CyclesPerHour(this double value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double?)"/>
        public static Frequency? CyclesPerHour(this double? value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double)"/>
        public static Frequency CyclesPerHour(this float value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double?)"/>
        public static Frequency? CyclesPerHour(this float? value) => Frequency.FromCyclesPerHour(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double)"/>
        public static Frequency CyclesPerHour(this decimal value) => Frequency.FromCyclesPerHour(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromCyclesPerHour(double?)"/>
        public static Frequency? CyclesPerHour(this decimal? value) => Frequency.FromCyclesPerHour(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region CyclePerMinute

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double)"/>
        public static Frequency CyclesPerMinute(this int value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double?)"/>
        public static Frequency? CyclesPerMinute(this int? value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double)"/>
        public static Frequency CyclesPerMinute(this long value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double?)"/>
        public static Frequency? CyclesPerMinute(this long? value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double)"/>
        public static Frequency CyclesPerMinute(this double value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double?)"/>
        public static Frequency? CyclesPerMinute(this double? value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double)"/>
        public static Frequency CyclesPerMinute(this float value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double?)"/>
        public static Frequency? CyclesPerMinute(this float? value) => Frequency.FromCyclesPerMinute(value);

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double)"/>
        public static Frequency CyclesPerMinute(this decimal value) => Frequency.FromCyclesPerMinute(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromCyclesPerMinute(double?)"/>
        public static Frequency? CyclesPerMinute(this decimal? value) => Frequency.FromCyclesPerMinute(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Gigahertz

        /// <inheritdoc cref="Frequency.FromGigahertz(double)"/>
        public static Frequency Gigahertz(this int value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double?)"/>
        public static Frequency? Gigahertz(this int? value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double)"/>
        public static Frequency Gigahertz(this long value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double?)"/>
        public static Frequency? Gigahertz(this long? value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double)"/>
        public static Frequency Gigahertz(this double value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double?)"/>
        public static Frequency? Gigahertz(this double? value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double)"/>
        public static Frequency Gigahertz(this float value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double?)"/>
        public static Frequency? Gigahertz(this float? value) => Frequency.FromGigahertz(value);

        /// <inheritdoc cref="Frequency.FromGigahertz(double)"/>
        public static Frequency Gigahertz(this decimal value) => Frequency.FromGigahertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromGigahertz(double?)"/>
        public static Frequency? Gigahertz(this decimal? value) => Frequency.FromGigahertz(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Hertz

        /// <inheritdoc cref="Frequency.FromHertz(double)"/>
        public static Frequency Hertz(this int value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double?)"/>
        public static Frequency? Hertz(this int? value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double)"/>
        public static Frequency Hertz(this long value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double?)"/>
        public static Frequency? Hertz(this long? value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double)"/>
        public static Frequency Hertz(this double value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double?)"/>
        public static Frequency? Hertz(this double? value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double)"/>
        public static Frequency Hertz(this float value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double?)"/>
        public static Frequency? Hertz(this float? value) => Frequency.FromHertz(value);

        /// <inheritdoc cref="Frequency.FromHertz(double)"/>
        public static Frequency Hertz(this decimal value) => Frequency.FromHertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromHertz(double?)"/>
        public static Frequency? Hertz(this decimal? value) => Frequency.FromHertz(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Kilohertz

        /// <inheritdoc cref="Frequency.FromKilohertz(double)"/>
        public static Frequency Kilohertz(this int value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double?)"/>
        public static Frequency? Kilohertz(this int? value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double)"/>
        public static Frequency Kilohertz(this long value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double?)"/>
        public static Frequency? Kilohertz(this long? value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double)"/>
        public static Frequency Kilohertz(this double value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double?)"/>
        public static Frequency? Kilohertz(this double? value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double)"/>
        public static Frequency Kilohertz(this float value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double?)"/>
        public static Frequency? Kilohertz(this float? value) => Frequency.FromKilohertz(value);

        /// <inheritdoc cref="Frequency.FromKilohertz(double)"/>
        public static Frequency Kilohertz(this decimal value) => Frequency.FromKilohertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromKilohertz(double?)"/>
        public static Frequency? Kilohertz(this decimal? value) => Frequency.FromKilohertz(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Megahertz

        /// <inheritdoc cref="Frequency.FromMegahertz(double)"/>
        public static Frequency Megahertz(this int value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double?)"/>
        public static Frequency? Megahertz(this int? value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double)"/>
        public static Frequency Megahertz(this long value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double?)"/>
        public static Frequency? Megahertz(this long? value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double)"/>
        public static Frequency Megahertz(this double value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double?)"/>
        public static Frequency? Megahertz(this double? value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double)"/>
        public static Frequency Megahertz(this float value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double?)"/>
        public static Frequency? Megahertz(this float? value) => Frequency.FromMegahertz(value);

        /// <inheritdoc cref="Frequency.FromMegahertz(double)"/>
        public static Frequency Megahertz(this decimal value) => Frequency.FromMegahertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromMegahertz(double?)"/>
        public static Frequency? Megahertz(this decimal? value) => Frequency.FromMegahertz(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

        #region Terahertz

        /// <inheritdoc cref="Frequency.FromTerahertz(double)"/>
        public static Frequency Terahertz(this int value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double?)"/>
        public static Frequency? Terahertz(this int? value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double)"/>
        public static Frequency Terahertz(this long value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double?)"/>
        public static Frequency? Terahertz(this long? value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double)"/>
        public static Frequency Terahertz(this double value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double?)"/>
        public static Frequency? Terahertz(this double? value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double)"/>
        public static Frequency Terahertz(this float value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double?)"/>
        public static Frequency? Terahertz(this float? value) => Frequency.FromTerahertz(value);

        /// <inheritdoc cref="Frequency.FromTerahertz(double)"/>
        public static Frequency Terahertz(this decimal value) => Frequency.FromTerahertz(Convert.ToDouble(value));

        /// <inheritdoc cref="Frequency.FromTerahertz(double?)"/>
        public static Frequency? Terahertz(this decimal? value) => Frequency.FromTerahertz(value == null ? (double?)null : Convert.ToDouble(value.Value));

        #endregion

    }
}
#endif
