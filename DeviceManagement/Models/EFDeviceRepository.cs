using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class EFDeviceRepository : IDeviceRepository
    {
        private ApplicationDbContext context;

        public EFDeviceRepository(ApplicationDbContext ctx)
        {
            context = ctx;
        }

        public IQueryable<Device> Devices => context.Devices;

        public void SaveDevice(Device device)
        {
            if (device.ID == 0)
            {
                context.Devices.Add(device);
            }
            else
            {
                Device dbEntry = context.Devices
                    .FirstOrDefault(d => d.ID == device.ID);
                if (dbEntry != null)
                {
                    dbEntry.Name = device.Name;
                    dbEntry.Manufacturer = device.Manufacturer;
                    dbEntry.OperatingSystem = device.OperatingSystem;
                    dbEntry.OsVersion = device.OsVersion;
                    dbEntry.Processor = device.Processor;
                    dbEntry.RamAmount = device.RamAmount;
                    dbEntry.Type = device.Type;
                }
            }
            context.SaveChanges();
        }

        public Device DeleteDevice(int deviceId)
        {
            Device dbEntry = context.Devices
                .FirstOrDefault(d => d.ID == deviceId);
            if (dbEntry != null)
            {
                context.Devices.Remove(dbEntry);
                context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
