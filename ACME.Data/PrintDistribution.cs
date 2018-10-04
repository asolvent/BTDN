namespace ACME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PrintDistribution")]
    public partial class PrintDistribution
    {
        public long PrintDistributionId { get; set; }

        public long SubscriptionId { get; set; }

        public int DistributionCompnayId { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual DistributionCompany DistributionCompany { get; set; }

        public virtual Subscription Subscription { get; set; }
    }
}
