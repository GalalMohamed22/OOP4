using AssignmentOOP4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class InternationalShipment : Shipment, ITrackable, IInsurable
    {
        public InternationalShipment(string trackingCode, string description, decimal weight, decimal deliveryFee, string destinationCountry, decimal customsFee) : base(trackingCode, description, weight, deliveryFee)
        {
            DestinationCountry = destinationCountry;
            CustomsFee = customsFee;
        }
        private string destinationCountry;
        private decimal customsFee;

        public string DestinationCountry
        {
            get
            {
                return destinationCountry;
            }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    destinationCountry = value;
            }
        }
        public decimal CustomsFee
        {
            get
            {
                return customsFee;
            }
            set
            {
                customsFee = value >= 0 ? value : 0;
            }
        }
        public override decimal EstimatedCost => deliveryFee + (weight * 5) + CustomsFee;

        public override void PrintShipment()
        {
            Console.WriteLine($"TrackingCode: {TrackingCode}\n Description: {Description}\n Weight: {Weight} KG\n DeliveryFee: {DeliveryFee} EGP\n Estimated Cost: {EstimatedCost} EGP\n Destination Country: {DestinationCountry}, Customs Fee: {CustomsFee} EGP\n");
        }
        public virtual void GenerateCustomsReport()
        {


        }

        public string GetTrackingStatus()
        {
            return $"Shipment {trackingCode} has been Delivered.\n";
        }

        public decimal CalculateInsurance()
        {
            return 0.12m * EstimatedCost;
        }

    }
}
