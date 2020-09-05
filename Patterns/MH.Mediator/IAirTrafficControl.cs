namespace MH.Mediator
{
    public interface IAirTrafficControl
    {
        void AddAirplanes(params AirplaneBase[] airplanes);

        void SendMessage(string message, AirplaneBase messageProducerAirplane);
    }
}