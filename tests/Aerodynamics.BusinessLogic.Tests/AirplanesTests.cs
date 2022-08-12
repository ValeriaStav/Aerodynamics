namespace Aerodynamics.BusinessLogic.Tests
{
    public class AirplanesTests
    {
        [Fact]
        public void ShouldBeAbleToCreateAirplane()
        {
            Airplane airplane = new Airplane();        
        }

        [Fact]
        public void ShouldBeAbleToSetAirplaneSpeed()
        {
            Airplane airplane = new Airplane();
            airplane.SetSpeed(5);
            Assert.Equal(5, airplane.Speed);
        }

        [Fact]
        public void ShouldNotBeAbleToSetAirplaneSpeed()
        {
            Airplane airplane = new Airplane();
            Assert.Throws<InvalidOperationException>(() => { airplane.SetSpeed(200); });
        }
    }
}