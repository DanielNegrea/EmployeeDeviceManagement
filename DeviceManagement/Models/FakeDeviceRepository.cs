using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class FakeDeviceRepository/* : IDeviceRepository */
    {
        public IQueryable<Device> Devices => new List<Device>
        {
            new Device {Name = "IPhone 5", Manufacturer = "Apple", OperatingSystem = "IOS" }
        }.AsQueryable<Device>();
    }
}
