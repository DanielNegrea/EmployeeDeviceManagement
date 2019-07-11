using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public interface IDeviceRepository
    {
        IQueryable<Device> Devices { get; }

        void SaveDevice(Device device);

        Device DeleteDevice(int deviceId);
    }
}
