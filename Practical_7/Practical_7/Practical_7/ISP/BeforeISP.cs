using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.ISP
{
    class beforeISP
    {
        static void Main(string[] args)
        {
            //Using HPLaserJetPrinter we can access all Printer Services
            HPLaserJetPrinterbeforeISP hPLaserJetPrinterbeforeISP = new HPLaserJetPrinterbeforeISP();
            hPLaserJetPrinterbeforeISP.PrintbeforeISP("Printing");
            hPLaserJetPrinterbeforeISP.ScanbeforeISP("Scanning");
            hPLaserJetPrinterbeforeISP.FaxbeforeISP("Faxing");
            hPLaserJetPrinterbeforeISP.PrintDuplexbeforeISP("PrintDuplex");

            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
            LiquidInkjetPrinterbeforeISP liquidInkjetPrinterbeforeISP = new LiquidInkjetPrinterbeforeISP();
            liquidInkjetPrinterbeforeISP.PrintbeforeISP("Printing");
            liquidInkjetPrinterbeforeISP.ScanbeforeISP("Scanning");
            Console.ReadKey();
        }
    }

    public interface IPrinterTasksbeforeISP
    {
        void PrintbeforeISP(string PrintContent);
        void ScanbeforeISP(string ScanContent);
        void FaxbeforeISP(string FaxContent);
        void PrintDuplexbeforeISP(string PrintDuplexContent);
    }



    public class HPLaserJetPrinterbeforeISP : IPrinterTasksbeforeISP
    {
        public void PrintbeforeISP(string PrintContent)
        {
            Console.WriteLine("Print Done");

        }
        public void ScanbeforeISP(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void FaxbeforeISP(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplexbeforeISP(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }


    class LiquidInkjetPrinterbeforeISP : IPrinterTasksbeforeISP
    {
        public void PrintbeforeISP(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void ScanbeforeISP(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void FaxbeforeISP(string FaxContent)
        {
            throw new NotImplementedException();
        }
        public void PrintDuplexbeforeISP(string PrintDuplexContent)
        {
            throw new NotImplementedException();
        }
    }
}
