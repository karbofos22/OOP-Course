using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class DeliveryService : Client
    {
        public List<object> randomOperator;

        public string ClientsDocuments { get; set; }

        public Cargo CargoAtStorage { get; set; }

        public void ReceiveCargoFromClient(Client client)
        {
        }
        public void issueClientDocuments()
        {

        }
        public void PutCargoToStorage()
        {

        }
        public void RejectProhibitedCargo()
        {

        }
    }
}
