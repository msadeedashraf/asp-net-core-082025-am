namespace resturant_di.Services
{
    public class PdfPrinter : IReceiptPrinter
    {
        public void Print(string orderDetails)
        {
            // In reality, generate a PDF file
            var path = Path.Combine(Directory.GetCurrentDirectory(), "receipt.txt");
            File.WriteAllText(path, $"[PDF RECEIPT]\n{orderDetails}");
            Console.WriteLine($"PDF receipt saved at {path}");
        }

    }
}
