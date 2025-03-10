﻿using NUnit.Framework;
using FluentAssertions;
using System;

namespace Exercises.Tests
{
    public class Exercise004Tests
    {
        [Test]
        public void AddGigaSecond_Should_Return_Result_When_Only_Date_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 7, 19));
            DateTime expectedResult = new(2053, 3, 27, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 3, 4, 23, 22, 0, 0));
            DateTime expectedResult = new(2052, 11, 11, 1, 8, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_DateTime_Is_Specified_With_Day_RollOver()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime(2021, 1, 24, 23, 59, 59, 0));
            DateTime expectedResult = new(2052, 10, 3, 1, 46, 39);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Return_Result_When_No_DateTime_Parameters_Are_Specified()
        {
            DateTime actualResult = Exercise004.AddGigaSecond(new DateTime());
            DateTime expectedResult = new(0032, 9, 9, 1, 46, 40);
            actualResult.Should().Be(expectedResult);
        }

        [Test]
        public void AddGigaSecond_Should_Throw_Exception_When_Incorrect_DateTime_Parameters_Are_Specified()
        {
            var ex = Assert.Throws<ArgumentOutOfRangeException>(() => Exercise004.AddGigaSecond(new DateTime(99993, 25, 19, 24, 22, 0)));
        }
    }
}
