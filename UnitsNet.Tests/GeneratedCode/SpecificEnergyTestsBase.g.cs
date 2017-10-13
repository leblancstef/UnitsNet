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
    /// Test of SpecificEnergy.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class SpecificEnergyTestsBase
    {
        protected abstract double CaloriesPerGramInOneJoulePerKilogram { get; }
        protected abstract double JoulesPerKilogramInOneJoulePerKilogram { get; }
        protected abstract double KilocaloriesPerGramInOneJoulePerKilogram { get; }
        protected abstract double KilojoulesPerKilogramInOneJoulePerKilogram { get; }
        protected abstract double KilowattHoursPerKilogramInOneJoulePerKilogram { get; }
        protected abstract double MegajoulesPerKilogramInOneJoulePerKilogram { get; }
        protected abstract double MegawattHoursPerKilogramInOneJoulePerKilogram { get; }
        protected abstract double WattHoursPerKilogramInOneJoulePerKilogram { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double CaloriesPerGramTolerance { get { return 1e-5; } }
        protected virtual double JoulesPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double KilocaloriesPerGramTolerance { get { return 1e-5; } }
        protected virtual double KilojoulesPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double KilowattHoursPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double MegajoulesPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double MegawattHoursPerKilogramTolerance { get { return 1e-5; } }
        protected virtual double WattHoursPerKilogramTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void JoulePerKilogramToSpecificEnergyUnits()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            AssertEx.EqualTolerance(CaloriesPerGramInOneJoulePerKilogram, jouleperkilogram.CaloriesPerGram, CaloriesPerGramTolerance);
            AssertEx.EqualTolerance(JoulesPerKilogramInOneJoulePerKilogram, jouleperkilogram.JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerGramInOneJoulePerKilogram, jouleperkilogram.KilocaloriesPerGram, KilocaloriesPerGramTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilogramInOneJoulePerKilogram, jouleperkilogram.KilojoulesPerKilogram, KilojoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(KilowattHoursPerKilogramInOneJoulePerKilogram, jouleperkilogram.KilowattHoursPerKilogram, KilowattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKilogramInOneJoulePerKilogram, jouleperkilogram.MegajoulesPerKilogram, MegajoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(MegawattHoursPerKilogramInOneJoulePerKilogram, jouleperkilogram.MegawattHoursPerKilogram, MegawattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(WattHoursPerKilogramInOneJoulePerKilogram, jouleperkilogram.WattHoursPerKilogram, WattHoursPerKilogramTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.CaloriePerGram).CaloriesPerGram, CaloriesPerGramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.JoulePerKilogram).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.KilocaloriePerGram).KilocaloriesPerGram, KilocaloriesPerGramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.KilojoulePerKilogram).KilojoulesPerKilogram, KilojoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.KilowattHourPerKilogram).KilowattHoursPerKilogram, KilowattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.MegajoulePerKilogram).MegajoulesPerKilogram, MegajoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.MegawattHourPerKilogram).MegawattHoursPerKilogram, MegawattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.From(1, SpecificEnergyUnit.WattHourPerKilogram).WattHoursPerKilogram, WattHoursPerKilogramTolerance);
        }

        [Fact]
        public void As()
        {
            var jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            AssertEx.EqualTolerance(CaloriesPerGramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.CaloriePerGram), CaloriesPerGramTolerance);
            AssertEx.EqualTolerance(JoulesPerKilogramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.JoulePerKilogram), JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(KilocaloriesPerGramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.KilocaloriePerGram), KilocaloriesPerGramTolerance);
            AssertEx.EqualTolerance(KilojoulesPerKilogramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.KilojoulePerKilogram), KilojoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(KilowattHoursPerKilogramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.KilowattHourPerKilogram), KilowattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(MegajoulesPerKilogramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.MegajoulePerKilogram), MegajoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(MegawattHoursPerKilogramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.MegawattHourPerKilogram), MegawattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(WattHoursPerKilogramInOneJoulePerKilogram, jouleperkilogram.As(SpecificEnergyUnit.WattHourPerKilogram), WattHoursPerKilogramTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromCaloriesPerGram(jouleperkilogram.CaloriesPerGram).JoulesPerKilogram, CaloriesPerGramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromJoulesPerKilogram(jouleperkilogram.JoulesPerKilogram).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromKilocaloriesPerGram(jouleperkilogram.KilocaloriesPerGram).JoulesPerKilogram, KilocaloriesPerGramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromKilojoulesPerKilogram(jouleperkilogram.KilojoulesPerKilogram).JoulesPerKilogram, KilojoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromKilowattHoursPerKilogram(jouleperkilogram.KilowattHoursPerKilogram).JoulesPerKilogram, KilowattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromMegajoulesPerKilogram(jouleperkilogram.MegajoulesPerKilogram).JoulesPerKilogram, MegajoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromMegawattHoursPerKilogram(jouleperkilogram.MegawattHoursPerKilogram).JoulesPerKilogram, MegawattHoursPerKilogramTolerance);
            AssertEx.EqualTolerance(1, SpecificEnergy.FromWattHoursPerKilogram(jouleperkilogram.WattHoursPerKilogram).JoulesPerKilogram, WattHoursPerKilogramTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            SpecificEnergy v = SpecificEnergy.FromJoulesPerKilogram(1);
            AssertEx.EqualTolerance(-1, -v.JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificEnergy.FromJoulesPerKilogram(3)-v).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (v + v).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (v*10).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(10, (10*v).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(2, (SpecificEnergy.FromJoulesPerKilogram(10)/5).JoulesPerKilogram, JoulesPerKilogramTolerance);
            AssertEx.EqualTolerance(2, SpecificEnergy.FromJoulesPerKilogram(10)/SpecificEnergy.FromJoulesPerKilogram(5), JoulesPerKilogramTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            SpecificEnergy oneJoulePerKilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            SpecificEnergy twoJoulesPerKilogram = SpecificEnergy.FromJoulesPerKilogram(2);

            Assert.True(oneJoulePerKilogram < twoJoulesPerKilogram);
            Assert.True(oneJoulePerKilogram <= twoJoulesPerKilogram);
            Assert.True(twoJoulesPerKilogram > oneJoulePerKilogram);
            Assert.True(twoJoulesPerKilogram >= oneJoulePerKilogram);

            Assert.False(oneJoulePerKilogram > twoJoulesPerKilogram);
            Assert.False(oneJoulePerKilogram >= twoJoulesPerKilogram);
            Assert.False(twoJoulesPerKilogram < oneJoulePerKilogram);
            Assert.False(twoJoulesPerKilogram <= oneJoulePerKilogram);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            Assert.Equal(0, jouleperkilogram.CompareTo(jouleperkilogram));
            Assert.True(jouleperkilogram.CompareTo(SpecificEnergy.Zero) > 0);
            Assert.True(SpecificEnergy.Zero.CompareTo(jouleperkilogram) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            Assert.Throws<ArgumentException>(() => jouleperkilogram.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            Assert.Throws<ArgumentNullException>(() => jouleperkilogram.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            SpecificEnergy a = SpecificEnergy.FromJoulesPerKilogram(1);
            SpecificEnergy b = SpecificEnergy.FromJoulesPerKilogram(2);

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
            SpecificEnergy v = SpecificEnergy.FromJoulesPerKilogram(1);
            Assert.True(v.Equals(SpecificEnergy.FromJoulesPerKilogram(1)));
            Assert.False(v.Equals(SpecificEnergy.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            Assert.False(jouleperkilogram.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            SpecificEnergy jouleperkilogram = SpecificEnergy.FromJoulesPerKilogram(1);
            Assert.False(jouleperkilogram.Equals(null));
        }
    }
}
