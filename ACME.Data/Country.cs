namespace ACME.Data
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            CustomerAddresses = new HashSet<CustomerAddress>();
            DistributionCompanyAddresses = new HashSet<DistributionCompanyAddress>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte CountryId { get; set; }

        [Required]
        [StringLength(100)]
        public string CountryName { get; set; }

        [StringLength(200)]
        public string Description { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CustomerAddress> CustomerAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DistributionCompanyAddress> DistributionCompanyAddresses { get; set; }
    }
}
