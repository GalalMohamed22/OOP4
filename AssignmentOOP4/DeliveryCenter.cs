using AssignmentOOP4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal class DeliveryCenter
    {
        public DeliveryCenter()
        {
            shipments = new Shipment[20];
        }

        private Shipment[] shipments;
        private string centerName;
        

        public string CenterName
        {
            get
            {
                return centerName;
            }
            set
            {
                centerName = value;
            }
        }
        public Driver driver { get; set; }


        public Shipment this[int position]
        {
            get
            {
                if (position >= shipments.Length || position < 0)
                {
                    return default(Shipment);
                }
                return shipments[position];
            }
            set
            {
                if (position < shipments.Length && position >= 0)
                {
                    shipments[position] = value;
                }
            }
        }
        public Shipment this[string TrackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i] != null && shipments[i].TrackingCode == TrackingCode)
                    {
                        return shipments[i];
                    }
                }
                return default(Shipment);
            }
        }
        public bool AddShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] == null)
                {
                    shipments[i] = shipment;
                    return true;
                }
            }
            return false;
        }
        public bool RemoveShipment(Shipment shipment)
        {
            for (int i = 0; i < shipments.Length; i++)
            {
                if (shipments[i] != null && shipments[i].TrackingCode == shipment.TrackingCode)
                {
                    shipments[i] = default(Shipment);
                    return true;
                }
            }
            return false;
        }
        public void PrintAllShipments()
        {
            for (int i = 0; i < shipments.Length; i++)
            {

                if (shipments[i] != null)
                    shipments[i].PrintShipment();
            }
        }

        public void PrintTrackingStatuses()
        {
            ITrackable[] shipmentsTrackable = shipments;
            foreach (ITrackable trackable in shipmentsTrackable)
            {
                if (trackable == null)
                    continue;
                Console.WriteLine(trackable?.GetTrackingStatus());
            }
        }
        public void PrintCalculateInsurance()
        {
            IInsurable[] shipmentsCalculate = shipments;
            foreach (IInsurable insurable in shipmentsCalculate)
            {
                if (insurable == null)
                    continue;
                Console.WriteLine($"Shipment Insurance : {insurable.CalculateInsurance()} EGP");
            }
        }

    }
}
