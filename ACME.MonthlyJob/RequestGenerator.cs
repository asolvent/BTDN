using ACME.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACME.MonthlyJob
{
    public class RequestGenerator
    {
        private ACMEContext context;
        private IPrintRequester printRequester;

        public RequestGenerator(ACMEContext context, IPrintRequester printRequester)//Plug DI
        {
            this.context = context;
            this.printRequester = printRequester;
        }

        public void Generate() {
            IEnumerable<PrintRequest> requests =
                context.PrintDistributions
                .Where(pd => pd.IsActive)
                .Select(dHandle => new PrintRequest{
                    CompanyName = dHandle.DistributionCompany.CompanyName,
                    EndPoint = dHandle.DistributionCompany.EndPoint,
                    PayloadTemplate = dHandle.DistributionCompany.PayloadTemplate,
                    PublicationId = dHandle.Subscription.PublicationId,
                    PublicationName = dHandle.Subscription.Publication.PublicationName,
                    AddressLines = dHandle.Subscription.CustomerAddress.AddressLines
                }); //Lets push all in one, may have to optimze the query/indexes but would be better than chatty calls

            foreach (PrintRequest request in requests) {
                printRequester.SendRequest(request); //I would ideally use TPL(s) here as this can be long operation and it would be good to run few in parallel    
            }

        }
    }
}
