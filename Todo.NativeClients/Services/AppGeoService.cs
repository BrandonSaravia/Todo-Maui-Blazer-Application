using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.Shared.Services;

namespace Todo.NativeClients.Services
{
    public class AppGeoService : IGeoService
    {
        public AppGeoService() { }

        public async Task<Position> GetPosition()
        {
            try
            {
                var position = await Geolocation.Default.GetLocationAsync();

                return new Position()
                {
                    Latitude = position.Latitude,
                    Longitude = position.Longitude,
                };
            }
            catch(Exception ex)
            {
                throw new Exception();
            }
            
        }
    }
}
