class Human
{
    public double Speed { get; set; }

    public void Move()
    {
        Console.WriteLine($"Walking at a speed of {Speed} km/h.");
    }
}