using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03OOP
{
    internal struct DeliveryAddress
    {
        private string? city;
        private string? street;
        private int buildingNumber;

        public string City
        {
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public int BuildingNumber
        {
            get
            {
                return buildingNumber;
            }
            set
            {
                buildingNumber = value;
            }
        }

        public string Street
        {
            get
            {
                return street;
            }
            set
            {
                street = value;
            }
        }


        public DeliveryAddress()
        {
            city = "None";
            street = "None";
            buildingNumber = 0;
        }

        public string GetFullAddress()
        {
            return $"City: {city},Street: {street}, Biilding Number: {buildingNumber}";
        }
    }
}
