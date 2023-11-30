class Train : Vehicle
{
    public override void Move()
    {
        Console.WriteLine($"Train is moving at a speed of {Speed} km/h with a capacity of {Capacity} passengers.");
    }
}