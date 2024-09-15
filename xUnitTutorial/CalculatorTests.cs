using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace xUnitTutorial
{
    public class CalculatorTests
    {
        private readonly Calculator _sut; // means system under test

        public CalculatorTests()
        {
            _sut = new Calculator();
        }

        [Fact(Skip = "Redundant test")]
        public void AddTwoNumbersShouldEqualTheirEqual()
        {
            _sut.Add(5);
            _sut.Add(8);
            Assert.Equal(13, _sut.Value);
        }

        [Theory]
        [InlineData(13, 5, 8)]
        [InlineData(0, -3, 3)]
        [InlineData(0, 0, 0)]
        public void AddTwoNumbersShouldEqualTheirEqualTheory(decimal expected, decimal firstToAdd, decimal secondToAdd)
        {
            _sut.Add(firstToAdd);
            _sut.Add(secondToAdd);
            Assert.Equal(expected, _sut.Value);
        }

        [Theory]
        [MemberData(nameof(TestData))]
        public void AddManyNumbersShouldEqualTheirEqualTheory(decimal expected, params decimal[] valuesToAdd)
        {
            foreach (var value in valuesToAdd)
            {
                _sut.Add(value);
            }
            Assert.Equal(expected, _sut.Value);
        }

        [Theory]
        [ClassData(typeof(SubtractionTestData))]
        public void SubtractManyNumbersTheory(decimal expected, params decimal[] valuesToSubtract)
        {
            foreach (var value in valuesToSubtract)
            {
                _sut.Subtract(value);
            }
            Assert.Equal(expected, _sut.Value);
        }

        public static IEnumerable<object[]> TestData()
        {
            yield return new object[] { 15, new decimal[] { 10, 5 } };
            yield return new object[] { 15, new decimal[] { 5, 5, 5  } };
            yield return new object[] { 15, new decimal[] { -10, 30, -5 } };
        }

        public class SubtractionTestData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { -31, new decimal[] { 20, 5, 6 } };
                yield return new object[] { 0, new decimal[] { 0, 0 } };
                yield return new object[] { -15, new decimal[] { 5, 7, 3 } };
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
    }
}
