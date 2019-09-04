using System;
using bankocr;
using Xunit;

namespace bankocr.Tests
{
    public class PartyOrganizerTest
    {
        private readonly PartyOrganizer _partyOrganizer;

        public PartyOrganizerTest()
        {
            _partyOrganizer = new PartyOrganizer();
        }
        [Fact]
        public void TestNumberPartyOrganizerMale()
        {
            int [] listGuests = new int[10] {-1, -1, -1, -1, -1, 1, 1, 1, -1, -1};
            
            _partyOrganizer.obtainListGuests(listGuests);
            
            var result = _partyOrganizer.getAmountMales();
            var expected = 3;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestNumberPartyOrganizerFemales()
        {
            int [] listGuests = new int[10] {-1, 1, -1, 1, -1, 1, 1, 1, -1, -1};
            
            _partyOrganizer.obtainListGuests(listGuests);

            var result = _partyOrganizer.getAmountFemales();
            var expected = 5;

            Assert.Equal(expected, result);
        }
        [Fact]
        public void TestVerifyMoreFemalesThanMales()
        {
            int [] listGuests = new int[10] {1, -1, 1, -1, -1, 1, 1, 1, -1, -1};
            
            _partyOrganizer.obtainListGuests(listGuests);
            
            var result = _partyOrganizer.verifyFemalesThanMoreMales();
            
            Assert.True(result);
        }
    }
}