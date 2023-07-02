namespace CarShop.Api.Models
{
    public class Car
    {
        public long Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Version { get; set; }
        public string Company { get; set; } = string.Empty;
        public string Color { get; set; } = string.Empty;
        public double Price { get; set; }
        public DateTime ProductionAt { get; set; }
    }
}
