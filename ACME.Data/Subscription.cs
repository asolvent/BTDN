namespace ACME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Subscription")]
    public partial class Subscription
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Subscription()
        {
            PrintDistributions = new HashSet<PrintDistribution>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long SubscriptionId { get; set; }

        public long AddressId { get; set; }

        public long? PublicationId { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        public virtual CustomerAddress CustomerAddress { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrintDistribution> PrintDistributions { get; set; }

        public virtual Publication Publication { get; set; }
    }
}
