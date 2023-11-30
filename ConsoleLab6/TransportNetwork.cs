class TransportNetwork
{
    private List<Vehicle> vehicles;

    public TransportNetwork(List<Vehicle> vehicles)
    {
        this.vehicles = vehicles;
    }

    public void SimulateTransport(int turns)
    {
        Random random = new Random();

        for (int turn = 1; turn <= turns; turn++)
        {
            Console.WriteLine($"\nTurn {turn}:");

            foreach (var vehicle in vehicles)
            {
                vehicle.Speed = random.Next(30, 100);
                vehicle.Capacity = random.Next(10, 50);

                vehicle.Move();

                if (vehicle is Bus || vehicle is Train)
                {
                    int passengersBoarding = random.Next(1, vehicle.Capacity / 2);
                    int passengersAlighting = random.Next(1, passengersBoarding);

                    Console.WriteLine($"{passengersBoarding} passengers boarded, {passengersAlighting} passengers alighted.");
                }
            }

            Console.WriteLine();
        }
    }
}