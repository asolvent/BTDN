namespace ACME.Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DistributionCompanyAddress")]
    public partial class DistributionCompanyAddress
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AddressId { get; set; }

        public int DistributionCompanyId { get; set; }

        public byte CountryId { get; set; }

        [Required]
        [StringLength(200)]
        public string AddressLines { get; set; }

        [Required]
        [StringLength(100)]
        public string City { get; set; }

        [StringLength(100)]
        public string State { get; set; }

        [StringLength(50)]
        public string PostCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifieldDate { get; set; }

        public bool IsActive { get; set; }

        public virtual Country Country { get; set; }

        public virtual DistributionCompany DistributionCompany { get; set; }
    }
}
