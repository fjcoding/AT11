using System;
using bankocr;
using Xunit;

namespace TestGuest.Tests
{
    public class TestGuest
    {
        readonly private Guest _guest; 
        public TestGuest()
        {
               _guest = new Guest();
        }

        [Fact]
        public void WhenThereAreManyMenThanWomenReturnTrue()
        {
            int [] guests = {-1, -1, -1, -1, 1, 1, 1, 1, 1, 1};
            var result = _guest.VerifyAmountOfGuests(guests);
            var expected = true;
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenThereAreManyWomenThanMenReturnFalse()
        {
            int [] guests = {-1, -1, -1, -1, -1, -1, -1, 1, 1, 1};
            var result = _guest.VerifyAmountOfGuests(guests);
            var expected = false;
            Assert.Equal(expected, result);
        } 

        [Fact]
        public void WhenThereAreTheSameWomenAndMenReturnFalse()
        {
            int [] guests = {-1, -1, -1, -1, -1, 1, 1, 1, 1, 1};
            var result = _guest.VerifyAmountOfGuests(guests);
            var expected = false;
            Assert.Equal(expected, result);
        }
        
    }
}