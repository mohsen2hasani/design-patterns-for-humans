using System;

namespace MH.Mediator
{
    public class AirbusAirplane : AirplaneBase
    {
        public AirbusAirplane(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Airbus airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Airbus airplane gets message: " + message);
        }
    }

    public class BoeingAirplane : AirplaneBase
    {
        public BoeingAirplane(IAirTrafficControl airTrafficControl) : base(airTrafficControl)
        {
        }

        public override void Send(string message)
        {
            Console.WriteLine("Boeing airplane sends message: " + message);
            AirTrafficControl.SendMessage(message, this);
        }

        public override void Notify(string message)
        {
            Console.WriteLine("Boeing airplane gets message: " + message);
        }
    }
}