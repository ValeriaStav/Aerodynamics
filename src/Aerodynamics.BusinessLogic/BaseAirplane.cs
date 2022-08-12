using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aerodynamics.BusinessLogic
{
    public abstract class BaseAirplane
    {
        public int Speed { get; protected set; } // инкапсуляция

        public abstract void SetSpeed(int speed);
    }
}
