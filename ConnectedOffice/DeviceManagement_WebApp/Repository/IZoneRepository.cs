using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public interface IZoneRepository : IGenericRepository<Zone>
    {
        Zone GetMostRecentZone();
        void GetMostRecentGetById(int zone);

        void RemoveZone(Zone zone);
        void AddZone(Zone zone);
        void RemoveRangeZone(Zone zone);
        void EditZone(Zone zone);
        void ViewZone(Zone zone);
    }
}
