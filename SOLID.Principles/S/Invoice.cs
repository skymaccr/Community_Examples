/// <summary>
/// S - Single Responsibility Principle (SRP)
///  Definition: A class should have only one reason to change, meaning it should have only one job or responsibility.
/// </summary>
namespace SOLID.Principles.S
{
    public class Invoice_Wrong
    {
        public void CalculateTotal()
        {
            Console.WriteLine("Calculation logic");
        }
        public void PrintInvoice()
        {
            Console.WriteLine("Printing logic");
        }
    }

      
    public class Invoice
    {
        public void CalculateTotal()
        {
            Console.WriteLine("Calculation logic");
        }
    }

    public class InvoicePrinter
    {
        public void PrintInvoice(Invoice invoice)
        {
            Console.WriteLine("Printing logic");
        }
    }
}
