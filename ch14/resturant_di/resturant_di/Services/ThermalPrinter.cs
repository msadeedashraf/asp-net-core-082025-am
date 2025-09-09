using System.Diagnostics;

namespace resturant_di.Services
{
    public class ThermalPrinter :IReceiptPrinter
    {
        public void Print(string orderDetails)
        {
            // In reality, send command to printer
            //Debug.WriteLine("Printing to thermal printer...");
            Console.WriteLine($"[ThermalPrinter] Order: {orderDetails}");
        }
    }
}
