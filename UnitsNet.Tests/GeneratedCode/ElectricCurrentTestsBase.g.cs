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

// Copyright (c) 2007 Andreas Gullberg Larsen (angularsen@gmail.com).
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
using UnitsNet.Units;
using Xunit;

// Disable build warning CS1718: Comparison made to same variable; did you mean to compare something else?
#pragma warning disable 1718

// ReSharper disable once CheckNamespace
namespace UnitsNet.Tests
{
    /// <summary>
    /// Test of ElectricCurrent.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class ElectricCurrentTestsBase
    {
        protected abstract double AmperesInOneAmpere { get; }
        protected abstract double KiloamperesInOneAmpere { get; }
        protected abstract double MegaamperesInOneAmpere { get; }
        protected abstract double MicroamperesInOneAmpere { get; }
        protected abstract double MilliamperesInOneAmpere { get; }
        protected abstract double NanoamperesInOneAmpere { get; }
        protected abstract double PicoamperesInOneAmpere { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AmperesTolerance { get { return 1e-5; } }
        protected virtual double KiloamperesTolerance { get { return 1e-5; } }
        protected virtual double MegaamperesTolerance { get { return 1e-5; } }
        protected virtual double MicroamperesTolerance { get { return 1e-5; } }
        protected virtual double MilliamperesTolerance { get { return 1e-5; } }
        protected virtual double NanoamperesTolerance { get { return 1e-5; } }
        protected virtual double PicoamperesTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void AmpereToElectricCurrentUnits()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.Kiloamperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.Megaamperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.Microamperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.Milliamperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.Nanoamperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.Picoamperes, PicoamperesTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Ampere).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Kiloampere).Kiloamperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Megaampere).Megaamperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Microampere).Microamperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Milliampere).Milliamperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Nanoampere).Nanoamperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.From(1, ElectricCurrentUnit.Picoampere).Picoamperes, PicoamperesTolerance);
        }

        [Fact]
        public void As()
        {
            var ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(AmperesInOneAmpere, ampere.As(ElectricCurrentUnit.Ampere), AmperesTolerance);
            AssertEx.EqualTolerance(KiloamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Kiloampere), KiloamperesTolerance);
            AssertEx.EqualTolerance(MegaamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Megaampere), MegaamperesTolerance);
            AssertEx.EqualTolerance(MicroamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Microampere), MicroamperesTolerance);
            AssertEx.EqualTolerance(MilliamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Milliampere), MilliamperesTolerance);
            AssertEx.EqualTolerance(NanoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Nanoampere), NanoamperesTolerance);
            AssertEx.EqualTolerance(PicoamperesInOneAmpere, ampere.As(ElectricCurrentUnit.Picoampere), PicoamperesTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromAmperes(ampere.Amperes).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromKiloamperes(ampere.Kiloamperes).Amperes, KiloamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMegaamperes(ampere.Megaamperes).Amperes, MegaamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMicroamperes(ampere.Microamperes).Amperes, MicroamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromMilliamperes(ampere.Milliamperes).Amperes, MilliamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromNanoamperes(ampere.Nanoamperes).Amperes, NanoamperesTolerance);
            AssertEx.EqualTolerance(1, ElectricCurrent.FromPicoamperes(ampere.Picoamperes).Amperes, PicoamperesTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            ElectricCurrent v = ElectricCurrent.FromAmperes(1);
            AssertEx.EqualTolerance(-1, -v.Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(3)-v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (v + v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (v*10).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(10, (10*v).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, (ElectricCurrent.FromAmperes(10)/5).Amperes, AmperesTolerance);
            AssertEx.EqualTolerance(2, ElectricCurrent.FromAmperes(10)/ElectricCurrent.FromAmperes(5), AmperesTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            ElectricCurrent oneAmpere = ElectricCurrent.FromAmperes(1);
            ElectricCurrent twoAmperes = ElectricCurrent.FromAmperes(2);

            Assert.True(oneAmpere < twoAmperes);
            Assert.True(oneAmpere <= twoAmperes);
            Assert.True(twoAmperes > oneAmpere);
            Assert.True(twoAmperes >= oneAmpere);

            Assert.False(oneAmpere > twoAmperes);
            Assert.False(oneAmpere >= twoAmperes);
            Assert.False(twoAmperes < oneAmpere);
            Assert.False(twoAmperes <= oneAmpere);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Equal(0, ampere.CompareTo(ampere));
            Assert.True(ampere.CompareTo(ElectricCurrent.Zero) > 0);
            Assert.True(ElectricCurrent.Zero.CompareTo(ampere) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentException>(() => ampere.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.Throws<ArgumentNullException>(() => ampere.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            ElectricCurrent a = ElectricCurrent.FromAmperes(1);
            ElectricCurrent b = ElectricCurrent.FromAmperes(2);

// ReSharper disable EqualExpressionComparison
            Assert.True(a == a);
            Assert.True(a != b);

            Assert.False(a == b);
            Assert.False(a != a);
// ReSharper restore EqualExpressionComparison
        }

        [Fact]
        public void EqualsIsImplemented()
        {
            ElectricCurrent v = ElectricCurrent.FromAmperes(1);
            Assert.True(v.Equals(ElectricCurrent.FromAmperes(1)));
            Assert.False(v.Equals(ElectricCurrent.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            ElectricCurrent ampere = ElectricCurrent.FromAmperes(1);
            Assert.False(ampere.Equals(null));
        }
    }
}
