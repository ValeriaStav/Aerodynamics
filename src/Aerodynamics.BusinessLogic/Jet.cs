namespace Aerodynamics.BusinessLogic
{
    public class Jet : Airplane, ITurbo, IParachute
    {
        public override void SetSpeed(int speed)
        {
            if (speed > 1500)
                throw new InvalidOperationException("Can't set jet speed greater than 1500");
            Speed = speed;
        }

        public void UseTurbo()
        {
            SetSpeed(1000);
        }
        public void UseParachute()
        {
            SetSpeed(0);
        }

    }
}
