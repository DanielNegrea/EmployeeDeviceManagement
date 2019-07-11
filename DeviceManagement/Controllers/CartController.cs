using DeviceManagement.Infrastructure;
using DeviceManagement.Models;
using DeviceManagement.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Controllers
{
    public class CartController : Controller
    {
        private IDeviceRepository repository;
        private Cart cart;

        public CartController(IDeviceRepository repo, Cart cartService)
        {
            repository = repo;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl)
        {
            return View(new CartIndexViewModel
            {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int deviceId, string returnUrl)
        {
            Device device = repository.Devices
                .FirstOrDefault(d => d.ID == deviceId);
            if (device != null)
            {
                cart.AddItem(device, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int deviceId,
                string returnUrl)
        {
            Device device = repository.Devices
                .FirstOrDefault(d => d.ID == deviceId);

            if (device != null)
            {
                cart.RemoveLine(device);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}
