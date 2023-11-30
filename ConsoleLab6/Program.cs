using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car(),
            new Bus(),
            new Train()
        };

        TransportNetwork transportNetwork = new TransportNetwork(vehicles);
        transportNetwork.SimulateTransport(5);

    }
}
