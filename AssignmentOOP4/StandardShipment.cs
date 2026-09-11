using AssignmentOOP4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class StandardShipment : Shipment,ITrackable,IInsurable
    {
        public StandardShipment(string trackingCode, string description, decimal weight, decimal deliveryFee) : base(trackingCode, description, weight, deliveryFee)
        {

        }

        public override decimal EstimatedCost => deliveryFee + (weight * 5);

        public decimal CalculateInsurance()
        {
            return 0.05m * EstimatedCost;
        }

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingCode} is Ready.\n";
        }

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}\n Description: {Description}\n Weight: {Weight} KG\n DeliveryFee: {DeliveryFee} EGP\n Estimated Cost: {EstimatedCost} EGP\n");
        }

    }
}
