public class Dose
{
    public string Name { get; set; }
    public double Mg { get; set; }
    public DateTime Timestamp { get; set; }

    public Dose(string name, double mg, DateTime timestamp)
    {
        Name = name;
        Mg = mg;
        Timestamp = timestamp;
    }
    public override string ToString()
    {
        return $"{Name} - {Mg} mg at {Timestamp:HH:mm}";
    }
}
