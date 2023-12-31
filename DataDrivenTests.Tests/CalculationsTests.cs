﻿namespace DataDrivenTests.Tests
{
    public class CalculationsTests
    {
        #region Inline Data

        [Fact]
        public void IsOdd_GivenOddValue_ReturnsTrue()
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(1);
            //Assert
            Assert.True(res);
        }

        [Fact]
        public void IsOdd_GivenEvenValue_ReturnsFalse()
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(2);
            //Assert
            Assert.False(res);
        }

        [Theory]
        [InlineData(1, true)]
        [InlineData(2, false)]
        public void IsOdd_TestOddAndEven(int value, bool expected)
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(value);
            //Assert
            Assert.Equal(expected, res);
        }

        #endregion Inline Data

        #region Property/ Method

        [Theory]
        [MemberData(nameof(TestDataShared.IsOddOrEvenData), MemberType = typeof(TestDataShared))]
        public void IsOdd_TestOddAndEven_MemberData(int value, bool expected)
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(value);
            //Assert
            Assert.Equal(expected, res);
        }

        #endregion Property/ Method

        #region External Data

        [Theory]
        [MemberData(nameof(TestDataShared.IsOddOrEvenExternalData), MemberType = typeof(TestDataShared))]
        public void IsOdd_TestOddAndEven_ExternalData(int value, bool expected)
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(value);
            //Assert
            Assert.Equal(expected, res);
        }

        #endregion External Data

        #region Data Attribute

        [Theory]
        [IsOddOrEvenDataAttribute]
        public void IsOdd_TestOddAndEven_AttributeData_First(int value, bool expected)
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(value);
            //Assert
            Assert.Equal(expected, res);
        }

        [Theory]
        [IsOddOrEvenDataAttribute]
        public void IsOdd_TestOddAndEven_AttributeData_Second(int value, bool expected)
        {
            //Arrange
            var calc = new Calculations();
            //Act
            var res = calc.IsOdd(value);
            //Assert
            Assert.Equal(expected, res);
        }

        #endregion Data Attribute
    }
}