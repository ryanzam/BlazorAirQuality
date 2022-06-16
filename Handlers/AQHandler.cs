using BlazorAirQuality.DTOs;
using BlazorAirQuality.Queries;
using BlazorAirQuality.Services;
using MediatR;

namespace BlazorAirQuality.Handlers
{
    public class AQHandler : IRequestHandler<AirQualityQuery, AirQuality[]>
    {
        private readonly AQService aQService;

        public AQHandler(AQService aQService)
        {
            this.aQService = aQService;
        }
        public async Task<AirQuality[]> Handle(AirQualityQuery request, CancellationToken cancellationToken)
        {
            return await this.aQService.GetAllAQ();
        }
    }
}
