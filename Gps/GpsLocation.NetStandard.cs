using System;
using System.Threading.Tasks;

namespace Gps
{
    public static partial class GpsLocation
    {
        public static Task<(double latitude, double longitude)> GetCoordinates()
        {
            throw new PlatformNotSupportedException();
        }
    }
}
