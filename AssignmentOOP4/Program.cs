using Assignment03OOP;

namespace AssignmentOOP4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  Q1

            // A) Abstraction is the process of hiding unnecessary implementation details and showing only the essential features of an object
            // B) because it reduces complexity by hiding implementation details and exposing only the essential functionality, making code easier to understand, maintain, and extend

            #endregion

            #region Q2 

            // A) An abstract class can contain shared code, fields, constructors, and An interface mainly defines a contract
            // B) when unrelated classes need to share the same contract
            // c) No, a class cannot inherit from multiple abstract classes But it can implement multiple interfaces


            #endregion

            #region Practical

            //DeliveryCenter deliveryCenter = new DeliveryCenter();

            //Console.WriteLine("------------Standard Shipment------------");
            //Console.WriteLine("Enter Tracking Code:");
            //string standardShipmentTrackingCode = Console.ReadLine();
            //Console.WriteLine("Enter Description:");
            //string standardShipmentDescription = Console.ReadLine();
            //Console.WriteLine("Enter Weight:");
            //int standardShipmentWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Delivery Fee:");
            //decimal standardShipmentDeliveryFee = decimal.Parse(Console.ReadLine());


            //Console.WriteLine("------------Express Shipment------------");
            //Console.WriteLine("Enter Tracking Code:");
            //string ExpressShipmentTrackingCode = Console.ReadLine();
            //Console.WriteLine("Enter Description:");
            //string ExpressShipmentDescription = Console.ReadLine();
            //Console.WriteLine("Enter Weight:");
            //int ExpressShipmentWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Delivery Fee:");
            //decimal ExpressShipmentDeliveryFee = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Extra Fee:");
            //decimal ExpressShipmentExtraFee = decimal.Parse(Console.ReadLine());


            //Console.WriteLine("------------International Shipment------------");
            //Console.WriteLine("Enter Tracking Code:");
            //string InternationalShipmentTrackingCode = Console.ReadLine();
            //Console.WriteLine("Enter Description:");
            //string InternationalShipmentDescription = Console.ReadLine();
            //Console.WriteLine("Enter Weight:");
            //int InternationalShipmentWeight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Delivery Fee:");
            //decimal InternationalShipmentDeliveryFee = decimal.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Destination Country:");
            //string ExpressShipmentDestinationCountry = Console.ReadLine();
            //Console.WriteLine("Enter Customs Fee:");
            //decimal InternationalShipmentCustomsFee = decimal.Parse(Console.ReadLine());



            //StandardShipment standardShipment = new StandardShipment(standardShipmentTrackingCode, standardShipmentDescription, standardShipmentWeight, standardShipmentDeliveryFee);
            //ExpressShipment expressShipment = new ExpressShipment(ExpressShipmentTrackingCode, ExpressShipmentDescription, ExpressShipmentWeight, ExpressShipmentDeliveryFee, ExpressShipmentExtraFee);
            //InternationalShipment internationalShipment = new InternationalShipment(InternationalShipmentTrackingCode, InternationalShipmentDescription, InternationalShipmentWeight, InternationalShipmentDeliveryFee, ExpressShipmentDestinationCountry, InternationalShipmentCustomsFee);

            //deliveryCenter.AddShipment(standardShipment);
            //deliveryCenter.AddShipment(expressShipment);
            //deliveryCenter.AddShipment(internationalShipment);

            //deliveryCenter.PrintAllShipments();

            //Console.WriteLine("Tracking Status: ");
            //deliveryCenter.PrintTrackingStatuses();

            //Console.WriteLine("Insurance: ");
            //deliveryCenter.PrintCalculateInsurance();

            //Console.WriteLine("using ITrackable[] array: ");

            //ITrackable[] trackables = { standardShipment, expressShipment, internationalShipment };
            //foreach (ITrackable item in trackables)
            //{
            //    Console.WriteLine(item.GetTrackingStatus());
            //}

            //Console.WriteLine("using IInsurable[] array: ");

            //IInsurable[] insurables = { standardShipment, expressShipment, internationalShipment };
            //foreach (IInsurable item in insurables)
            //{
            //    Console.WriteLine(item.CalculateInsurance());
            //}





            #endregion


        }
    }
}
