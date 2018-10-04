using System;

namespace ACME.MonthlyJob
{
    public interface IPrintRequester
    {
        void SendRequest(PrintRequest request);
    }   
}