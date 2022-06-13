namespace BlazorAirQuality.DTOs
{
    public partial class Response
    {
        public Meta? Meta { get; set; }

        public AirQuality[]? Results { get; set; }
    }

    public partial class Meta
    {
        public string? Name { get; set; }

        public string? License { get; set; }

        public string? Website { get; set; }

        public long Page { get; set; }

        public long Limit { get; set; }

        public long Found { get; set; }
    }
}
