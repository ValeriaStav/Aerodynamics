using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodynamics.BusinessLogic.Tests
{
    public class JetTests
    {
        [Fact]
        public void ShouldBeAbleToCreateJet()
        {
            Jet airplane = new Jet();
        }

        [Fact]
        public void ShouldBeAbleToSetJetSpeed()
        {
            Jet airplane = new Jet();
            airplane.SetSpeed(5);
            Assert.Equal(5, airplane.Speed);
        }

        [Fact]
        public void ShouldNotBeAbleToSetJetSpeed()
        {
            Jet airplane = new Jet();
            Assert.Throws<InvalidOperationException>(() => { airplane.SetSpeed(2000); });

            Airplane airplane1 = new Jet();
            Assert.Throws<InvalidOperationException>(() => { airplane.SetSpeed(2000); });
        }

        [Fact]
        public void ShouldBeAbleToSetUseTurbo()
        {
            Jet airplane = new Jet();
            airplane.UseTurbo();
            Assert.Equal(1000, airplane.Speed);
        }

        [Fact]
        public void ShouldBeAbleToSetUseParachute()
        {
            Jet airplane = new Jet();
            airplane.UseParachute();
            Assert.Equal(0, airplane.Speed);
        }
    }
}
