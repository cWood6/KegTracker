namespace KegTracker.API.Models;

public class ConsumptionLog
{
    public int Id { get; set; }
    public int KegId { get; set; }
    public Keg Keg { get; set; } = null!;
    public double AmountPouredLitres { get; set; }
    public DateTime PouredAt { get; set; } = DateTime.UtcNow;
}