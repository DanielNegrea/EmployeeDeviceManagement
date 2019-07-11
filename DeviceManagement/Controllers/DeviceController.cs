using DeviceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq;
using DeviceManagement.ViewModels;

namespace DeviceManagement.Controllers
{
    public class DeviceController : Controller
    {
        private IDeviceRepository repository;
        public int PageSize = 4;

        public DeviceController(IDeviceRepository repo)
        {
            repository = repo;
        }

        public ViewResult List(string type, int devicePage = 1)
            => View(new DevicesListViewModel
            {
                Devices = repository.Devices
                .Where(p => type == null || p.Type == type)
                .OrderBy(p => p.ID)
                .Skip((devicePage - 1) * PageSize)
                .Take(PageSize),
              PagingInfo = new PagingInfo
              {
                  CurrentPage = devicePage,
                  ItemsPerPage = PageSize,
                  TotalItems = type == null ?
                  repository.Devices.Count() :
                  repository.Devices.Where(e => e.Type == type).Count()
              },
              CurrentType = type
         });
    }
}
