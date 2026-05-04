namespace KegTracker.API.Models;

public class Keg
{
    public int Id { get; set; }
    public int BeerId { get; set; }
    public Beer Beer { get; set; } = null!;
    public double CapacityLitres { get; set; }
    public double RemainingLitres { get; set; }
    public KegStatus Status { get; set; }
}

public enum KegStatus
{
    Full,
    InUse,
    Empty
}