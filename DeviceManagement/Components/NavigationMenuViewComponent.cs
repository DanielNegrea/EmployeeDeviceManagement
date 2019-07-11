using DeviceManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private IDeviceRepository repository;

        public NavigationMenuViewComponent(IDeviceRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedType = RouteData?.Values["type"];
            return View(repository.Devices
                .Select(x => x.Type)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
