using MH.Mediator;
using System;
using System.Threading.Tasks;

namespace MH.UsePatterns.Methods
{
    public static class MediatorTest
    {
        public static void Run()
        {
            Console.WriteLine("=-=-=-=Mediator=-=-=-=");

            IAirTrafficControl mehrabadAirTrafficControl = new MehrabadAirTrafficControl();

            AirplaneBase airbusAirplane = new AirbusAirplane(mehrabadAirTrafficControl);
            AirplaneBase boeingAirplane = new BoeingAirplane(mehrabadAirTrafficControl);

            mehrabadAirTrafficControl.AddAirplanes(airbusAirplane, boeingAirplane);

            airbusAirplane.Send("Can we land right now ?");
            Console.WriteLine("----------");

            boeingAirplane.Send("No! We're landing, wait ...");
            Console.WriteLine("----------");

            // Demonstrate landing ...
            Console.WriteLine("Boeing is landing ...");
            Console.WriteLine("----------");

            boeingAirplane.Send("We landed.");
            Console.WriteLine("----------");

            airbusAirplane.Send("OK, We're going to land ...");
            Console.WriteLine("----------");

            boeingAirplane.Send("Good luck.");

            Console.WriteLine("----------------------------------" + Environment.NewLine);
        }
    }
}