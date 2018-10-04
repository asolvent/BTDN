namespace ACME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("DistributionCompany")]
    public partial class DistributionCompany
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DistributionCompany()
        {
            DistributionCompanyAddresses = new HashSet<DistributionCompanyAddress>();
            PrintDistributions = new HashSet<PrintDistribution>();
        }

        public int DistributionCompanyId { get; set; }

        [Required]
        [StringLength(100)]
        public string CompanyName { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

        [StringLength(200)]
        public string EndPoint { get; set; }

        [Column(TypeName = "ntext")]
        public string PayloadTemplate { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DistributionCompanyAddress> DistributionCompanyAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PrintDistribution> PrintDistributions { get; set; }
    }
}
