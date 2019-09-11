using System;
using Xunit;
using bankocr;
using System.Collections.Generic;

namespace bankocr.Tests
{
    public class UnitTestSupervisor
    {
        public readonly Supervisor _supervisor;
        List<Supervisor> supervisorList = new List<Supervisor>()
            {
                new Supervisor("Ariana", "Ariana@gmail.com", 74717171),
                new Supervisor("Benita", "Benita@gmail.com", 65987412),
                new Supervisor("Jose", "Jose@gmail.com", 78541236)
            };
        public UnitTestSupervisor()
        {
            _supervisor = new Supervisor();
        }

        [Fact]
        public void WhenNewASupervisorIsCreatedWithNameTheNameShouldBeSetAndReturn()
        {
            Supervisor testSupervisor = new Supervisor("Ariana", "Ariana@gmail.com", 15265487);
            Assert.Equal("Ariana", testSupervisor.Name);
        }

        [Fact]
        public void WhenAddListOfSupervisorShouldBeSetAndReturn()
        {
            var testSupervisor = _supervisor.returnlistOfSupervisors(supervisorList);
            Assert.Equal("Ariana", testSupervisor[0].Name);
            Assert.Equal("Benita", testSupervisor[1].Name);
            Assert.Equal("Jose", testSupervisor[2].Name);
        }
    }
}