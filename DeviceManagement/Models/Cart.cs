using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DeviceManagement.Models
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public virtual void AddItem(Device device, int quantity)
        {
            CartLine line = lineCollection
                .Where(d => d.Device.ID == device.ID)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine
                {
                    Device = device,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }

        public virtual void RemoveLine(Device device) =>
            lineCollection.RemoveAll(l => l.Device.ID == device.ID);

        public virtual decimal ComputeTotalValue() =>
            lineCollection.Sum(e => e.Quantity);

        public virtual void Clear() => lineCollection.Clear();

        public virtual IEnumerable<CartLine> Lines => lineCollection;
    }

    public class CartLine
    {
        public int CartLineID { get; set; }
        public Device Device { get; set; }
        public int Quantity { get; set; }
    }
}
