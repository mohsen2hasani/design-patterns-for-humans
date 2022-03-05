using System.Collections.Generic;
using System.Linq;

namespace MH.Mediator;

public class MehrabadAirTrafficControl : IAirTrafficControl
{
    private readonly List<AirplaneBase> _airplanes = new();
    public void AddAirplanes(params AirplaneBase[] airplanes)
    {
        _airplanes.AddRange(airplanes);
    }

    public void SendMessage(string message, AirplaneBase messageProducerAirplane)
    {
        var otherAirplanes = _airplanes
            .Where(airplane => airplane != messageProducerAirplane)
            .ToList();

        otherAirplanes.ForEach(airplane => airplane.Notify(message));
    }
}