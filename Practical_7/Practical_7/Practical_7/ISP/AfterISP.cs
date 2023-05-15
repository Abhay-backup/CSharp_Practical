using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical_7.ISP
{
    internal class AfterISP
    {
        static void Main(string[] args)
        {
            //Using HPLaserJetPrinter we can access all Printer Services
            HPLaserJetPrinterAfterISP hPLaserJetPrinterAfterISP = new HPLaserJetPrinterAfterISP();
            hPLaserJetPrinterAfterISP.PrintAfterISP("Printing");
            hPLaserJetPrinterAfterISP.ScanAfterISP("Scanning");
            hPLaserJetPrinterAfterISP.FaxAfterISP("Faxing");
            hPLaserJetPrinterAfterISP.PrintDuplexAfterISP("PrintDuplex");
            //Using LiquidInkjetPrinter we can only Access Print and Scan Printer Services
            LiquidInkjetPrinterAfterISP liquidInkjetPrinterAfterISP = new LiquidInkjetPrinterAfterISP();
            liquidInkjetPrinterAfterISP.PrintAfterISP("Printing");
            liquidInkjetPrinterAfterISP.ScanAfterISP("Scanning");
            Console.ReadKey();
        }

    }


    public interface IPrinterTasksAfterISP
    {
        void PrintAfterISP(string PrintContent);
        void ScanAfterISP(string ScanContent);
    }
    interface IFaxTasksAfterISP
    {
        void FaxAfterISP(string content);
    }
    interface IPrintDuplexTasksAfterISP
    {
        void PrintDuplexAfterISP(string content);
    }


    public class HPLaserJetPrinterAfterISP : IPrinterTasksAfterISP, IFaxTasksAfterISP, IPrintDuplexTasksAfterISP
    {
        public void PrintAfterISP(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void ScanAfterISP(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
        public void FaxAfterISP(string FaxContent)
        {
            Console.WriteLine("Fax content");
        }
        public void PrintDuplexAfterISP(string PrintDuplexContent)
        {
            Console.WriteLine("Print Duplex content");
        }
    }


    class LiquidInkjetPrinterAfterISP : IPrinterTasksAfterISP
    {
        public void PrintAfterISP(string PrintContent)
        {
            Console.WriteLine("Print Done");
        }
        public void ScanAfterISP(string ScanContent)
        {
            Console.WriteLine("Scan content");
        }
    }
}
