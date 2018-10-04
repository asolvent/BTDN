namespace ACME.MonthlyJob
{
    public class PrintRequest
    {
        public string CompanyName { get; set; }

        public string EndPoint { get; set; }

        public string PayloadTemplate { get; set; }

        public long? PublicationId { get; set; }

        public string PublicationName { get; set; }

        public string AddressLines { get; set; }
        
    }
}
