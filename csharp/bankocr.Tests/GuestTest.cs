using System;
using bankocr;
using Xunit;

namespace bankocr.Tests
{
    public class GuestTest
    {
        private readonly Guest _guest;
        public GuestTest()
        {
            _guest = new Guest();
        }
        [Fact]
        public void TestVerifyLimitGuests()
        {
            var result = _guest.verifyLimitGuests();
            Assert.True(result);
        }
        [Fact]
        public void TestNumberGuestMale()
        {
            var result = _guest.getAmountMales();
            var expected = 3;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestNumberGuestFemales()
        {
            var result = _guest.getAmountFemales();
            var expected = 5;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestVerifyFemalesThanMoreMales()
        {
            var result = _guest.verifyFemalesThanMoreMales();
            
            Assert.True(result);
        }
    }
}