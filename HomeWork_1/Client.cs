using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Client
    {
        public enum Cargo
        {
            SpareParts,
            Clothes,
            Electronics
        }
        protected string ClientName { get; set; }
        public Cargo CargoToDeliver { get; set; }

        
        public void SendCargoToDeliveryService()
        {

        }
        public void ReceiveCargo()
        {
        }
    }
}
