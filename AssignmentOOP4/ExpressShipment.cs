using AssignmentOOP4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class ExpressShipment : Shipment, ITrackable, IInsurable
    {
        public ExpressShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, decimal extraFee) : base(trackingCode, description, weight, deliveryFee)
        {
            ExtraFee = extraFee;
        }
        private decimal extraFee;

        public decimal ExtraFee
        {
            get
            {
                return extraFee;
            }
            set
            {
                extraFee = value >= 0 ? value : 0;
            }
        }

        public override decimal EstimatedCost => deliveryFee + (weight * 5) + ExtraFee;

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}\n Description: {Description}\n Weight: {Weight} KG\n DeliveryFee: {DeliveryFee} EGP\n Estimated Cost: {EstimatedCost} EGP\n Extra Fee: {ExtraFee} EGP\n");
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingCode} is Out for Delivery.\n";
        }

        public decimal CalculateInsurance()
        {
            return 0.08m * EstimatedCost;
        }
    }
}
