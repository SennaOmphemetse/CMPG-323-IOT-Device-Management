using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class ZoneRepository : GenericRepository<Zone>, IZoneRepository
    {
        public ZoneRepository(ConnectedOfficeContext context) : base(context)
        {

        }

        public Zone GetMostRecentZone()
        {
            throw new System.NotImplementedException();
        }

        void IZoneRepository.AddZone(Zone zone)
        {
            throw new System.NotImplementedException();
        }

        void IZoneRepository.EditZone(Zone zone)
        {
            throw new System.NotImplementedException();
        }

        void IZoneRepository.GetMostRecentGetById(int zone)
        {
            throw new System.NotImplementedException();
        }

        void IZoneRepository.RemoveRangeZone(Zone zone)
        {
            throw new System.NotImplementedException();
        }

        void IZoneRepository.RemoveZone(Zone zone)
        {
            throw new System.NotImplementedException();
        }

        void IZoneRepository.ViewZone(Zone zone)
        {
            throw new System.NotImplementedException();
        }
    }
}
