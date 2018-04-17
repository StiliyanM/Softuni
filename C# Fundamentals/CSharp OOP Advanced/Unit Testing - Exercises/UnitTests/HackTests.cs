namespace _00.UnitTestings
{
    using NUnit.Framework;
    using Moq;
    using System;

    public class HackTests
    {
        [Test]
        [TestCase(-1_000)]
        [TestCase(0.2)]
        [TestCase(-0.2)]
        [TestCase(7)]
        [TestCase(0)]
        public void TestMathAbs(double value)
        {
            //var mock = new Mock<Math>(); // static

            bool isNegative = value < 0;

            double expectedValue = isNegative ? value * -1 : value;

            Assert.That(Math.Abs(value), Is.EqualTo(expectedValue));
        }

        [Test]
        [TestCase(-1_000.2)]
        [TestCase(0.9)]
        [TestCase(7.5)]
        [TestCase(3)]
        [TestCase(-1.9)]
        [TestCase(-1.00000)]
        [TestCase(-1.010000)]
        public void TestMathFloor(double value)
        {
            //var mock = new Mock<DateTime>(); // static

            string numberAsInt = string.Empty;
            bool isAfterDot = false;
            bool hasOnlyZerosAfterDot = true;

            string valueAsString = value.ToString();

            for (int index = 0; index < valueAsString.Length; index++)
            {
                if (valueAsString[index] == '.')
                {
                    isAfterDot = true;
                }
                else if (isAfterDot == false)
                {
                    numberAsInt += valueAsString[index];
                }              
                else
                {
                    int number = int.Parse(valueAsString[index].ToString());

                    if (number != 0)
                    {
                        hasOnlyZerosAfterDot = false;
                        break;
                    }
                }
            }

            double expectedValue = double.Parse(numberAsInt);

            if (hasOnlyZerosAfterDot == false && expectedValue < 0)
            {
                expectedValue--;
            }

            Assert.That(Math.Floor(value), Is.EqualTo(expectedValue));
        }
    }
}
