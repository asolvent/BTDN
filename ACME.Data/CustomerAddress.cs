namespace ACME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CustomerAddress")]
    public partial class CustomerAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CustomerAddress()
        {
            Subscriptions = new HashSet<Subscription>();
        }

        [Key]
        public long AddressId { get; set; }

        public long CustomerId { get; set; }

        public byte CountryId { get; set; }

        [Required]
        [StringLength(200)]
        public string AddressLines { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        [StringLength(100)]
        public string Landmark { get; set; }

        [StringLength(100)]
        public string State { get; set; }

        public DateTime? CreatedDate { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool IsActive { get; set; }

        public virtual Country Country { get; set; }

        public virtual Customer Customer { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Subscription> Subscriptions { get; set; }
    }
}
