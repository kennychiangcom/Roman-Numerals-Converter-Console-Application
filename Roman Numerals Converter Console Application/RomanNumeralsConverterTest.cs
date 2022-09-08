using FluentAssertions;
using NUnit.Framework;

namespace RomanNumeralsConverter.Tests
{
    public class RomanNumeralsConverterTests
    {
        private RomanNumeralsConverter RomanNumeralsConverter;

        [SetUp]
        public void Setup()
        {
            RomanNumeralsConverter = new RomanNumeralsConverter();
        }

        [Test]
        public void TestConvertingValidNumerals()
        {
            RomanNumeralsConverter.RConvert("i").Should().Be(1);
            RomanNumeralsConverter.RConvert("III").Should().Be(3);
            RomanNumeralsConverter.RConvert("iv").Should().Be(4);
            RomanNumeralsConverter.RConvert("vi").Should().Be(6);
            RomanNumeralsConverter.RConvert("viii").Should().Be(8);
            RomanNumeralsConverter.RConvert("MCMLXXXix").Should().Be(1989);
            RomanNumeralsConverter.RConvert("MMMDCCCLXXXVIII").Should().Be(3888);
        }
        [Test]
        public void TestConvertingInvalidNumerals()
        {
            RomanNumeralsConverter.RConvert("iiii").Should().Be(-1);
            RomanNumeralsConverter.RConvert("vv").Should().Be(-1);
            RomanNumeralsConverter.RConvert("xXxX").Should().Be(-1);
            RomanNumeralsConverter.RConvert("LL").Should().Be(-1);
            RomanNumeralsConverter.RConvert("CCCC").Should().Be(-1);
            RomanNumeralsConverter.RConvert("DD").Should().Be(-1);
            RomanNumeralsConverter.RConvert("MMMM").Should().Be(-1);
        }
    }
}    
