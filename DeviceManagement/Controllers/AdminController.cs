using DeviceManagement.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private IDeviceRepository repository;

        public AdminController(IDeviceRepository repo)
        {
            repository = repo;
        }

        public ViewResult Index() => View(repository.Devices);

        public ViewResult Edit(int deviceId) =>
            View(repository.Devices
                .FirstOrDefault(d => d.ID == deviceId));

        [HttpPost]
        public IActionResult Edit(Device device)
        {
            if (ModelState.IsValid)
            {
                repository.SaveDevice(device);
                TempData["message"] = $"{device.Name} has been saved";
                return RedirectToAction("Index");
            }
            else
            {
                // there is something wrong with the data values
                return View(device);
            }
        }

        public ViewResult Create() => View("Edit", new Device());

        [HttpPost]
        public IActionResult Delete(int deviceId)
        {
            Device deletedDevice = repository.DeleteDevice(deviceId);
            if (deletedDevice != null)
            {
                TempData["message"] = $"{ deletedDevice.Name} was deleted";
            }
            return RedirectToAction("Index");
        }
    }
}
