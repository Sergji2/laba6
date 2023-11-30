class Bus : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"Bus is moving at a speed of {Speed} km/h with a capacity of {Capacity} passengers.");
    }
}