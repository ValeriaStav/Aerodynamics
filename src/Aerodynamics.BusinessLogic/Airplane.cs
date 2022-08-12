namespace Aerodynamics.BusinessLogic
{
    public class Airplane : BaseAirplane
    {
        public int Speed { get; protected set; } // инкапсуляция

        public override void SetSpeed(int speed)
        {
            if (speed > 100)
                throw new InvalidOperationException("Can't set airplane speed greater than 100");
            Speed = speed;
        }
    }
}