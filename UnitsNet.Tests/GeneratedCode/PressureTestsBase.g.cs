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
    /// Test of Pressure.
    /// </summary>
// ReSharper disable once PartialTypeWithSinglePart
    public abstract partial class PressureTestsBase
    {
        protected abstract double AtmospheresInOnePascal { get; }
        protected abstract double BarsInOnePascal { get; }
        protected abstract double CentibarsInOnePascal { get; }
        protected abstract double DecapascalsInOnePascal { get; }
        protected abstract double DecibarsInOnePascal { get; }
        protected abstract double FeetOfHeadInOnePascal { get; }
        protected abstract double GigapascalsInOnePascal { get; }
        protected abstract double HectopascalsInOnePascal { get; }
        protected abstract double InchesOfMercuryInOnePascal { get; }
        protected abstract double KilobarsInOnePascal { get; }
        protected abstract double KilogramsForcePerSquareCentimeterInOnePascal { get; }
        protected abstract double KilogramsForcePerSquareMeterInOnePascal { get; }
        protected abstract double KilogramsForcePerSquareMillimeterInOnePascal { get; }
        protected abstract double KilonewtonsPerSquareCentimeterInOnePascal { get; }
        protected abstract double KilonewtonsPerSquareMeterInOnePascal { get; }
        protected abstract double KilonewtonsPerSquareMillimeterInOnePascal { get; }
        protected abstract double KilopascalsInOnePascal { get; }
        protected abstract double KilopoundsForcePerSquareFootInOnePascal { get; }
        protected abstract double KilopoundsForcePerSquareInchInOnePascal { get; }
        protected abstract double MegabarsInOnePascal { get; }
        protected abstract double MegapascalsInOnePascal { get; }
        protected abstract double MetersOfHeadInOnePascal { get; }
        protected abstract double MicropascalsInOnePascal { get; }
        protected abstract double MillibarsInOnePascal { get; }
        protected abstract double MillimetersOfMercuryInOnePascal { get; }
        protected abstract double NewtonsPerSquareCentimeterInOnePascal { get; }
        protected abstract double NewtonsPerSquareMeterInOnePascal { get; }
        protected abstract double NewtonsPerSquareMillimeterInOnePascal { get; }
        protected abstract double PascalsInOnePascal { get; }
        protected abstract double PoundsForcePerSquareFootInOnePascal { get; }
        protected abstract double PoundsForcePerSquareInchInOnePascal { get; }
        protected abstract double PsiInOnePascal { get; }
        protected abstract double TechnicalAtmospheresInOnePascal { get; }
        protected abstract double TonnesForcePerSquareCentimeterInOnePascal { get; }
        protected abstract double TonnesForcePerSquareMeterInOnePascal { get; }
        protected abstract double TonnesForcePerSquareMillimeterInOnePascal { get; }
        protected abstract double TorrsInOnePascal { get; }

// ReSharper disable VirtualMemberNeverOverriden.Global
        protected virtual double AtmospheresTolerance { get { return 1e-5; } }
        protected virtual double BarsTolerance { get { return 1e-5; } }
        protected virtual double CentibarsTolerance { get { return 1e-5; } }
        protected virtual double DecapascalsTolerance { get { return 1e-5; } }
        protected virtual double DecibarsTolerance { get { return 1e-5; } }
        protected virtual double FeetOfHeadTolerance { get { return 1e-5; } }
        protected virtual double GigapascalsTolerance { get { return 1e-5; } }
        protected virtual double HectopascalsTolerance { get { return 1e-5; } }
        protected virtual double InchesOfMercuryTolerance { get { return 1e-5; } }
        protected virtual double KilobarsTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double KilogramsForcePerSquareMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double KilonewtonsPerSquareMillimeterTolerance { get { return 1e-5; } }
        protected virtual double KilopascalsTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsForcePerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double KilopoundsForcePerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double MegabarsTolerance { get { return 1e-5; } }
        protected virtual double MegapascalsTolerance { get { return 1e-5; } }
        protected virtual double MetersOfHeadTolerance { get { return 1e-5; } }
        protected virtual double MicropascalsTolerance { get { return 1e-5; } }
        protected virtual double MillibarsTolerance { get { return 1e-5; } }
        protected virtual double MillimetersOfMercuryTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double NewtonsPerSquareMillimeterTolerance { get { return 1e-5; } }
        protected virtual double PascalsTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerSquareFootTolerance { get { return 1e-5; } }
        protected virtual double PoundsForcePerSquareInchTolerance { get { return 1e-5; } }
        protected virtual double PsiTolerance { get { return 1e-5; } }
        protected virtual double TechnicalAtmospheresTolerance { get { return 1e-5; } }
        protected virtual double TonnesForcePerSquareCentimeterTolerance { get { return 1e-5; } }
        protected virtual double TonnesForcePerSquareMeterTolerance { get { return 1e-5; } }
        protected virtual double TonnesForcePerSquareMillimeterTolerance { get { return 1e-5; } }
        protected virtual double TorrsTolerance { get { return 1e-5; } }
// ReSharper restore VirtualMemberNeverOverriden.Global

        [Fact]
        public void PascalToPressureUnits()
        {
            Pressure pascal = Pressure.FromPascals(1);
            AssertEx.EqualTolerance(AtmospheresInOnePascal, pascal.Atmospheres, AtmospheresTolerance);
            AssertEx.EqualTolerance(BarsInOnePascal, pascal.Bars, BarsTolerance);
            AssertEx.EqualTolerance(CentibarsInOnePascal, pascal.Centibars, CentibarsTolerance);
            AssertEx.EqualTolerance(DecapascalsInOnePascal, pascal.Decapascals, DecapascalsTolerance);
            AssertEx.EqualTolerance(DecibarsInOnePascal, pascal.Decibars, DecibarsTolerance);
            AssertEx.EqualTolerance(FeetOfHeadInOnePascal, pascal.FeetOfHead, FeetOfHeadTolerance);
            AssertEx.EqualTolerance(GigapascalsInOnePascal, pascal.Gigapascals, GigapascalsTolerance);
            AssertEx.EqualTolerance(HectopascalsInOnePascal, pascal.Hectopascals, HectopascalsTolerance);
            AssertEx.EqualTolerance(InchesOfMercuryInOnePascal, pascal.InchesOfMercury, InchesOfMercuryTolerance);
            AssertEx.EqualTolerance(KilobarsInOnePascal, pascal.Kilobars, KilobarsTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerSquareCentimeterInOnePascal, pascal.KilogramsForcePerSquareCentimeter, KilogramsForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerSquareMeterInOnePascal, pascal.KilogramsForcePerSquareMeter, KilogramsForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerSquareMillimeterInOnePascal, pascal.KilogramsForcePerSquareMillimeter, KilogramsForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSquareCentimeterInOnePascal, pascal.KilonewtonsPerSquareCentimeter, KilonewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSquareMeterInOnePascal, pascal.KilonewtonsPerSquareMeter, KilonewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSquareMillimeterInOnePascal, pascal.KilonewtonsPerSquareMillimeter, KilonewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(KilopascalsInOnePascal, pascal.Kilopascals, KilopascalsTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerSquareFootInOnePascal, pascal.KilopoundsForcePerSquareFoot, KilopoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerSquareInchInOnePascal, pascal.KilopoundsForcePerSquareInch, KilopoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(MegabarsInOnePascal, pascal.Megabars, MegabarsTolerance);
            AssertEx.EqualTolerance(MegapascalsInOnePascal, pascal.Megapascals, MegapascalsTolerance);
            AssertEx.EqualTolerance(MetersOfHeadInOnePascal, pascal.MetersOfHead, MetersOfHeadTolerance);
            AssertEx.EqualTolerance(MicropascalsInOnePascal, pascal.Micropascals, MicropascalsTolerance);
            AssertEx.EqualTolerance(MillibarsInOnePascal, pascal.Millibars, MillibarsTolerance);
            AssertEx.EqualTolerance(MillimetersOfMercuryInOnePascal, pascal.MillimetersOfMercury, MillimetersOfMercuryTolerance);
            AssertEx.EqualTolerance(NewtonsPerSquareCentimeterInOnePascal, pascal.NewtonsPerSquareCentimeter, NewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerSquareMeterInOnePascal, pascal.NewtonsPerSquareMeter, NewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerSquareMillimeterInOnePascal, pascal.NewtonsPerSquareMillimeter, NewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(PascalsInOnePascal, pascal.Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(PoundsForcePerSquareFootInOnePascal, pascal.PoundsForcePerSquareFoot, PoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(PoundsForcePerSquareInchInOnePascal, pascal.PoundsForcePerSquareInch, PoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(PsiInOnePascal, pascal.Psi, PsiTolerance);
            AssertEx.EqualTolerance(TechnicalAtmospheresInOnePascal, pascal.TechnicalAtmospheres, TechnicalAtmospheresTolerance);
            AssertEx.EqualTolerance(TonnesForcePerSquareCentimeterInOnePascal, pascal.TonnesForcePerSquareCentimeter, TonnesForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerSquareMeterInOnePascal, pascal.TonnesForcePerSquareMeter, TonnesForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerSquareMillimeterInOnePascal, pascal.TonnesForcePerSquareMillimeter, TonnesForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(TorrsInOnePascal, pascal.Torrs, TorrsTolerance);
        }

        [Fact]
        public void FromValueAndUnit()
        {
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Atmosphere).Atmospheres, AtmospheresTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Bar).Bars, BarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Centibar).Centibars, CentibarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Decapascal).Decapascals, DecapascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Decibar).Decibars, DecibarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.FootOfHead).FeetOfHead, FeetOfHeadTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Gigapascal).Gigapascals, GigapascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Hectopascal).Hectopascals, HectopascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.InchOfMercury).InchesOfMercury, InchesOfMercuryTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Kilobar).Kilobars, KilobarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilogramForcePerSquareCentimeter).KilogramsForcePerSquareCentimeter, KilogramsForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilogramForcePerSquareMeter).KilogramsForcePerSquareMeter, KilogramsForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilogramForcePerSquareMillimeter).KilogramsForcePerSquareMillimeter, KilogramsForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilonewtonPerSquareCentimeter).KilonewtonsPerSquareCentimeter, KilonewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilonewtonPerSquareMeter).KilonewtonsPerSquareMeter, KilonewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilonewtonPerSquareMillimeter).KilonewtonsPerSquareMillimeter, KilonewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Kilopascal).Kilopascals, KilopascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilopoundForcePerSquareFoot).KilopoundsForcePerSquareFoot, KilopoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.KilopoundForcePerSquareInch).KilopoundsForcePerSquareInch, KilopoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Megabar).Megabars, MegabarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Megapascal).Megapascals, MegapascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.MeterOfHead).MetersOfHead, MetersOfHeadTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Micropascal).Micropascals, MicropascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Millibar).Millibars, MillibarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.MillimeterOfMercury).MillimetersOfMercury, MillimetersOfMercuryTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.NewtonPerSquareCentimeter).NewtonsPerSquareCentimeter, NewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.NewtonPerSquareMeter).NewtonsPerSquareMeter, NewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.NewtonPerSquareMillimeter).NewtonsPerSquareMillimeter, NewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Pascal).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.PoundForcePerSquareFoot).PoundsForcePerSquareFoot, PoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.PoundForcePerSquareInch).PoundsForcePerSquareInch, PoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Psi).Psi, PsiTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.TechnicalAtmosphere).TechnicalAtmospheres, TechnicalAtmospheresTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.TonneForcePerSquareCentimeter).TonnesForcePerSquareCentimeter, TonnesForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.TonneForcePerSquareMeter).TonnesForcePerSquareMeter, TonnesForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.TonneForcePerSquareMillimeter).TonnesForcePerSquareMillimeter, TonnesForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.From(1, PressureUnit.Torr).Torrs, TorrsTolerance);
        }

        [Fact]
        public void As()
        {
            var pascal = Pressure.FromPascals(1);
            AssertEx.EqualTolerance(AtmospheresInOnePascal, pascal.As(PressureUnit.Atmosphere), AtmospheresTolerance);
            AssertEx.EqualTolerance(BarsInOnePascal, pascal.As(PressureUnit.Bar), BarsTolerance);
            AssertEx.EqualTolerance(CentibarsInOnePascal, pascal.As(PressureUnit.Centibar), CentibarsTolerance);
            AssertEx.EqualTolerance(DecapascalsInOnePascal, pascal.As(PressureUnit.Decapascal), DecapascalsTolerance);
            AssertEx.EqualTolerance(DecibarsInOnePascal, pascal.As(PressureUnit.Decibar), DecibarsTolerance);
            AssertEx.EqualTolerance(FeetOfHeadInOnePascal, pascal.As(PressureUnit.FootOfHead), FeetOfHeadTolerance);
            AssertEx.EqualTolerance(GigapascalsInOnePascal, pascal.As(PressureUnit.Gigapascal), GigapascalsTolerance);
            AssertEx.EqualTolerance(HectopascalsInOnePascal, pascal.As(PressureUnit.Hectopascal), HectopascalsTolerance);
            AssertEx.EqualTolerance(InchesOfMercuryInOnePascal, pascal.As(PressureUnit.InchOfMercury), InchesOfMercuryTolerance);
            AssertEx.EqualTolerance(KilobarsInOnePascal, pascal.As(PressureUnit.Kilobar), KilobarsTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerSquareCentimeterInOnePascal, pascal.As(PressureUnit.KilogramForcePerSquareCentimeter), KilogramsForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerSquareMeterInOnePascal, pascal.As(PressureUnit.KilogramForcePerSquareMeter), KilogramsForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilogramsForcePerSquareMillimeterInOnePascal, pascal.As(PressureUnit.KilogramForcePerSquareMillimeter), KilogramsForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSquareCentimeterInOnePascal, pascal.As(PressureUnit.KilonewtonPerSquareCentimeter), KilonewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSquareMeterInOnePascal, pascal.As(PressureUnit.KilonewtonPerSquareMeter), KilonewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(KilonewtonsPerSquareMillimeterInOnePascal, pascal.As(PressureUnit.KilonewtonPerSquareMillimeter), KilonewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(KilopascalsInOnePascal, pascal.As(PressureUnit.Kilopascal), KilopascalsTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerSquareFootInOnePascal, pascal.As(PressureUnit.KilopoundForcePerSquareFoot), KilopoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(KilopoundsForcePerSquareInchInOnePascal, pascal.As(PressureUnit.KilopoundForcePerSquareInch), KilopoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(MegabarsInOnePascal, pascal.As(PressureUnit.Megabar), MegabarsTolerance);
            AssertEx.EqualTolerance(MegapascalsInOnePascal, pascal.As(PressureUnit.Megapascal), MegapascalsTolerance);
            AssertEx.EqualTolerance(MetersOfHeadInOnePascal, pascal.As(PressureUnit.MeterOfHead), MetersOfHeadTolerance);
            AssertEx.EqualTolerance(MicropascalsInOnePascal, pascal.As(PressureUnit.Micropascal), MicropascalsTolerance);
            AssertEx.EqualTolerance(MillibarsInOnePascal, pascal.As(PressureUnit.Millibar), MillibarsTolerance);
            AssertEx.EqualTolerance(MillimetersOfMercuryInOnePascal, pascal.As(PressureUnit.MillimeterOfMercury), MillimetersOfMercuryTolerance);
            AssertEx.EqualTolerance(NewtonsPerSquareCentimeterInOnePascal, pascal.As(PressureUnit.NewtonPerSquareCentimeter), NewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerSquareMeterInOnePascal, pascal.As(PressureUnit.NewtonPerSquareMeter), NewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(NewtonsPerSquareMillimeterInOnePascal, pascal.As(PressureUnit.NewtonPerSquareMillimeter), NewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(PascalsInOnePascal, pascal.As(PressureUnit.Pascal), PascalsTolerance);
            AssertEx.EqualTolerance(PoundsForcePerSquareFootInOnePascal, pascal.As(PressureUnit.PoundForcePerSquareFoot), PoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(PoundsForcePerSquareInchInOnePascal, pascal.As(PressureUnit.PoundForcePerSquareInch), PoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(PsiInOnePascal, pascal.As(PressureUnit.Psi), PsiTolerance);
            AssertEx.EqualTolerance(TechnicalAtmospheresInOnePascal, pascal.As(PressureUnit.TechnicalAtmosphere), TechnicalAtmospheresTolerance);
            AssertEx.EqualTolerance(TonnesForcePerSquareCentimeterInOnePascal, pascal.As(PressureUnit.TonneForcePerSquareCentimeter), TonnesForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerSquareMeterInOnePascal, pascal.As(PressureUnit.TonneForcePerSquareMeter), TonnesForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(TonnesForcePerSquareMillimeterInOnePascal, pascal.As(PressureUnit.TonneForcePerSquareMillimeter), TonnesForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(TorrsInOnePascal, pascal.As(PressureUnit.Torr), TorrsTolerance);
        }

        [Fact]
        public void ConversionRoundTrip()
        {
            Pressure pascal = Pressure.FromPascals(1);
            AssertEx.EqualTolerance(1, Pressure.FromAtmospheres(pascal.Atmospheres).Pascals, AtmospheresTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromBars(pascal.Bars).Pascals, BarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromCentibars(pascal.Centibars).Pascals, CentibarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromDecapascals(pascal.Decapascals).Pascals, DecapascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromDecibars(pascal.Decibars).Pascals, DecibarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromFeetOfHead(pascal.FeetOfHead).Pascals, FeetOfHeadTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromGigapascals(pascal.Gigapascals).Pascals, GigapascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromHectopascals(pascal.Hectopascals).Pascals, HectopascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromInchesOfMercury(pascal.InchesOfMercury).Pascals, InchesOfMercuryTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilobars(pascal.Kilobars).Pascals, KilobarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilogramsForcePerSquareCentimeter(pascal.KilogramsForcePerSquareCentimeter).Pascals, KilogramsForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilogramsForcePerSquareMeter(pascal.KilogramsForcePerSquareMeter).Pascals, KilogramsForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilogramsForcePerSquareMillimeter(pascal.KilogramsForcePerSquareMillimeter).Pascals, KilogramsForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilonewtonsPerSquareCentimeter(pascal.KilonewtonsPerSquareCentimeter).Pascals, KilonewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilonewtonsPerSquareMeter(pascal.KilonewtonsPerSquareMeter).Pascals, KilonewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilonewtonsPerSquareMillimeter(pascal.KilonewtonsPerSquareMillimeter).Pascals, KilonewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilopascals(pascal.Kilopascals).Pascals, KilopascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilopoundsForcePerSquareFoot(pascal.KilopoundsForcePerSquareFoot).Pascals, KilopoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromKilopoundsForcePerSquareInch(pascal.KilopoundsForcePerSquareInch).Pascals, KilopoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromMegabars(pascal.Megabars).Pascals, MegabarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromMegapascals(pascal.Megapascals).Pascals, MegapascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromMetersOfHead(pascal.MetersOfHead).Pascals, MetersOfHeadTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromMicropascals(pascal.Micropascals).Pascals, MicropascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromMillibars(pascal.Millibars).Pascals, MillibarsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromMillimetersOfMercury(pascal.MillimetersOfMercury).Pascals, MillimetersOfMercuryTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromNewtonsPerSquareCentimeter(pascal.NewtonsPerSquareCentimeter).Pascals, NewtonsPerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromNewtonsPerSquareMeter(pascal.NewtonsPerSquareMeter).Pascals, NewtonsPerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromNewtonsPerSquareMillimeter(pascal.NewtonsPerSquareMillimeter).Pascals, NewtonsPerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromPascals(pascal.Pascals).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromPoundsForcePerSquareFoot(pascal.PoundsForcePerSquareFoot).Pascals, PoundsForcePerSquareFootTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromPoundsForcePerSquareInch(pascal.PoundsForcePerSquareInch).Pascals, PoundsForcePerSquareInchTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromPsi(pascal.Psi).Pascals, PsiTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromTechnicalAtmospheres(pascal.TechnicalAtmospheres).Pascals, TechnicalAtmospheresTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromTonnesForcePerSquareCentimeter(pascal.TonnesForcePerSquareCentimeter).Pascals, TonnesForcePerSquareCentimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromTonnesForcePerSquareMeter(pascal.TonnesForcePerSquareMeter).Pascals, TonnesForcePerSquareMeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromTonnesForcePerSquareMillimeter(pascal.TonnesForcePerSquareMillimeter).Pascals, TonnesForcePerSquareMillimeterTolerance);
            AssertEx.EqualTolerance(1, Pressure.FromTorrs(pascal.Torrs).Pascals, TorrsTolerance);
        }

        [Fact]
        public void ArithmeticOperators()
        {
            Pressure v = Pressure.FromPascals(1);
            AssertEx.EqualTolerance(-1, -v.Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(2, (Pressure.FromPascals(3)-v).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(2, (v + v).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(10, (v*10).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(10, (10*v).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(2, (Pressure.FromPascals(10)/5).Pascals, PascalsTolerance);
            AssertEx.EqualTolerance(2, Pressure.FromPascals(10)/Pressure.FromPascals(5), PascalsTolerance);
        }

        [Fact]
        public void ComparisonOperators()
        {
            Pressure onePascal = Pressure.FromPascals(1);
            Pressure twoPascals = Pressure.FromPascals(2);

            Assert.True(onePascal < twoPascals);
            Assert.True(onePascal <= twoPascals);
            Assert.True(twoPascals > onePascal);
            Assert.True(twoPascals >= onePascal);

            Assert.False(onePascal > twoPascals);
            Assert.False(onePascal >= twoPascals);
            Assert.False(twoPascals < onePascal);
            Assert.False(twoPascals <= onePascal);
        }

        [Fact]
        public void CompareToIsImplemented()
        {
            Pressure pascal = Pressure.FromPascals(1);
            Assert.Equal(0, pascal.CompareTo(pascal));
            Assert.True(pascal.CompareTo(Pressure.Zero) > 0);
            Assert.True(Pressure.Zero.CompareTo(pascal) < 0);
        }

        [Fact]
        public void CompareToThrowsOnTypeMismatch()
        {
            Pressure pascal = Pressure.FromPascals(1);
            Assert.Throws<ArgumentException>(() => pascal.CompareTo(new object()));
        }

        [Fact]
        public void CompareToThrowsOnNull()
        {
            Pressure pascal = Pressure.FromPascals(1);
            Assert.Throws<ArgumentNullException>(() => pascal.CompareTo(null));
        }


        [Fact]
        public void EqualityOperators()
        {
            Pressure a = Pressure.FromPascals(1);
            Pressure b = Pressure.FromPascals(2);

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
            Pressure v = Pressure.FromPascals(1);
            Assert.True(v.Equals(Pressure.FromPascals(1)));
            Assert.False(v.Equals(Pressure.Zero));
        }

        [Fact]
        public void EqualsReturnsFalseOnTypeMismatch()
        {
            Pressure pascal = Pressure.FromPascals(1);
            Assert.False(pascal.Equals(new object()));
        }

        [Fact]
        public void EqualsReturnsFalseOnNull()
        {
            Pressure pascal = Pressure.FromPascals(1);
            Assert.False(pascal.Equals(null));
        }
    }
}
