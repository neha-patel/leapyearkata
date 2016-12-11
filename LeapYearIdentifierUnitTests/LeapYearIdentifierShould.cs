using FluentAssertions;
using NUnit.Framework;

namespace LeapYearIdentifierUnitTests
{
    public class LeapYearIdentifierShould
    {
        private LeapYearIdentifier.LeapYearIdentifier leapYearIdentifier;

        [SetUp]
        public void Setup()
        {
            leapYearIdentifier = new LeapYearIdentifier.LeapYearIdentifier();
        }

        [TestCase(2001)]
        [TestCase(1981)]
        public void ReturnFalse_WhenIdentifyingAnArgument_GivenArgumentIsNotALeapYear(int year)
        {
            var result = leapYearIdentifier.IsLeapYear(year);

            result.Should().Be(false);
        }

        [TestCase(1996)]
        [TestCase(1956)]
        public void ReturnTrue_WhenIdentifyingAnArgument_GivenArgumentIsALeapYear(int year)
        {
            var result = leapYearIdentifier.IsLeapYear(year);

            result.Should().Be(true);
        }

        [TestCase(1900)]
        [TestCase(2100)]
        public void ReturnFalse_WhenIdentifyingAnArgument_GivenArgumentIsATypicalCommonYear(int year)
        {
            var retult = leapYearIdentifier.IsLeapYear(year);

            retult.Should().Be(false);
        }

        [TestCase(2000)]
        [TestCase(2400)]
        public void ReturnTrue_WhenIdentifyingAnArgument_GivenArgumentIsATypicalLeapYear(int year)
        {
            var result = leapYearIdentifier.IsLeapYear(year);

            result.Should().Be(true);
        }
    }
}
