using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class SeedData
    {
        public static void Seed(ApplicationDbContext context)
        {
            if (!context.Devices.Any())
            {
                context.AddRange
                    (
                    new Device { Name = "Huawei P20", Manufacturer = "Huawei", OperatingSystem = "Android", OsVersion = 8.0,
                    Processor = "Kirin 659", RamAmount = "4GB", Type = "Phone"},
                    new Device { Name = "Samsung Galaxy S8 Plus", Manufacturer = "Samsung", OperatingSystem = "Android", OsVersion = 8.0,
                    Processor = "Octa Core", RamAmount = "4GB", Type = "Phone"},
                    new Device { Name = "Apple iPhone7", Manufacturer = "Apple", OperatingSystem = "iOS", OsVersion = 10.0,
                    Processor = "Quad Core", RamAmount = "2GB", Type = "Phone"},
                    new Device { Name = "Dell Inspiron 3576", Manufacturer = "Dell", OperatingSystem = "Windows", OsVersion = 10.0,
                    Processor = "Intel i5 8550U", RamAmount = "8GB", Type = "Laptop"},
                    new Device { Name = "Dell Inspiron 5370", Manufacturer = "Dell", OperatingSystem = "Windows", OsVersion = 10.0,
                    Processor = "Intel i7 8550U", RamAmount = "16GB", Type = "Laptop"},
                    new Device { Name = "Lenovo IdeaPad 330-151KB", Manufacturer = "Lenovo", OperatingSystem = "Windows", OsVersion = 10.0,
                    Processor = "Intel i5 8250U", RamAmount = "8GB", Type = "Laptop"},
                    new Device { Name = "Apple iPad 9.7", Manufacturer = "Apple", OperatingSystem = "iOS", OsVersion = 11.0,
                    Processor = "A10 Fusion", RamAmount = "2GB", Type = "Tablet"},
                    new Device { Name = "Samsung Galaxy Tab A10.1", Manufacturer = "Samsung", OperatingSystem = "Android", OsVersion = 9.0,
                    Processor = "Samsung", RamAmount = "2GB", Type = "Tablet"},
                    new Device { Name = "Lenovo Tab P10 TB-X705F", Manufacturer = "Lenovo", OperatingSystem = "Android", OsVersion = 8.0,
                    Processor = "Qualcomm Snapdragon 450", RamAmount = "4GB", Type = "Tablet"}
                    );

                context.SaveChanges();
            }
        }
    }
}
