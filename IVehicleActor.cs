using System;
using System.Threading.Tasks;
using Dapr.Actors;

namespace Adsb.Actors.Interfaces
{
    public interface IVehicleActor : IActor
    {
        Task SetPositionAsync(Position positionData);
        Task<Position> GetPositionAsync();
    }

    public class Position
    {
        public Position() { }
        public Position(decimal latitude, decimal longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}