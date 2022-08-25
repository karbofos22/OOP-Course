using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork_1
{
    internal class Driver : LogisticsOperator
    {
        public string DriverName { get; set; }
        public string AssignedCar { get; set; }
        public string CarMaxCarryWeight { get; set; }

        public Cargo CargoReadyForDelivery{ get; set; }


        public void ReceiveDeliveryFromStorage()
        {

        }

        public void DeliverGoods()
        {
            
        }
        public void SignDocumentsWithClient()
        {

        }
    }
}
