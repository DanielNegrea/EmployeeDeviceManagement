using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class Device
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "Please enter a device name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a manufacturer name")]
        public string Manufacturer { get; set; }
        [Required(ErrorMessage = "Please enter an operating system")]
        public string OperatingSystem { get; set; }
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Please enter a positive value")]
        public double OsVersion { get; set; }
        [Required(ErrorMessage = "Please enter a processor")]
        public string Processor { get; set; }
        [Required(ErrorMessage = "Please enter a RAM Amount")]
        public string RamAmount { get; set; }
        [Required(ErrorMessage = "Please specify a type")]
        public string Type { get; set; }
    }
}
