using System.Text.Json.Serialization;

namespace BlazorAirQuality.DTOs
{
    public partial class AirQuality
    {
        public string? Code { get; set; }

        public string? Name { get; set; }
        public int Locations { get; set; }

        public long Count { get; set; }

        public DateTime LastUpdated { get; set; }
    }
}
