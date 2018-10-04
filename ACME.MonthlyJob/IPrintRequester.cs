using System;

namespace ACME.MonthlyJob
{
    public interface IPrintRequester
    {
        void SendRequest(PrintRequest request);
    }

    public class PrintRequester : IPrintRequester {
        public void SendRequest(PrintRequest request) {
            Console.WriteLine("Distribution Company");
            Console.Write(request.PublicationName);
            Console.Write(request.EndPoint);
            Console.Write(request.PayloadTemplate);

            Console.WriteLine("Publication Details");
            Console.Write(request.PublicationId);
            Console.Write(request.PublicationName);

            Console.WriteLine("Customer Details");
            Console.Write(request.AddressLines);
        }
    }
}