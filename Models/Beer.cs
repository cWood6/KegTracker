namespace KegTracker.API.Models
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Brewer { get; set; } = string.Empty;
        public double ABV { get; set; }
    }
}
