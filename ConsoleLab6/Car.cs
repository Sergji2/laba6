class Car : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"Car is moving at a speed of {Speed} km/h with a capacity of {Capacity} passengers.");
    }
}