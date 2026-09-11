using AssignmentOOP4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal abstract class Shipment: ITrackable , IInsurable
    {

        protected string trackingCode;
        protected string description;
        protected decimal weight;
        protected decimal deliveryFee;

        public Shipment(string trackingCode)
        {
            if (!ValidationTrackingCode(trackingCode))
            {
                this.trackingCode = "None";
            }
            else
                this.trackingCode = trackingCode;
            Description = "Unknown";
            Weight = 1;
            DeliveryFee = 50;
        }
        public Shipment(string trackingCode, string description, decimal weight, decimal deliveryFee)
        {
            if (!ValidationTrackingCode(trackingCode))
            {
                this.trackingCode = "None";
            }
            else
                this.trackingCode = trackingCode;
            this.description = description;
            this.weight = weight;
            this.deliveryFee = deliveryFee;
        }

        public DeliveryAddress Destination
        {
            get; set;
        }

        public string TrackingCode
        {
            get => trackingCode;

        }

        public string Description
        {
            get
            {
                return description;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    description = "None";
                else description = value;
            }

        }
        public decimal Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value > 0 ? value : 0;
            }
        }
        public decimal DeliveryFee
        {
            get => deliveryFee;
            private set => deliveryFee = value;
        }

        public abstract decimal EstimatedCost { get; }

        public void UpdateDeliveryFee(decimal newFee)
        {
            DeliveryFee = newFee > 0 ? deliveryFee + newFee : deliveryFee;
        }
        private bool ValidationTrackingCode(string tracking_code)
        {
            if (string.IsNullOrEmpty(tracking_code) || string.IsNullOrWhiteSpace(tracking_code))
                return false;
            else return true;
        }

        public void UpdateWeight(int newWeight)
        {
            Console.WriteLine($"Original Weight: {Weight}");
            Weight = newWeight;
            Console.WriteLine($"Updated Weight: {Weight}");
        }
        public void UpdateWeight(int newWeight, int ExtraPackingWeight)
        {

            Weight = newWeight + (ExtraPackingWeight > 0 ? ExtraPackingWeight : 0);
            Console.WriteLine($"Updated Weight After Packing: {Weight}");
        }

        public abstract void PrintShipment();

        public string GetTrackingStatus()
        {
            throw new NotImplementedException();
        }

        public decimal CalculateInsurance()
        {
            throw new NotImplementedException();
        }
    }
}
