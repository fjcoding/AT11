using System;
using bankocr;
using Xunit;

namespace TestGuest.Tests
{
    public class TestGuest
    {
        public TestGuest()
        {

        }
        [Fact]
        public void WhenThereAreManyMenThanWomen()
        {
            Guest objectguest = new Guest();
            int [] guests = {-1, -1, -1, -1, 1, 1, 1, 1, 1, 1};
            var result = objectguest.ReturnInviteMoreWomen(guests);
            var expected = true;
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void WhenThereAreManyWomenThanMen()
        {
            Guest objectguest = new Guest();
            int [] guests = {-1, -1, -1, -1, -1, -1, -1, 1, 1, 1};
            var result = objectguest.ReturnInviteMoreWomen(guests);
            var expected = false;
            Assert.Equal(expected, result);
        } 

        [Fact]
        public void WhenThereAreTheSameWomenAndMen()
        {
            Guest objectguest = new Guest();
            int [] guests = {-1, -1, -1, -1, -1, 1, 1, 1, 1, 1};
            var result = objectguest.ReturnInviteMoreWomen(guests);
            var expected = false;
            Assert.Equal(expected, result);


        }
        
        
    }
}