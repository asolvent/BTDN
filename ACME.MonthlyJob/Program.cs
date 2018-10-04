using ACME.Data;

namespace ACME.MonthlyJob
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrintRequester requester = new PrintRequester();
            ACMEContext context = new ACMEContext();
            RequestGenerator generator = new RequestGenerator(context, requester);
            generator.Generate();
        }
    }
}
