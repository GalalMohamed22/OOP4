using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal sealed class CompletedShipment : Shipment
    {
        public CompletedShipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : base(trackingCode,description,weight, deliveryFee)
        {
            
        }

        public override decimal EstimatedCost => throw new NotImplementedException();

        public override void PrintShipment()
        {
            throw new NotImplementedException();
        }
    }
}
