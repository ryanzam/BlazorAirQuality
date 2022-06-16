using BlazorAirQuality.DTOs;
using MediatR;

namespace BlazorAirQuality.Queries
{
    public class AirQualityQuery : IRequest<AirQuality[]>
    {
        public AirQualityQuery()
        {
        }
    }
}
