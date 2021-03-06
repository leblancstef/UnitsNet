﻿// Copyright (c) 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).
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
using Xunit;
using UnitsNet.CustomCode.Extensions;

namespace UnitsNet.Tests.CustomCode
{
    public class DensityTests : DensityTestsBase
    {
        protected override double MilligramsPerCubicMeterInOneKilogramPerCubicMeter => 1e6;

        protected override double GramsPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-3;

        protected override double GramsPerCubicMeterInOneKilogramPerCubicMeter => 1e3;

        protected override double GramsPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-6;

        protected override double KilogramsPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-6;

        protected override double KilogramsPerCubicMeterInOneKilogramPerCubicMeter => 1;

        protected override double KilogramsPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-9;

        protected override double KilopoundsPerCubicFootInOneKilogramPerCubicMeter => 6.242796e-5;

        protected override double KilopoundsPerCubicInchInOneKilogramPerCubicMeter => 3.6127292e-8;

        protected override double PoundsPerCubicFootInOneKilogramPerCubicMeter => 6.242796e-2;

        protected override double PoundsPerCubicInchInOneKilogramPerCubicMeter => 3.61272923e-5;

        protected override double PoundsPerUSGallonInOneKilogramPerCubicMeter => 8.3454045e-3;
        protected override double PoundsPerImperialGallonInOneKilogramPerCubicMeter => 1.002241e-2;

        protected override double TonnesPerCubicCentimeterInOneKilogramPerCubicMeter => 1e-9;

        protected override double TonnesPerCubicMeterInOneKilogramPerCubicMeter => 1e-3;

        protected override double TonnesPerCubicMillimeterInOneKilogramPerCubicMeter => 1e-12;

        protected override double SlugsPerCubicFootInOneKilogramPerCubicMeter => 0.00194032;

        protected override double CentigramsPerDeciLiterInOneKilogramPerCubicMeter => 1e1;

        protected override double CentigramsPerLiterInOneKilogramPerCubicMeter => 1e2;

        protected override double CentigramsPerMilliliterInOneKilogramPerCubicMeter => 1e-1;

        protected override double DecigramsPerDeciLiterInOneKilogramPerCubicMeter => 1;

        protected override double DecigramsPerLiterInOneKilogramPerCubicMeter => 1e1;

        protected override double DecigramsPerMilliliterInOneKilogramPerCubicMeter => 1e-2;

        protected override double GramsPerDeciLiterInOneKilogramPerCubicMeter => 1e-1;

        protected override double GramsPerLiterInOneKilogramPerCubicMeter => 1;

        protected override double GramsPerMilliliterInOneKilogramPerCubicMeter => 1e-3;

        protected override double MicrogramsPerDeciLiterInOneKilogramPerCubicMeter => 1e5;

        protected override double MicrogramsPerLiterInOneKilogramPerCubicMeter => 1e6;

        protected override double MicrogramsPerMilliliterInOneKilogramPerCubicMeter => 1e3;

        protected override double MilligramsPerDeciLiterInOneKilogramPerCubicMeter => 1e2;

        protected override double MilligramsPerLiterInOneKilogramPerCubicMeter => 1e3;

        protected override double MilligramsPerMilliliterInOneKilogramPerCubicMeter => 1;

        protected override double NanogramsPerDeciLiterInOneKilogramPerCubicMeter => 1e8;

        protected override double NanogramsPerLiterInOneKilogramPerCubicMeter => 1e9;

        protected override double NanogramsPerMilliliterInOneKilogramPerCubicMeter => 1e6;

        protected override double PicogramsPerDeciLiterInOneKilogramPerCubicMeter => 1e11;

        protected override double PicogramsPerLiterInOneKilogramPerCubicMeter => 1e12;

        protected override double PicogramsPerMilliliterInOneKilogramPerCubicMeter => 1e9;


        [Fact]
        public static void DensityTimesVolumeEqualsMass()
        {
            Mass mass = Density.FromKilogramsPerCubicMeter(2) * Volume.FromCubicMeters(3);
            Assert.Equal(mass, Mass.FromKilograms(6));
        }

        [Fact]
        public static void VolumeTimesDensityEqualsMass()
        {
            Mass mass = Volume.FromCubicMeters(3) * Density.FromKilogramsPerCubicMeter(2);
            Assert.Equal(mass, Mass.FromKilograms(6));
        }

        [Fact]
        public static void DensityTimesKinematicViscosityEqualsDynamicViscosity()
        {
            DynamicViscosity dynamicViscosity = Density.FromKilogramsPerCubicMeter(2) * KinematicViscosity.FromSquareMetersPerSecond(10);
            Assert.Equal(dynamicViscosity, DynamicViscosity.FromNewtonSecondsPerMeterSquared(20));
        }

        [Fact]
        public void ExpectMolarityConvertedToDensityCorrectly()
        {
            var molarity = Molarity.FromMolesPerLiter(1.02698355);
            var mw = Mass.FromGrams(58.443);
            var density = Density.FromMolarity(molarity, mw).KilogramsPerCubicMeter;
            AssertEx.EqualTolerance(60.02, density, KilogramsPerCubicMeterTolerance);
        }

        [Fact]
        public void ExpectDensityConvertedToMolarityCorrectly()
        {
            var density = Density.FromKilogramsPerCubicMeter(60.02);
            var mw = Mass.FromGrams(58.443);
            var molarity = density.ToMolarity(mw).MolesPerCubicMeter;
            AssertEx.EqualTolerance(1026.98355, molarity, KilogramsPerCubicMeterTolerance);
        }

        [Fact]
        public void DensityTimesSpeedEqualsMassFlux()
        {
            MassFlux massFlux = Density.FromKilogramsPerCubicMeter(20) * Speed.FromMetersPerSecond(2);
            Assert.Equal(massFlux, MassFlux.FromKilogramsPerSecondPerSquareMeter(40));
        }
    }
}
