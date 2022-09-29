using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Repository
{
    public class DeviceRepository : GenericRepository<Device>, IDeviceRepository
    {
        public DeviceRepository(ConnectedOfficeContext context) : base(context)
        {

        }

        public Device GetMostRecentDevice()
        {
            throw new System.NotImplementedException();
        }

        void IDeviceRepository.AddDevice(Device device)
        {
            throw new System.NotImplementedException();
        }

        void IDeviceRepository.EditDevice(Device device)
        {
            throw new System.NotImplementedException();
        }

        void IDeviceRepository.GetMostRecentGetById(int devi)
        {
            throw new System.NotImplementedException();
        }

        void IDeviceRepository.RemoveDevice(Device device)
        {
            throw new System.NotImplementedException();
        }

        void IDeviceRepository.RemoveRangeDevice(Device device)
        {
            throw new System.NotImplementedException();
        }

        void IDeviceRepository.ViewDevice(Device device)
        {
            throw new System.NotImplementedException();
        }
    }
}
