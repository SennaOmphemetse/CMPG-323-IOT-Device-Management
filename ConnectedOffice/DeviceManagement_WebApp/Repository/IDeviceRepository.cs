using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public interface IDeviceRepository : IGenericRepository<Device>
    {
        Device GetMostRecentDevice();
        void GetMostRecentGetById(int devi);

        void RemoveDevice(Device device);
        void AddDevice(Device device);
        void RemoveRangeDevice(Device device);
        void EditDevice(Device device);
        void ViewDevice(Device device);
    }
}
