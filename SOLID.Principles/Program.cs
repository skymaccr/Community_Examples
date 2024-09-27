using SOLID.Principles.S;
using SOLID.Principles.O;
using SOLID.Principles.L;
using SOLID.Principles.I;
using SOLID.Principles.D;

namespace SOLID.Principles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Single Responsibility Principle (SRP)
            Invoice_Wrong invoice_Wrong = new();
            invoice_Wrong.CalculateTotal();
            invoice_Wrong.PrintInvoice();

            Invoice invoice_Right = new();
            invoice_Right.CalculateTotal();

            InvoicePrinter invoicePrinter_Right = new();
            invoicePrinter_Right.PrintInvoice(invoice_Right);
            #endregion

            #region Open/Closed Principle (OCP)
            Rectangle_Wrong rectangle_Wrong = new();
            rectangle_Wrong.Width = 5;
            rectangle_Wrong.Height = 15;

            AreaCalculator_Wrong areaCalculator_Wrong = new();
            areaCalculator_Wrong.CalculateArea(rectangle_Wrong);

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 5;
            rectangle.Height = 15;
            rectangle.CalculateArea();

            #endregion

            #region Liskov Substitution Principle (LSP)
            Bird_Wrong seagul_Wrong = new Seagul_Wrong();
            seagul_Wrong.Fly();

            Bird_Wrong ostrich_Wrong = new Ostrich_Wrong();
            ostrich_Wrong.Fly();

            Bird seagul = new Seagul();
            seagul.Move();

            Bird ostrich = new Ostrich();
            ostrich.Move();

            #endregion

            #region Interface Segregation Principle (ISP)
            Worker_Wrong worker_Wrong = new Worker_Wrong();
            worker_Wrong.Work();
            worker_Wrong.Eat();

            Slave_Wrong slave_wrong = new Slave_Wrong();
            slave_wrong.Work();
            slave_wrong.Eat();

            Worker worker = new Worker();
            worker.Work();
            worker.Eat();

            Slave slave = new Slave();
            slave.Work();
            //slave does not have a definition for Eat

            #endregion

            #region Dependency Inversion Principle (DIP)
            Switch_Wrong switch_Wrong = new Switch_Wrong();
            switch_Wrong.Operate();

            ILight lightBulb = new LightBulb();
            Switch @switch = new(lightBulb);
            @switch.Operate();
            #endregion

            /**
             * Improved Maintainability
             * Enhanced Flexibility and Scalability
             * Reduced Dependencies
             * Easier Testing
             * Increased Reusability
             * Better Collaboration
             * Enhanced Code Quality
             * **/
        }
    }
}
