using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.MonthlyJob
{
    public class PrintRequester : IPrintRequester
    {
        public void SendRequest(PrintRequest request)
        {
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
