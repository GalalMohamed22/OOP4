using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class PriorityInternationalShipment : InternationalShipment
    {
        public PriorityInternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee, destinationCountry, customsFee)
        {
            
        }
        public sealed override void GenerateCustomsReport()
        {
            base.GenerateCustomsReport();
        }
    }
}
